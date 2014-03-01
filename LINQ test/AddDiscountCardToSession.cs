using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class AddDiscountCardToSession : Form
    {
        private readonly dbDataContext _db;
        public AddDiscountCardToSession(dbDataContext db)
        {
            _db = db;
            InitializeComponent();
        }
        public string Result { get; set; }

        private void GetClientDataAddClientForm()
        {
            var clients = (from clientName in _db.GetTable<client_info_t>()
                from clientSavings in _db.GetTable<account_savings_t>()
                where
                    clientName.client_id == comboBoxDiscountCard.Text &&
                    clientSavings.client_id == comboBoxDiscountCard.Text
                select new
                {
                    clientName.name,
                    clientSavings.savings
                }).ToList();
            if (clients.Count > 0)
            {
                client_name_textBox.Text = clients[0].name;
                clients_money_left_textBox.Text = clients[0].savings.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void UpdateDiscountCardsList()
        {
            var clientsList = (from c in _db.GetTable<client_info_t>()
                orderby c.client_id ascending
                select new
                {
                    c.client_id
                }).ToList();


            comboBoxDiscountCard.DataSource = clientsList;
            comboBoxDiscountCard.DisplayMember = "client_id";
        }

        private void AddDiscountCardToSession_Load(object sender, EventArgs e)
        {
            UpdateDiscountCardsList();
        }

        private void comboBoxDiscountCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GetClientDataAddClientForm();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var matchedResult = (from m in _db.GetTable<client_info_t>()
                where m.client_id == comboBoxDiscountCard.Text
                select m).SingleOrDefault();


            if (matchedResult != null)
            {
                Result = comboBoxDiscountCard.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Such card doesn't exist!");
            }
        }


        private void comboBoxDiscountCard_TextChanged(object sender, EventArgs e)
        {
           
//            var matchedResults = (from m in comboBoxDiscountCard.Items
//                where m == comboBoxDiscountCard.Text
//                select m).SingleOrDefault();
        }
    }
}
