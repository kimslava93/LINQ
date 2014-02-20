using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Synchronization.Data;

namespace LINQ_test
{
    public partial class TablesManager : Form
    {
        private readonly dbDataContext _db;
        private IList<TablesMyClass> _tablesList;
        private readonly List<MyString> _tableNamesForDataGridView; 
        public TablesManager()
        {
            InitializeComponent();
            _db = new dbDataContext();
            _tablesList = new List<TablesMyClass>();
            _tableNamesForDataGridView = new List<MyString>();
        }

        private void TablesManager_Load(object sender, EventArgs e)
        {

            UpdateConsolesList();
            if (dataGridViewConsolesList.CurrentRow != null)
            {
                ShowInfo();
            }
            else
            {
                DefaultValues();
            }
        }

        private void DefaultValues()
        {
            textBoxName.Text = "0";
            comboBoxState.SelectedItem = "unknown";
            dateTimePickerOrder.Value = dateTimePickerOrder.MinDate;
        }

        private void UpdateConsolesList()
        {
            _tablesList = (from c in _db.GetTable<tables_t>()
                orderby c.playstation_id.Length, c.playstation_id
                select new TablesMyClass
                {
                    PlaystationId = c.playstation_id,
                    CurrentState = c.playstation_state,
                    OrderTime = (DateTime) c.order_time
                }).ToList<TablesMyClass>();

            _tableNamesForDataGridView.Clear();

            foreach (var tc in _tablesList)
            {
                _tableNamesForDataGridView.Add(new MyString(tc.PlaystationId));
            }
            dataGridViewConsolesList.DataSource = _tableNamesForDataGridView;
        }

        private void UpdateConsolePriceListInfo(string consoleId)
        {
            if (!String.IsNullOrEmpty(consoleId))
            {
                var priceList = (from p in _db.GetTable<playstation_timezone>()
                    where p.playstation_id == consoleId
                    select new
                    {
                        p.timezone_name,
                        p.timezone_cost_per_hour
                    }).ToList();
                dataGridViewPriceList.DataSource = priceList;
            }
        }

        private void dataGridViewConsolesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridViewConsolesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            if (dataGridViewConsolesList.CurrentRow != null)
            {
                string id = dataGridViewConsolesList.CurrentRow.Cells[0].Value.ToString();
                UpdateConsolePriceListInfo(id);
                textBoxName.Text = id;
                comboBoxState.SelectedItem = _tablesList.Where(p => p.PlaystationId == id).Select(p => p.CurrentState).SingleOrDefault(); 

                dateTimePickerOrder.Value = _tablesList.Where(p => p.PlaystationId == id).Select(p => p.OrderTime).SingleOrDefault();
                if (comboBoxState.Text == "free")
                {
                    comboBoxState.BackColor = Color.Chartreuse;
                }
                else
                {
                    comboBoxState.BackColor = Color.Crimson;
                }
            }
        }

        private void buttonCreateNewConsole_Click(object sender, EventArgs e)
        {
            CreateNewConsolePoint cncp = new CreateNewConsolePoint();
            cncp.ShowDialog();
            dataGridViewConsolesList.DataSource = null;
            dataGridViewConsolesList.Rows.Clear();
            UpdateConsolesList();
            dataGridViewConsolesList.Invalidate();
        }

        private void buttonDeleteConsole_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsolesList.CurrentRow != null)
            {
                string selectedTable = (string)dataGridViewConsolesList.CurrentRow.Cells[0].Value;
                var tableToDelete = (from t in _db.GetTable<tables_t>()
                    where t.playstation_id.Equals(selectedTable)
                    select t).SingleOrDefault();
                var deleteTimezonePrices = (from tp in _db.GetTable<playstation_timezone>()
                    where tp.playstation_id.Equals(selectedTable)
                    select tp);
                if (tableToDelete != null && deleteTimezonePrices != null)
                {
                    int times = 5;
                    while (true)
                    {
                        try
                        {
                            --times;
                            foreach (var deleteTimezonePrice in deleteTimezonePrices)
                            {
                                _db.playstation_timezones.DeleteOnSubmit(deleteTimezonePrice);
                            }
                            _db.tables_ts.DeleteOnSubmit(tableToDelete);
                            _db.SubmitChanges();
                            
                            UpdateConsolePriceListInfo("0");
                            dataGridViewPriceList.DataSource = null;
                            dataGridViewPriceList.Rows.Clear();
                            dataGridViewConsolesList.DataSource = null;
                            dataGridViewConsolesList.Rows.Clear();
                            UpdateConsolesList();
                            
//                            dataGridViewConsolesList.Invalidate();
                            break;
                        }
                        catch (Exception)
                        {
                            if (times <= 0)
                            {
                                MessageBox.Show("Can't delete playstaytion! try again");
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
