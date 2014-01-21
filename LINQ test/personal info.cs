using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class personal_info : Form
    {
        private PersonalInfoClass pers;

        public personal_info()
        {
            InitializeComponent();
            pers = new PersonalInfoClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//              pers.AddNewPerson(personIdTextBox.Text, nameTextBox2.Text, loginTextBox3.Text,
//                passwordTextBox4.Text, positionTextBox5.Text, phoneTextBox6.Text,
//                additionalPhoneTextBox7.Text, birthdayDateTimePicker1.Value, homeAddressTextBox9.Text,
//                int.Parse(salaryTextBox10.Text));
            
            var db = new dbDataContext();
            Table<personal_info_t> t = db.GetTable<personal_info_t>();
            
            var id = (from a in db.GetTable<personal_info_t>()
                orderby a.person_id ascending
                //select a.person_id).First();
                select new {a.person_id});
            dataGridView1.DataSource = id; //pers.GetAllPersonalInfos();
        }
    }
}