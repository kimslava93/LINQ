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
    public partial class AddNewDiscountForm : Form
    {
        private dbDataContext db;
        public AddNewDiscountForm()
        {
            db = new dbDataContext();
            InitializeComponent();
        }
        private void AddNewDiscountForm_Load(object sender, EventArgs e)
        {
            UpdateAddDiscountForm();
        }

        private void UpdateAddDiscountForm()
        {
            textBoxDiscountName.Text = "";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            textBoxPlaystations.Text = "";
            numericUpDownDiscountSize.Value = 0;
            checkedListBoxTimeZones.Items.Clear();
            var timeZones = (from t in db.GetTable<timezones_t>()
                             select new
                             {
                                 t.timezone_name,
                                 t.timezone_start,
                                 t.timezone_end
                             }).ToList();

            for (int i = 0; i < timeZones.Count; i++)
            {
                checkedListBoxTimeZones.Items.Add(timeZones[i].timezone_name + "(" + timeZones[i].timezone_start + "-" + timeZones[i].timezone_end + ")");
            }

        }

        private bool TypeOfBonusSelected()
        {
            if(radioButtonPercentage.Checked || radioButtonBonusType.Checked)
                return true;
            return false;
        }

        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(dateTimePickerStartDate.Value.ToString("yyyy.MMMM.dd") + " " + dateTimePickerStartTime.Value.ToString("HH:mm"));
            DateTime end = DateTime.Parse(dateTimePickerEndDate.Value.ToString("yyyy.MMMM.dd") + " " + dateTimePickerEndTime.Value.ToString("HH:mm"));
            string auditory = comboBoxAuditory.Text;
            MessageBox.Show(start.ToString());
            MessageBox.Show(end.ToString());
            string name = textBoxDiscountName.Text;
            string playstations = textBoxPlaystations.Text;
            double discountSize = (double)numericUpDownDiscountSize.Value;

            if (!string.IsNullOrEmpty(name) &&
                checkedListBoxTimeZones.SelectedItem != null &&
                start < end &&
                !string.IsNullOrEmpty(auditory) &&
                TypeOfBonusSelected())
            {
                Table<discounts_t> discountsT = db.GetTable<discounts_t>();
                discounts_t disc = new discounts_t();
                disc.discount_reason = name;
                disc.startDate = start;
                disc.endDate = end;
                disc.discount_playstation_ids = textBoxPlaystations.Text;
                disc.discount_auditory = auditory;
                disc.discount_timezones = TimeZonesMerger();
                if (radioButtonBonusType.Checked)
                {
                    if (checkBoxRequiredHours.Checked)
                    {
                        TimeSpan RequiredTimeToBuy = new TimeSpan(0,int.Parse(numericUpDownRequiredPaidHours.Text), int.Parse(numericUpDownRequiredPaidMinutes.Text), 0);
                        
                        disc.required_hours_for_bonus = RequiredTimeToBuy;
                    }
                    else
                    {
                        disc.required_hours_for_bonus = new TimeSpan(0,0,0,0,0);
                    }


                    if (checkBoxRequiredItem.Checked)
                    {
                        disc.required_item_to_buy = comboBoxRequiredItem.Text;
                        disc.number_of_required_items = int.Parse(numericUpDownRequiredNumberOfItem.Text);
                    }
                    else
                    {
                        disc.required_item_to_buy = "";
                        disc.number_of_required_items = 0;
                    }


                    if (checkBoxBonusHours.Checked)
                    {
                        TimeSpan BonusTime = TimeSpan.Parse(numericUpDownBonusHours.Text + ":" + numericUpDownBonusMinutes.Text);
                        disc.bonus_hours = BonusTime;
                    }
                    else
                    {
                        disc.bonus_hours = new TimeSpan(0, 0, 0, 0, 0);
                    }

                    if (checkBoxBonusItem.Checked)
                    {
                        disc.bonus_item = comboBoxBonusItem.Text;
                        disc.number_of_bonus_item = int.Parse(numericUpDownNumberOfBonusItem.Text);
                    }
                    else
                    {
                        disc.bonus_item = "";
                        disc.number_of_bonus_item = 0;
                    }

                    if (checkBoxPriceDiscount.Checked)
                    {
                        disc.price_discount = double.Parse(numericUpDownPriceDiscount.Text);
                    }
                    else
                    {
                        disc.price_discount = 0.00;
                    }
                    disc.discountSize = 0;
                }
                else if (radioButtonPercentage.Checked)
                {
                    disc.discountSize = (float)discountSize;

                    disc.bonus_hours = new TimeSpan(0,0,0,0,0);
                    disc.bonus_item = "";
                    disc.number_of_bonus_item = 0;
                    disc.number_of_required_items = 0;
                    disc.price_discount = 0;
                    disc.required_hours_for_bonus = new TimeSpan(0,0,0,0,0);
                    disc.required_item_to_buy = "";
                }
                else
                {
                    MessageBox.Show("Please select one of discount types.");
                }
                try
                {
                    discountsT.InsertOnSubmit(disc);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                UpdateAddDiscountForm();
            }
        }

        private void buttonAddPlaystations_Click(object sender, EventArgs e)
        {
            AddRemoveFromDiscountForm arfdf = new AddRemoveFromDiscountForm(textBoxPlaystations.Text);
            arfdf.ShowDialog();
            textBoxPlaystations.Text = arfdf.Result;
        }
        private string TimeZonesMerger()
        {
            string result = "";
            foreach (Object t in checkedListBoxTimeZones.Items)
            {
                result += t;
                if (checkedListBoxTimeZones.Items.IndexOf(t) != checkedListBoxTimeZones.Items.Count)
                {
                    result += "; ";
                }
            }
            return result;
        }

        private void radioButtonPercentage_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPercentage.Enabled = true;
            groupBoxPercentage.Visible = true;

            groupBoxBonus.Enabled = false;
            groupBoxBonus.Visible = false;

            groupBoxRequirments.Enabled = false;
            groupBoxRequirments.Visible = false;
        }

        private void radioButtonBonusType_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPercentage.Enabled = false;
            groupBoxPercentage.Visible = false;

            groupBoxBonus.Enabled = true;
            groupBoxBonus.Visible = true;
            groupBoxRequirments.Enabled = true;
            groupBoxRequirments.Visible = true;

            groupBoxRequirments.Location = new Point(groupBoxRequirments.Location.X,
                groupBoxPercentage.Location.Y);
            groupBoxBonus.Location = new Point(groupBoxBonus.Location.X,
                groupBoxRequirments.Location.Y + groupBoxRequirments.Size.Height +  20);
        }

        private void checkBoxRequiredHours_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRequiredHours.Checked == true)
            {
                labelRequiredPaidTime.Visible = true;
                labelRequiredPaidTime.Enabled = true;

                numericUpDownRequiredPaidHours.Visible = true;
                numericUpDownRequiredPaidHours.Enabled = true;

                numericUpDownRequiredPaidMinutes.Visible = true;
                numericUpDownRequiredPaidMinutes.Enabled = true;

//                if (checkBoxRequiredItem.Checked)
//                {
//                    numericUpDownRequiredNumberOfItem.Location = new Point(numericUpDownRequiredNumberOfItem.Location.X, comboBoxRequiredItem.Location.Y + 20);
//                    comboBoxRequiredItem.Location = new Point(comboBoxRequiredItem.Location.X, labelRequiredItem.Location.Y + 20);
//                    labelRequiredItem.Location = new Point(labelRequiredItem.Location.X, labelRequiredPaidTime.Location.Y + 20);
//                }
            }
            else
            {
                labelRequiredPaidTime.Visible = false;
                labelRequiredPaidTime.Enabled = false;

                numericUpDownRequiredPaidHours.Visible = false;
                numericUpDownRequiredPaidHours.Enabled = false;

                numericUpDownRequiredPaidMinutes.Visible = false;
                numericUpDownRequiredPaidMinutes.Enabled = false;

//                if (checkBoxRequiredItem.Checked)
//                {
//                    numericUpDownRequiredNumberOfItem.Location = new Point(numericUpDownRequiredNumberOfItem.Location.X, comboBoxRequiredItem.Location.Y);
//                    comboBoxRequiredItem.Location = new Point(comboBoxRequiredItem.Location.X, labelRequiredItem.Location.Y);
//                    labelRequiredItem.Location = new Point(labelRequiredItem.Location.X, labelRequiredPaidTime.Location.Y);
//                }
            }
        }

        private void checkBoxRequiredItem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRequiredItem.Checked == true)
            {
                labelRequiredItem.Visible = true;
                labelRequiredNumber.Visible = true;

                comboBoxRequiredItem.Visible = true;
                comboBoxRequiredItem.Enabled = true;

                numericUpDownRequiredNumberOfItem.Visible = true;
                numericUpDownRequiredNumberOfItem.Enabled = true;
            }
            else
            {
                labelRequiredItem.Visible = false;
                labelRequiredNumber.Visible = false;

                comboBoxRequiredItem.Visible = false;
                comboBoxRequiredItem.Enabled = false;

                numericUpDownRequiredNumberOfItem.Visible = false;
                numericUpDownRequiredNumberOfItem.Enabled = false;
            }
        }

        private void groupBoxRequirments_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxBonus_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxBonusHours_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBonusHours.Checked)
            {
                labelBonusTime.Visible = true;
                labelBonusTime.Enabled = true;

                numericUpDownBonusHours.Visible = true;
                numericUpDownBonusHours.Enabled = true;

                numericUpDownBonusMinutes.Enabled = true;
                numericUpDownBonusMinutes.Visible = true;
            }
            else
            {
                numericUpDownBonusHours.Visible = false;
                numericUpDownBonusHours.Enabled = false;

                numericUpDownBonusMinutes.Enabled = false;
                numericUpDownBonusMinutes.Visible = false;

                labelBonusTime.Visible = false;
                labelBonusTime.Enabled = false;
            }
        }

        private void checkBoxBonusItem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBonusItem.Checked)
            {
                labelBonusItem.Visible = true;
                labelBonusItem.Enabled = true;

                comboBoxBonusItem.Visible = true;
                comboBoxBonusItem.Enabled = true;

                labelNumberOfBonusItem.Visible = true;
                labelNumberOfBonusItem.Enabled = true;

                numericUpDownNumberOfBonusItem.Visible = true;
                numericUpDownNumberOfBonusItem.Enabled = true;
            }
            else
            {
                labelBonusItem.Visible = false;
                labelBonusItem.Enabled = false;

                comboBoxBonusItem.Visible = false;
                comboBoxBonusItem.Enabled = false;

                labelNumberOfBonusItem.Visible = false;
                labelNumberOfBonusItem.Enabled = false;

                numericUpDownNumberOfBonusItem.Visible = false;
                numericUpDownNumberOfBonusItem.Enabled = false;
            }
        }

        private void checkBoxPriceDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPriceDiscount.Checked)
            {
                labelPriceDiscount.Visible = true;
                labelPriceDiscount.Enabled = true;
                
                numericUpDownPriceDiscount.Visible = true;
                numericUpDownPriceDiscount.Enabled = true;

                checkBoxBonusHours.Checked = false;
                checkBoxBonusItem.Checked = false;
            }
            else
            {
                labelPriceDiscount.Visible = false;
                labelPriceDiscount.Enabled = false;

                numericUpDownPriceDiscount.Visible = false;
                numericUpDownPriceDiscount.Enabled = false;
            }
        }
    }
}
