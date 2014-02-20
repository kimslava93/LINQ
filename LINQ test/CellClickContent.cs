using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.Linq;
using System.Drawing;
//using System.Globalization;
using System.Linq;
//using System.Text;
using System.Threading;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;


namespace LINQ_test
{
    public partial class CellClickContent : Form
    {
        private dbDataContext _db;
        private DateTime _currentTime;
        private readonly int _dailyId;
        private readonly Options _opt;
        private List<DaySessionClass> _daySessionList;
        public CellClickContent(List<string> dataList)
        {
            _dailyId = int.Parse(dataList[0]);
            _opt = new Options();
            InitializeComponent();
        }

        private void CellClickContent_Load(object sender, EventArgs e)
        {
            _currentTime = DateTime.Now;
            _db = new dbDataContext();
            GetDailySession();
            CheckSoonToCloseClients();
            TimeOutChecking();
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void GetDailySession()
        {
            lock (_db)
            {
                _daySessionList = (from days in _db.GetTable<days_sessions_t>()
                    where days.daily_id == _dailyId
                    where days.session_state == "opened"
                    orderby days.money_left ascending
                    select new DaySessionClass
                    {
                        SessionId = days.session_id,
                        PlaystationId = days.playstation_id,
                        StartGame = (TimeSpan) days.start_game,
                        EndGame = (TimeSpan) days.end_game,
                        ClientId = days.client_id,

                        MoneyLeft = days.money_left,
                        SessionDiscount = (double) days.session_discount,
                        PayedSum = days.payed_sum
                    }).ToList<DaySessionClass>();
                dataGridViewDaysSession.Invoke(new Action(() => dataGridViewDaysSession.DataSource = _daySessionList));
            }
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            _currentTime = DateTime.Now;
            labelCurrentTime.Text = _currentTime.ToString("HH:mm:ss");
            
            CheckSoonToCloseClients();
            Thread check = new Thread(TimeOutChecking);
            check.Start();
        }


        private void TimeOutChecking()
        {
            _currentTime = DateTime.Now;
            if (_daySessionList.Count <= 0) return;
            foreach (DaySessionClass os in _daySessionList)
            {
                os.MoneyLeft = Math.Round(_opt.GetAlreadyPlayedMoneySum(os.PlaystationId, os.StartGame, os.PayedSum), 2);
            }
            dataGridViewDaysSession.Invalidate();
        }

        private void CheckSoonToCloseClients()
        {
            foreach (DaySessionClass os in _daySessionList)
            {
//                var end = new DateTime(curTimeToFindDifference.Year, curTimeToFindDifference.Month,
//                    curTimeToFindDifference.Day, os.EndGame.Hours,
//                    os.EndGame.Minutes, os.EndGame.Seconds);
//                if (curTimeToFindDifference.Hour == end.Hour)
//                {
//                    if (end.Subtract(curTimeToFindDifference) > TimeSpan.FromMinutes(5))
//                    {
//                        continue;
//                    }
//                    else if (end.Subtract(curTimeToFindDifference) <= TimeSpan.FromMinutes(5) &&
//                             end.Subtract(curTimeToFindDifference) > TimeSpan.FromMinutes(1))
//                    {
//                        //Highlights rows
//                    }
//                    else if (end.Subtract(curTimeToFindDifference) <= TimeSpan.FromMinutes(1) &&
//                             end.Subtract(curTimeToFindDifference) > TimeSpan.FromMinutes(0))
//                    {
//                        //SHOW ALERT WINDOW
//                    }
//                    else if (end.Subtract(curTimeToFindDifference) <= TimeSpan.FromMinutes(0))
//                    {
//                        _opt.TimeOutClosePlaystation(_dailyId, os);
//                        SyncDbContextAndDaySessionList();
//                    }
//                }
//                double moneyLeft = os.PayedSum - os.MoneyLeft;
                if (os.MoneyLeft > 5)
                {
//                    continue;
                }
                else if (os.MoneyLeft > 3 && os.MoneyLeft < 6)
                {
                    HighLight(os.SessionId, 0);
                    //warning highlight
                }
                else if (os.MoneyLeft > 0 && os.MoneyLeft <= 3)
                {
                    HighLight(os.SessionId, 1);
                }
                else if (os.MoneyLeft <= 0)
                {
                    _opt.TimeOutClosePlaystation(_dailyId, os);
                    GetDailySession();
                    SyncDbContextAndDaySessionList();
                }
                dataGridViewDaysSession.Invalidate();
            }
        }

        private void HighLight(int sessionID, int level)//0 - orange 5 minutes left OR if 1 or another - RED color 1 minute left
        {
            for (int i = 0; i < _daySessionList.Count; i++)
            {
                if (!dataGridViewDaysSession.Rows[i].Cells[0].Value.Equals(sessionID)) continue;
                if (level == 0)
                {
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.BackColor = Color.DarkOrange;
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Ivory;
                    
                }
                else
                {
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.BackColor = Color.Crimson;
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Crimson;
                    dataGridViewDaysSession.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Cyan;
                }
            }
        }

        private void SyncDbContextAndDaySessionList()
        {
            lock (_db)
            {
                foreach (var ds in _daySessionList)
                {
                    var updateRecord = (from u in _db.GetTable<days_sessions_t>()
                        where u.session_id == ds.SessionId
                        select u).SingleOrDefault();
                    if (updateRecord != null)
                        updateRecord.money_left = ds.MoneyLeft;
                }
                try
                {
                    _db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This is in Sync method!");
                    MessageBox.Show(ex.Message);
                }
                GetDailySession();
                dataGridViewDaysSession.Invalidate();
            }
        }

//        private void SyncPlayedTimeWithDb(List<object> openedSessions)
//        {
//            for (int i = 0; i < openedSessions.Count; i++)
//            {
//                var updateOpenedSessions = from os in db.GetTable<days_sessions_t>()
//                                           where os.daily_id == dailyID
//
//            }
//        }

        private void pictureBoxStop_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewDaysSession.CurrentRow != null)
            {
                int selectedSessionId = (int)dataGridViewDaysSession.CurrentRow.Cells[0].Value;
                var csd = new ClosingSessionDialog(_dailyId, selectedSessionId);
                csd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, select row that you would like to close, before it will be closed by timer");
            }
            GetDailySession();
        }

