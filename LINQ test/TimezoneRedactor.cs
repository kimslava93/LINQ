using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LINQ_test
{
    public partial class TimezoneRedactor : Form
    {
        private bool OpTimeZones = false;
        private dbDataContext db;

        public TimezoneRedactor()
        {
            InitializeComponent();
        }

        private void TimezoneRedactor_Load(object sender, EventArgs e)
        {
            db = new dbDataContext();
            RefreshTable();
        }

        private void RefreshTable()
        {
            var timeZoneTable = from q in db.GetTable<timezones_t>()
                orderby q.timezone_start
                select q;

            try
            {
                timeZones_datagridView.DataSource = timeZoneTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timeZones_datagridView.CurrentRow != null)
            {
                string nameToDelete = timeZones_datagridView.CurrentRow.Cells[0].Value.ToString();

                DialogResult delete = MessageBox.Show(nameToDelete + "will be removed from DataBase!\nAre you sure?",
                    "Attention!", MessageBoxButtons.OKCancel);
                if (delete == DialogResult.OK)
                {
                    var playstationCostsToDelete = (from pc in db.GetTable<playstation_timezone>()
                        where pc.timezone_name == nameToDelete
                        select pc);

                    for (int i = 0; i < playstationCostsToDelete.Count(); i++)
                    {
                        if (playstationCostsToDelete != null)
                        {
                            foreach (var plst in playstationCostsToDelete)
                            {
                                try
                                {
                                    db.playstation_timezones.DeleteOnSubmit(plst);
                                    db.SubmitChanges();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }

                            MessageBox.Show(playstationCostsToDelete + " was deleted!");
                        }

                    }
                    var rowToDelete = (from q in db.GetTable<timezones_t>()
                        where q.timezone_name == nameToDelete
                        select q).SingleOrDefault();

                    try
                    {
                        if (rowToDelete != null)
                            db.timezones_ts.DeleteOnSubmit(rowToDelete);
                        db.SubmitChanges();
                        RefreshTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    for (int i = 0; i < ComboBoxTimeZOne.Items.Count; i++)
                    {
                        if (ComboBoxTimeZOne.Items[i].ToString() == nameToDelete)
                        {
                            ComboBoxTimeZOne.SelectedIndex = 0;
                            ComboBoxTimeZOne.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxTimeZoneName.Text == "" || textBoxTimeZoneName.Text.Length < 4)
            {
                MessageBox.Show(
                    "Length of the name of timeZone not suit to requirments. Please inout name containing more than 4 symbols");
            }
            else if (end_dateTimePicker.Value.Hour == start_datetimepicker.Value.Hour)
            {
                //change length
                MessageBox.Show("change time length ");
            }
            else
            {
//                string timeZoneName = "";
                string name = textBoxTimeZoneName.Text;
                TimeSpan startTime = TimeSpan.Parse(start_datetimepicker.Value.Hour + ":00");
                TimeSpan endTime = TimeSpan.Parse(end_dateTimePicker.Value.Hour + ":00");

                try
                {
                    Table<timezones_t> timeZonesT = db.GetTable<timezones_t>();
                    timezones_t timezones = new timezones_t();
                    timezones.timezone_name = name;
                    timezones.timezone_start = startTime;
                    timezones.timezone_end = endTime;
                    timeZonesT.InsertOnSubmit(timezones);
                    db.SubmitChanges();
                    RefreshTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    var playstations = (from q in db.GetTable<tables_t>()
                        select new
                        {
                            q.playstation_id
                        }).ToList();

                    Table<playstation_timezone> timeZoneTable;
                    playstation_timezone playstationTimezone;

                    for (int i = 0; i < playstations.Count; i++)
                    {
                        timeZoneTable = db.GetTable<playstation_timezone>();
                        playstationTimezone = new playstation_timezone
                        {
                            playstation_id = playstations[i].playstation_id,
                            timezone_name = name
                        };

                        timeZoneTable.InsertOnSubmit(playstationTimezone);
                        db.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                textBoxTimeZoneName.Text = "";
                ComboBoxTimeZOne.Items.Add(name);
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!OpTimeZones)
            {
                OpTimeZones = true;
                var timeZone = (from q in db.GetTable<timezones_t>()
                    orderby q.timezone_start ascending
                    select new
                    {
                        q.timezone_name
                    }).ToList();

                foreach (var t in timeZone)
                {
                    ComboBoxTimeZOne.Items.Add(t.timezone_name);
                }
            }
        }

        private void playstationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPriceListTable();
        }

        private void RefreshPriceListTable()
        {
            var priceList = from p in db.GetTable<playstation_timezone>()
                where p.timezone_name == ComboBoxTimeZOne.Text
                orderby p.playstation_id.Length ascending, p.playstation_id ascending
                select new
                {
                    p.playstation_id,
                    p.timezone_cost_per_hour
                };

            try
            {
                datagridViewPriceList.DataSource = priceList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonChangePrices_Click(object sender, EventArgs e)
        {
            if (datagridViewPriceList.SelectedRows.Count > 0)
            {
                List<string> listToChange = new List<string>();
                for (int i = 0; i < datagridViewPriceList.SelectedRows.Count; i++)
                {
                    listToChange.Add(datagridViewPriceList.SelectedRows[i].Cells[0].Value.ToString());
                }

                ChangeCostForm cc = new ChangeCostForm(listToChange, ComboBoxTimeZOne.Text);
                cc.ShowDialog();
                RefreshPriceListTable();
            }
            else
            {
                MessageBox.Show("Choose at least one playstation");
            }
    }
    }
}