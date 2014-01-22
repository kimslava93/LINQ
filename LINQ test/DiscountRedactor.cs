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
    public partial class DiscountRedactor : Form
    {
        private dbDataContext db;
        public DiscountRedactor()
        {
            db = new dbDataContext();
            InitializeComponent();
        }

        private void DiscountRedactor_Load(object sender, EventArgs e)
        {
            RefreshDiscountsTable();
        }

        private void RefreshDiscountsTable()
        {
            var discounts = from d in db.GetTable<discounts_t>()
                orderby d.endDate ascending
                select d;
            dataGridView1.DataSource = discounts;
        }
    }
}
