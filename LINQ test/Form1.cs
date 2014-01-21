using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LINQ_test
{
    public partial class Form1 : Form
    {
        private dbDataContext db;
        private bool _opAdmins = false;
        private bool op_operators = false;

        public Form1()
        {
            
            db = new dbDataContext();
//            Options o = new Options();
//            MessageBox.Show("Price of 1 plst is now " + o.GetCurrentPriceFor("1") +
//                            "\nPrice of 2 plst is now " + o.GetCurrentPriceFor("2") +
//                            "\nPrice of 3 plst is now " + o.GetCurrentPriceFor("3") +
//                            "\nPrice of 4 plst is now " + o.GetCurrentPriceFor("4") +
//                            "\nPrice of 5 plst is now " + o.GetCurrentPriceFor("5") +
//                            "\nPrice of 6 plst is now " + o.GetCurrentPriceFor("6") +
//                            "\nPrice of 7 plst is now " + o.GetCurrentPriceFor("7") +
//                            "\nPrice of 8 plst is now " + o.GetCurrentPriceFor("8") +
//                            "\nPrice of 9 plst is now " + o.GetCurrentPriceFor("9") +
//                            "\nPrice of 11 plst is now " + o.GetCurrentPriceFor("11") +
//                            "\nPrice of VIP2 plst is now " + o.GetCurrentPriceFor("12")
//                );
            InitializeComponent();
            GetMainTable();
        }

        private void GetMainTable()
        {
            var q = from a in db.GetTable<global_session_t>()
                orderby a.daily_id ascending
                select new
                {
                    a.daily_id,
                    a.administrator_id,
                    a.operator_id,
                    a.start_session,
                    a.end_session
                };
            try
            {
                dataGridView1.DataSource = q;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_opAdmins)
            {
                var admin = (from a in db.GetTable<personal_info_t>()
                    where a.position == "administrator"
                    select new
                    {
                        a.name
                    }).ToList();

                _opAdmins = true;
                for (int i = 0; i < admin.Count; i++)
                {
                    admincomboBox1.Items.Add(admin[i].name);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!op_operators)
            {
                op_operators = true;
                var operators = (from o in db.GetTable<personal_info_t>()
                    where o.position == "operator"
                    select new
                    {
                        o.name
                    }).ToList();
                for (int i = 0; i < operators.Count; i++)
                {
                    comboBox2.Items.Add(operators[i].name);
                }
            }
        }

        private void AddNewGlobalSessionButton_Click(object sender, EventArgs e)
        {
            //Get admin
            string adminID = (from a in db.GetTable<personal_info_t>()
                where a.name == admincomboBox1.Text
                select a.person_id).SingleOrDefault<String>();
            //get operator
            string operatorID = (from personal_info in db.GetTable<personal_info_t>()
                where personal_info.name == comboBox2.Text
                select personal_info.person_id).SingleOrDefault<String>();
            if (DoesLastSessionOpened())
            {
                var dateOfOpenedSession = (from cs in db.GetTable<global_session_t>()
                    where cs.end_session == cs.start_session
                    select new
                    {
                        cs.daily_id,
                        cs.start_session
                    }).ToList();
                for (int i = 0; i < dateOfOpenedSession.Count(); i++)
                {
                    MessageBox.Show("Session #" + dateOfOpenedSession[i].daily_id + " and start date " +
                                    dateOfOpenedSession[i].start_session.ToString("yyyy-mm-dd HH:mm") +
                                    " was NOT FINISHED! Please close all sessions before starting new one.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AddNewGlobalSession(adminID, operatorID, dateTimePicker1.Value);
            }
            GetMainTable();
        }

        private bool DoesLastSessionOpened()
        {
            var openedSession = (from cs in db.GetTable<global_session_t>()
                where cs.end_session == cs.start_session
                select cs.daily_id).Any();
            return openedSession;
        }

        private void AddNewGlobalSession(string adminID, string operatorID, DateTime date)
        {
            Table<global_session_t> gst = db.GetTable<global_session_t>();
            global_session_t glob_sess = new global_session_t();
            glob_sess.administrator_id = adminID;
            glob_sess.operator_id = operatorID;
            glob_sess.start_session = date;
            glob_sess.end_session = date;

            gst.InsertOnSubmit(glob_sess);
            db.SubmitChanges();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> data = new List<string>();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.CurrentRow != null)
                    data.Add(dataGridView1.CurrentRow.Cells[i].Value.ToString());
            }
            CellClickContent daysSession = new CellClickContent(data);
            daysSession.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimezoneRedactor tzc = new TimezoneRedactor();
            tzc.ShowDialog();
            GetMainTable();
        }

        
        
    }
}