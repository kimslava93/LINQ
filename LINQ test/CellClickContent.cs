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
    public partial class CellClickContent : Form
    {
        private dbDataContext db;
        private List<string> dataToWorkWith;

        public CellClickContent(List<string> dataList)
        {
            dataToWorkWith = dataList;
            InitializeComponent();
        }

        private void CellClickContent_Load(object sender, EventArgs e)
        {
            db = new dbDataContext();
            GetDailySession();
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void GetDailySession()
        {
            var lastDailyId = (from di in db.GetTable<global_session_t>()
                orderby di.daily_id descending
                select di.daily_id).FirstOrDefault();
            var tables = (from t in db.GetTable<tables_t>()
                select new
                {
                    t.playstation_id,
                    t.playstation_state
                }).ToList();
            var q = from days in db.GetTable<days_sessions_t>()
                where days.daily_id == lastDailyId
                orderby days.client_num ascending
                select new
                {
                    days.client_num,
                    days.playstation_id,
                    days.start_game,
                    days.end_game,
                    days.client_id,

                    days.played_money,
                    days.session_discount,
                    days.payed_sum
                };
            dataGridViewDaysSession.DataSource = q;
            TimeSpan curTime = DateTime.Now.TimeOfDay;
            for (int i = 0; i < dataGridViewDaysSession.RowCount; i++)
            {
                for (int j = 0; j < tables.Count(); j++)
                {
                    if (dataGridViewDaysSession.Rows[i].Cells[1].Value.ToString() == tables[j].playstation_id)
                    {
                        if (tables[j].playstation_state == "busy" && 
                            (TimeSpan)dataGridViewDaysSession.Rows[i].Cells[3].Value > curTime)
                        {
                            dataGridViewDaysSession.Rows[i].DefaultCellStyle.BackColor = Color.Chartreuse;
                        }
                    }
                }
                
                
            }
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.Second == 0)
            {
                for (int i = 0; i < dataGridViewDaysSession.RowCount; i++)
                {
//                    if (dataGridViewDaysSession.Rows[i].Cells[]) ;
                }
            }
        }

        private void pictureBoxStop_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewDaysSession.CurrentRow != null)
            {
                int selectedClientNum = (int)dataGridViewDaysSession.CurrentRow.Cells[0].Value;
                var dailyId = (from di in db.GetTable<global_session_t>()
                               orderby di.daily_id descending
                               select di.daily_id).FirstOrDefault();
                ClosingSessionDialog csd = new ClosingSessionDialog(dailyId, selectedClientNum);
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
            var LastOpenedSession = (from s in db.GetTable<global_session_t>()
                                     where s.start_session == s.end_session
                                     select s).SingleOrDefault();
            if (LastOpenedSession != null)
            {
                LastOpenedSession.end_session = DateTime.Now;
                try
                {
                    db.SubmitChanges();
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
            AddNewClient anc = new AddNewClient(int.Parse(dataToWorkWith[0]));
            anc.ShowDialog();
            GetDailySession();
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
