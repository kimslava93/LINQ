using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class ClosingSessionDialog : Form
    {
        private int dailyId;
        private int sessionId;
        private dbDataContext db;
        public ClosingSessionDialog(int dID, int sId)
        {
            db = new dbDataContext();
            dailyId = dID;
            sessionId = sId;
            InitializeComponent();
        }

        private void ClosingSessionDialog_Load(object sender, EventArgs e)
        {
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            labelQuestion.Text = "Why do you want to close session\nbefore time expires?";

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClientGone_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            var selectedSessionId = (from s in db.GetTable<days_sessions_t>()
                                     where s.daily_id == dailyId
                                     where s.session_id == sessionId
                                     select s).SingleOrDefault();
            if (selectedSessionId != null)
            {
                selectedSessionId.end_game = new TimeSpan(currentTime.Hours, currentTime.Minutes, 0);
                double leftMoney = selectedSessionId.payed_sum - selectedSessionId.money_left;
                if (string.IsNullOrEmpty(selectedSessionId.comments))
                {
                    selectedSessionId.comments += "\n";
                }
                selectedSessionId.comments += "Client had gone, before times out! Money left from session " +
                                                  leftMoney;
                selectedSessionId.session_state = "closed";

                var table = (from t in db.GetTable<tables_t>()
                             where t.playstation_id == selectedSessionId.playstation_id
                             select t).SingleOrDefault();
                table.playstation_state = "free";
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't update DataBase during inserting comments! Please contact with Developer. Now will be shown an error!");
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Can't find record with given data!");
            }
            Close();
        }

        private void buttonProblems_Click(object sender, EventArgs e)
        {
            if (this.Height <= 250)
            {
                this.Height = 430;
                buttonClientGone.Enabled = false;
                buttonProblems.Text = "^";
            }
            else
            {
                this.Height = 250;
                buttonClientGone.Enabled = true;
                buttonProblems.Text = "Problems";
            }
        }

        private void buttonSubmitAndClose_Click(object sender, EventArgs e)
        {
            if (richTextBoxComments.Text.Length > 5)
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                var selectedSessionId = (from s in db.GetTable<days_sessions_t>()
                    where s.daily_id == dailyId
                    where s.session_id == sessionId
                    select s).SingleOrDefault();
                if (selectedSessionId != null)
                {
                    selectedSessionId.end_game = new TimeSpan(currentTime.Hours, currentTime.Minutes, 0);
                    double leftMoney = selectedSessionId.payed_sum - selectedSessionId.money_left;
                    if (string.IsNullOrEmpty(selectedSessionId.comments))
                    {
                        selectedSessionId.comments += "\n";
                    }
                    selectedSessionId.comments += "Some problems were founded! Money were returned " +
                                                  leftMoney + "\n" + richTextBoxComments.Text;
                    selectedSessionId.session_state = "closed";

                    var table = (from t in db.GetTable<tables_t>()
                        where t.playstation_id == selectedSessionId.playstation_id
                        select t).SingleOrDefault();
                    if (table != null) 
                        table.playstation_state = "free";
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't update DataBase during inserting comments! Please contact with Developer. Now wil be shown the error");
                        MessageBox.Show(ex.ToString());
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Input full and understandable reason why you switch off console before time expires!");
            }
        }
    }
}