        private void pictureBoxStop_MouseDown_1(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxStop.Image = Image.FromFile("stop_pressed.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Picture of stop_pressed button not found!");
            }
        }

        private void pictureBoxStop_MouseUp_1(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxStop.Image = Image.FromFile("stop.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Picture of stop button not found!");
            }
            
        }

        private void pictureBoxCloseSession_MouseClick(object sender, EventArgs e)
        {
            var openedSessions = (from os in _db.GetTable<days_sessions_t>()
                                 where os.session_state == "opened"
                                 select os).ToList();

            var lastOpenedSession = (from s in _db.GetTable<global_session_t>()
                                     where s.start_session == s.end_session
                                     select s).SingleOrDefault();
            if (lastOpenedSession != null)
            {
                lastOpenedSession.end_session = DateTime.Now;
                try
                {
                    _db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Close();
        }

        private void pictureBoxCloseSession_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxCloseSession.Image = Image.FromFile("close.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't find image \"close_pressed.png\"! ");
            }
        }

        private void pictureBoxCloseSession_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxCloseSession.Image = Image.FromFile("close_pressed.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't find image \"close_pressed.png\"! ");
            }
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            AddNewClient anc = new AddNewClient(_dailyId);
            anc.ShowDialog();
            SyncDbContextAndDaySessionList();
//            GetDailySession();
        }

        private void pictureBoxAdd_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxAdd.BackgroundImage = Image.FromFile("add.png");
            }
            catch (Exception)
            {
                MessageBox.Show("picture of add_pressed.png canot be found!");
            }
        }

        private void pictureBoxAdd_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBoxAdd.BackgroundImage = Image.FromFile("add_pressed.png");
            }
            catch (Exception)
            {
                MessageBox.Show("picture of add canot be found!");
            }
        }
    }
}
