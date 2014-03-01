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
    public partial class AllBarItemsForm : Form
    {
        private readonly dbDataContext _db;

        public AllBarItemsForm(dbDataContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void AllBarItemsForm_Load(object sender, EventArgs e)
        {
            UpdateAllItemsTable();
        }

        private void UpdateAllItemsTable()
        {
            var getAllItems = (from it in _db.GetTable<items_table>()
                select new
                {
                    it.item_id,
                    it.cost
                }).ToList();
            dataGridViewAllItems.DataSource = getAllItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemToBar aitb = new AddItemToBar();
            aitb.ShowDialog();
            UpdateAllItemsTable();
        }

        private void DeleteItemRecord(string itemNameToDelete)
        {
            var matchedResult = (from matched in _db.GetTable<items_table>()
                where matched.item_id == itemNameToDelete
                select matched).SingleOrDefault();
            if (matchedResult != null)
            {
                Table<items_table> itemsTable = _db.GetTable<items_table>();
                itemsTable.DeleteOnSubmit(matchedResult);
                try
                {
                    _db.SubmitChanges();
                    UpdateAllItemsTable();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't delete record from items table!");
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllItems.CurrentRow != null)
            {
                DeleteItemRecord(dataGridViewAllItems.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
