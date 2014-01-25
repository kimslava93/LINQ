using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class DiscountRedactor : Form
    {
        private dbDataContext db;
        public DiscountRedactor()
        {
            db = new dbDataContext();
            InitializeComponent();
        }

        private void DiscountRedactor_Load(object sender, EventArgs e)
        {
            RefreshDiscountsTable();
            UpdateAddDiscountForm();
        }

        private void UpdateAddDiscountForm()
        {
            textBoxDiscountName.Text = "";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            textBoxPlaystations.Text = "";
            numericUpDownDiscountSize.Value = 0;
            checkedListBoxTimeZones.Items.Clear();
            var timeZones = (from t in db.GetTable<timezones_t>()
                select new
                {
                    t.timezone_name,
                    t.timezone_start,
                    t.timezone_end
                }).ToList();

            for (int i = 0; i < timeZones.Count; i++)
            {
                checkedListBoxTimeZones.Items.Add(timeZones[i].timezone_name + "(" + timeZones[i].timezone_start + "-" +timeZones[i].timezone_end + ")");
            }
            
        }

        private void RefreshDiscountsTable()
        {
            var discounts = from d in db.GetTable<discounts_t>()
                orderby d.discount_id descending 
                select new
                {
                    d.discount_id,
                    d.discount_reason,
                    d.startDate,
                    d.endDate,
                    d.discount_playstation_ids,
                    d.discount_timezones,
                    d.discountSize
                };
            dataGridViewDiscountsTable.DataSource = discounts;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddRemoveFromDiscountForm arfdf = new AddRemoveFromDiscountForm(textBoxPlaystations.Text);
            arfdf.ShowDialog();
            textBoxPlaystations.Text = arfdf.Result;
        }

        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(dateTimePickerStartDate.Value.ToString("yyyy.MMMM.dd") + " " + dateTimePickerStartTime.Value.ToString("HH:mm"));
            DateTime end = DateTime.Parse(dateTimePickerEndDate.Value.ToString("yyyy.MMMM.dd") + " "+ dateTimePickerEndTime.Value.ToString("HH:mm"));
            MessageBox.Show(start.ToString());
            MessageBox.Show(end.ToString());
            string name = textBoxDiscountName.Text;
            string playstations = textBoxPlaystations.Text;
            double discountSize = (double) numericUpDownDiscountSize.Value;
            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(playstations) &&
                checkedListBoxTimeZones.SelectedItem != null &&
                start < end)
            {
                Table<discounts_t> discountsT = db.GetTable<discounts_t>();
                discounts_t disc = new discounts_t();
                disc.discount_reason = name;
                disc.startDate = start;
                disc.endDate = end;
                disc.discount_playstation_ids = textBoxPlaystations.Text;
                disc.discount_timezones = TimeZonesMerger();
                disc.discountSize = discountSize;
                try
                {
                    discountsT.InsertOnSubmit(disc);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                RefreshDiscountsTable();
                UpdateAddDiscountForm();
            }

        }

        private string TimeZonesMerger()
        {
            string result = "";
            foreach (Object t in checkedListBoxTimeZones.Items)
            {
                result += t;
                if (checkedListBoxTimeZones.Items.IndexOf(t) != checkedListBoxTimeZones.Items.Count)
                {
                    result += "; ";
                }
            }
            return result;
        }

        private void buttonStopEarlier_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiscountsTable.CurrentRow != null)
            {
                var selected = (from s in db.GetTable<discounts_t>()
                    where s.discount_id == int.Parse(dataGridViewDiscountsTable.CurrentRow.Cells[0].Value.ToString())
                                select s).SingleOrDefault();
                if (selected != null)
                {
                    selected.endDate = DateTime.Now;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            RefreshDiscountsTable();
            
            }
            else
                MessageBox.Show("Select at least one record!");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonPercentage_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPercentage.Enabled = true;
            groupBoxPercentage.Visible = true;

            groupBoxBonus.Enabled = false;
            groupBoxBonus.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPercentage.Enabled = false;
            groupBoxPercentage.Visible = false;

            groupBoxBonus.Enabled = true;
            groupBoxBonus.Visible = true;

            groupBoxBonus.Location = new Point(groupBoxPercentage.Location.X, 
                                               groupBoxBonus.Location.Y);

        }

        private void radioButtonHours_CheckedChanged(object sender, EventArgs e)
        {
            labelRequiredItem.Visible = false;
            comboBoxRequiredItem.Visible = false;
            numericUpDownRequiredMinutes.Visible = true;
            numericUpDownBonusMinutes.Visible = true;
        }

        private void radioButtonItem_CheckedChanged(object sender, EventArgs e)
        {
            labelRequiredItem.Visible = true;
            comboBoxRequiredItem.Visible = true;
            numericUpDownRequiredMinutes.Visible = false;
            numericUpDownBonusMinutes.Visible = false;
        }
    }
}
