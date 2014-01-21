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
    public partial class ChangeCostForm : Form
    {
        private dbDataContext db;
        private string timeZoneToFind;
        private List<string> playstationsToChange;

        public ChangeCostForm(List<string> tablesToChange, string timeZone)
        {
            timeZoneToFind = timeZone;
            db = new dbDataContext();
            playstationsToChange = tablesToChange;
            InitializeComponent();
        }

        private void ChangeCostForm_Load(object sender, EventArgs e)
        {
            textBoxPlaystationsList.Text += "\n";
            int lengthCounter = 0;
            for (int i = playstationsToChange.Count - 1; i >= 0; i--)
            {
                textBoxPlaystationsList.Text += playstationsToChange[i];
                if (i > 0)
                {
                    textBoxPlaystationsList.Text += ", ";
                }
                lengthCounter += (playstationsToChange[i] + ", ").Length;
                if (lengthCounter/50 > 0)
                {
                    textBoxPlaystationsList.Text += "\n";
                    lengthCounter = 0;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Table<playstation_timezone> timeZoneTable = db.GetTable<playstation_timezone>();
            playstation_timezone playstationTimezone = new playstation_timezone();

            for (int i = 0; i < playstationsToChange.Count; i++)
            {
                timeZoneTable = db.GetTable<playstation_timezone>();
                playstationTimezone = new playstation_timezone();

                var matchedRecord = (from price in timeZoneTable
                    where price.playstation_id == playstationsToChange[i]
                    where price.timezone_name == timeZoneToFind
                    select price).SingleOrDefault();
                if (matchedRecord != null)
                {
                    try
                    {
                        matchedRecord.timezone_cost_per_hour = (int) numericUpDownPrice.Value;
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            Close();
        }
    }
}
