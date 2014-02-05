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
                orderby d.discount_id descending 
                select new
                {
                    d.discount_id,
                    d.discount_reason,
                    d.startDate,
                    d.endDate,
                    d.discount_playstation_ids,
                    d.discount_timezones,
                    d.discountSize,
                    d.bonus_hours,
                    d.bonus_item,
                    d.discount_auditory,
                    d.number_of_bonus_item,
                    d.number_of_required_items,
                    d.price_discount,
                    d.required_hours_for_bonus,
                    d.required_item_to_buy
                };
            dataGridViewDiscountsTable.DataSource = discounts;
        }       

        private void buttonStopEarlier_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiscountsTable.CurrentRow != null)
            {
                var selected = (from s in db.GetTable<discounts_t>()
                    where s.discount_id == int.Parse(dataGridViewDiscountsTable.CurrentRow.Cells[0].Value.ToString())
                                select s).SingleOrDefault();
                if (selected != null)
                {
                    selected.endDate = DateTime.Now;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            RefreshDiscountsTable();
            
            }
            else
                MessageBox.Show("Select at least one record!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewDiscountForm andf = new AddNewDiscountForm();
            andf.ShowDialog();
            RefreshDiscountsTable();
        }
    }
}
