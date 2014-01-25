using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class AddRemoveFromDiscountForm : Form
    {
        private dbDataContext db;
        private string ifAlreadyChanged;
        public AddRemoveFromDiscountForm(string ifExist)
        {
            ifAlreadyChanged = ifExist;
            db = new dbDataContext();
            InitializeComponent();
        }

        private void AddRemoveFromDiscountForm_Load(object sender, EventArgs e)
        {
            var plst = (from p in db.GetTable<tables_t>()
                orderby p.playstation_id.Length, p.playstation_id
                select new
                {
                    p.playstation_id
                
                }).ToList();

            for (int i = 0; i < plst.Count(); i++)
            {
                listBoxSupposeItems.Items.Add(plst[i].playstation_id);
            }
            if (!string.IsNullOrEmpty(ifAlreadyChanged))
            {
                List<string> toDelete = PlaystationSplitter();
                foreach (string s in toDelete)
                {
                    listBoxItemsToAdd.Items.Add(s);
                }
                foreach (string s in toDelete)
                {
                    listBoxSupposeItems.Items.Remove(s);
                }
            }
        }

        private List<string> PlaystationSplitter()
        {
//            List<string> result = new List<string>();
            string[] temp = Regex.Split(ifAlreadyChanged, "; ");
            return temp.ToList();
        }

        private void buttonAddOneRecord_Click(object sender, EventArgs e)
        {
            if (listBoxSupposeItems.SelectedItem != null)
            {
                List<string> toDelete = listBoxSupposeItems.SelectedItems.Cast<string>().ToList();
                foreach (Object s in listBoxSupposeItems.SelectedItems)
                {
                    listBoxItemsToAdd.Items.Add(s);
                }
                foreach (string t in toDelete)
                {
                    listBoxSupposeItems.Items.Remove(t);
                }
            }
            else MessageBox.Show("Select at least one record!");
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach (Object c in listBoxSupposeItems.Items)
            {
                listBoxItemsToAdd.Items.Add(c);
            }
            listBoxSupposeItems.Items.Clear();
        }

        private void buttonRemoveOne_Click(object sender, EventArgs e)
        {
            if (listBoxItemsToAdd.SelectedItem != null)
            {
                List<string> toDelete = listBoxItemsToAdd.SelectedItems.Cast<string>().ToList();
                foreach (string s in toDelete)
                {
                    listBoxSupposeItems.Items.Add(s);
                }
                foreach (string s in toDelete)
                {
                    listBoxItemsToAdd.Items.Remove(s);
                }
            }
            else MessageBox.Show("Select at least one record!");
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (Object c in listBoxItemsToAdd.Items)
            {
                listBoxSupposeItems.Items.Add(c);
            }
            listBoxItemsToAdd.Items.Clear();

        }

        public string Result{get;set;}

        private void buttonApply_Click(object sender, EventArgs e)
        {
            foreach (Object c in listBoxItemsToAdd.Items)
            {
                Result += c;
                if (listBoxItemsToAdd.Items.IndexOf(c) != listBoxItemsToAdd.Items.Count-1)
                {
                    Result += "; ";
                }
            }
            Close();
        }
    }
}
