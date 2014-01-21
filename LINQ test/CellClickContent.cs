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
        }

        private void GetDailySession()
        {
            var q = from days in db.GetTable<days_sessions_t>()
                from account in db.GetTable<session_accounting_t>()
                from discount in db.GetTable<discounts_t>()
                where days.daily_id == int.Parse(dataToWorkWith[0])
//                where account.session_id == days.session_id
                orderby days.client_num ascending
                select new
                {
                    days.client_num,
                    days.playstation_id,
                    days.start_game,
                    days.end_game,
                    days.client_id,
                    
                    discount.discountSize,

                    account.played_money,
                    account.payed_sum
                };
            dataGridViewDaysSession.DataSource = q;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile("add_pressed.png");
            }
            catch (Exception)
            {
                MessageBox.Show("picture of add canot be found!");
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile("add.png");
            }
            catch (Exception)
            {
                MessageBox.Show("picture of add_pressed.png canot be found!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddNewClient anc = new AddNewClient();
            anc.ShowDialog();
        }

        private void buttonCloseSession_Click(object sender, EventArgs e)
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
    }
}
