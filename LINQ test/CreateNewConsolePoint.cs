using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class CreateNewConsolePoint : Form
    {
        private List<TimezonesMyClass> _timezoneList;
        private List<TimezonePricesMyClass> _timezonePrices;
        private List<TablesMyClass> _consolesList;
        private dbDataContext _db;
        public CreateNewConsolePoint()
        {
            InitializeComponent();
        }

        private void CreateNewConsolePoint_Load(object sender, EventArgs e)
        {
            _db = new dbDataContext();
            UpdateListBoxOfTimezones();
        }

        private void UpdateListBoxOfTimezones()
        {
            _timezoneList = (from t in _db.GetTable<timezones_t>()
                select new TimezonesMyClass
                {
                    TimezoneName = t.timezone_name,
                    TimezoneStart = t.timezone_start,
                    TimezoneEnd = t.timezone_end
                }).ToList<TimezonesMyClass>();
            
            List<MyString> timezonNames = _timezoneList.Select(t => new MyString(t.TimezoneName)).ToList();

            dataGridView1.DataSource = timezonNames;
            _timezonePrices = (from p in _db.GetTable<playstation_timezone>()
                select new TimezonePricesMyClass
                {
                    PlaystationId = p.playstation_id,
                    TimezoneName = p.timezone_name,
                    TimezoneCostPerHour = (double) p.timezone_cost_per_hour,
                    TimezoneID = p.playstation_timezone_id
                }).ToList<TimezonePricesMyClass>();

            _consolesList = (from c in _db.GetTable<tables_t>()
                select new TablesMyClass
                {
                    PlaystationId = c.playstation_id,
                    CurrentState = c.playstation_state,
                    OrderTime = (DateTime) c.order_time
                }).ToList<TablesMyClass>();

            dataGridView1.Invalidate();
        }

        private void buttonCreateNewConsolePoint_Click(object sender, EventArgs e)
        {
            if (DoAllPricesAreSet())
            {
                foreach (var tp in _timezonePrices.Where(tp => tp.PlaystationId.Equals(textBoxNameOfNewConsole.Text)))
                {
                    var updateRecords = (from r in _db.GetTable<playstation_timezone>()
                        where r.playstation_id.Equals(tp.PlaystationId)
                        where r.timezone_name.Equals(tp.TimezoneName)
                        select r).SingleOrDefault();
                    if (updateRecords != null)
                    {
                        updateRecords.timezone_cost_per_hour = tp.TimezoneCostPerHour;
                        int times = 5;
                        while (true)
                        {
                            try
                            {
                                --times;
                                _db.SubmitChanges();
                                Close();
                                break;
                            }
                            catch (Exception)
                            {
                                if (times <= 0)
                                {
                                    MessageBox.Show("Can't update cost of playstaytion!");
                                }
                            }
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Please set prices for all timezones!");
            }
        }
        private bool DoAllPricesAreSet()
        {
            foreach(TimezonePricesMyClass t in _timezonePrices)
            {
                if (t.PlaystationId.Equals(textBoxNameOfNewConsole.Text) &&
                    t.TimezoneCostPerHour <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonCreateConsoleName_Click(object sender, EventArgs e)
        {
            bool repeat = false;
            if (!String.IsNullOrEmpty(textBoxNameOfNewConsole.Text))
            {
                foreach (TablesMyClass console in _consolesList)
                {
                    if (console.PlaystationId.Equals(textBoxNameOfNewConsole.Text))
                    {
                        repeat = true;
                        MessageBox.Show("This name is unavailable, because it already exists!/nPlease choose another one.");
                    }
                }
                if (!repeat)
                {
                    int times = 5;
                    while (true)
                    {
                        try
                        {
                            Table<tables_t> consolesT = _db.GetTable<tables_t>();
                            tables_t console = new tables_t
                            {
                                playstation_id = textBoxNameOfNewConsole.Text,
                                playstation_state = "free",
                                order_time = new DateTime(2000, 1, 1, 0, 0, 0)
                            };

                            consolesT.InsertOnSubmit(console);
                            foreach (TimezonesMyClass t in _timezoneList)
                            {
                                Table<playstation_timezone> playstationPricesT = _db.GetTable<playstation_timezone>();
                                playstation_timezone timezonePrice = new playstation_timezone
                                {
                                    playstation_id = textBoxNameOfNewConsole.Text,
                                    timezone_cost_per_hour = 0,
                                    timezone_name = t.TimezoneName
                                };

                                playstationPricesT.InsertOnSubmit(timezonePrice);
                            }
                            _db.SubmitChanges();

                            Height = 330;
                            textBoxNameOfNewConsole.Enabled = false;
                            buttonCreateConsoleName.Enabled = false;
                            break;
                        }
                        catch (Exception)
                        {
                            --times;
                            if (times <= 0)
                            {
                                MessageBox.Show("Can't create console!", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                UpdateListBoxOfTimezones();
                CheckListOfTimezonesOnFilledPrices();
            }
            else
            {
                MessageBox.Show("Enter name of new console point!");
            }
            
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            foreach (TimezonePricesMyClass t in _timezonePrices)
            {
                if (dataGridView1.CurrentRow != null &&
                    textBoxNameOfNewConsole.Text.Equals(t.PlaystationId) &&
                    dataGridView1.CurrentRow.Cells[0].Value.Equals(t.TimezoneName))
                {
                    t.TimezoneCostPerHour = (double) numericUpDownPrice.Value;
                    dataGridView1.Invalidate();
                }
            }
            CheckListOfTimezonesOnFilledPrices();
        }

        private void CheckListOfTimezonesOnFilledPrices()
        {
            foreach (TimezonePricesMyClass t in _timezonePrices)
            {
                if (textBoxNameOfNewConsole.Text.Equals(t.PlaystationId))
                {
                    if (t.TimezoneCostPerHour <= 0)
                    {
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (dataGridView1.Rows[j].Cells[0].Value.Equals(t.TimezoneName))
                            {
                                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.Crimson;
                                dataGridView1.Rows[j].DefaultCellStyle.SelectionBackColor = Color.Transparent;
                                dataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.White;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((string)dataGridView1.Rows[j].Cells[0].Value == t.TimezoneName)
                            {
                                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.GreenYellow;
                                dataGridView1.Rows[j].DefaultCellStyle.SelectionBackColor = Color.Transparent;
                                dataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkBlue;
                            }
                        }
                    }
                    dataGridView1.Invalidate();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (TimezonePricesMyClass tp in _timezonePrices)
            {
                if (textBoxNameOfNewConsole.Text.Equals(tp.PlaystationId))
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        if (dataGridView1.CurrentRow.Cells[0].Value.Equals(tp.TimezoneName))
                        {
                            numericUpDownPrice.Value = (decimal)tp.TimezoneCostPerHour;
                        }
                    }
                }
            }
        }
    }
}
