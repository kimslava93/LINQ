using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class AddItemToBar : Form
    {
        private readonly dbDataContext _db;
        public AddItemToBar()
        {
            _db = new dbDataContext();
            InitializeComponent();
        }
        private void AddItemToBar_Load(object sender, EventArgs e)
        {
            UpdateComboBoxCategory();
        }

        private void UpdateComboBoxCategory()
        {
            var category = (from c in _db.GetTable<items_table>()
                select new
                {
                    c.category_name
                }).ToList();
            comboBoxCategory.Items.Clear();
            foreach (var c in category)
            {
                comboBoxCategory.Items.Add(c.category_name);
            }
            if (comboBoxCategory.Items.Count > 0)
            {
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertItemToBar()
        {
            var matchedResults = (from m in _db.GetTable<items_table>()
                where m.item_id == textBoxItemName.Text
                select m).SingleOrDefault();
            if (matchedResults != null)
            {
                MessageBox.Show("The same name was found in the list items! Please choose another one!");
            }
            else
            {
                Table<items_table> itemsTable = _db.GetTable<items_table>();
                items_table itemsT = new items_table();
                itemsT.item_id = textBoxItemName.Text;
                itemsT.cost = (int) numericUpDownCost.Value;
                itemsT.item_description = richTextBoxDescription.Text;
                itemsT.category_name = comboBoxCategory.Text;
                itemsTable.InsertOnSubmit(itemsT);
                try
                {
                    _db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't update database during inserting new item");
                }
            }
            Close();
        }

        private void buttonApplyAndInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxItemName.Text) && numericUpDownCost.Value > 0 && comboBoxCategory.Text.Length > 2)
            {
                if (richTextBoxDescription.Text.Length > 0 && richTextBoxDescription.Text.Length <= 5)
                {
                    DialogResult result = MessageBox.Show("Are you sure that this description will have enough information?", "Warning!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.No)
                    {
                        
                    }
                    else
                    {
                        lock (_db)
                        {
                            InsertItemToBar();
                        }
                    }
                }
                else if (richTextBoxDescription.Text.Length > 5)
                {
                    lock (_db)
                    {
                        InsertItemToBar();
                    }
                }
            }
        }


    }
}
