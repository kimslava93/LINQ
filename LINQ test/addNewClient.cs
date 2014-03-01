using System;
//using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;
//using System.Threading;

namespace LINQ_test
{
    public partial class AddNewClient : Form
    {
        private bool _opTable;
        private bool _opClients;
        private Options _opt;
        private dbDataContext _db;
        private readonly int _dailyId;
        private DateTime _currentDateTime;
        public AddNewClient(int dayId)
        {
            _dailyId = dayId;
            InitializeComponent();
        }

        private void addNewClient_Load(object sender, EventArgs e)
        {
            _currentDateTime = DateTime.Now;
            db = new dbDataContext();
            _opt = new Options();
            _db = new dbDataContext();
            StartTimer();
            OpenTables();
            if (table_numComboBox.Items.Count > 0)
            {
                table_numComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("There is no available free consoles. Sorry for that!");
                Close();
            }
        }

        private void StartTimer()
        {
            current_time_timer.Start();
            current_time_timer.Enabled = true;
            current_time_label.Text = _currentDateTime.ToString("dd MMMM");
            labelcurrentTime.Text = _currentDateTime.ToString("HH:mm:ss");
        }

        private void table_num_MouseClick(object sender, MouseEventArgs e)
        {
            OpenTables();
        }

        private void OpenTables()
        {
            if (!_opTable)
            {
                _opTable = true;
                var tablesList = (from tb in _db.GetTable<tables_t>()
                                  orderby tb.playstation_id.Length ascending, tb.playstation_id ascending
                                  where tb.playstation_state == "free"
                                  select new
                                  {
                                      tb.playstation_id
                                  }).ToList();
                foreach (var tl in tablesList)
                {
                    table_numComboBox.Items.Add(tl.playstation_id);
                }
            }
        }

//        private void combo_box_client_discount_card_MouseClick(object sender, MouseEventArgs e)
//        {
//            if (!_opClients)
//            {
//                _opClients = true;
//
//                var clientsList = (from c in _db.GetTable<client_info_t>()
//                    orderby c.client_id ascending
//                    select new
//                    {
//                        c.client_id
//                    }).ToList();
//                combo_box_client_discount_card.DataSource = clientsList;
////                foreach (var cl in clientsList)
////                {
////                    combo_box_client_discount_card.Items.Add(cl.client_id);
////                }
//            }
//        }

//        private void GetClientDataAddClientForm()
//        {
//            var clients = (from clientName in _db.GetTable<client_info_t>()
//                from clientSavings in _db.GetTable<account_savings_t>()
//                where
//                    clientName.client_id == combo_box_client_discount_card.Text &&
//                    clientSavings.client_id == combo_box_client_discount_card.Text
//                select new
//                {
//                    clientName.name,
//                    clientSavings.savings
//                }).ToList();
//
//            client_name_textBox.Text = clients[0].name;
//            clients_money_left_textBox.Text = clients[0].savings.ToString(CultureInfo.InvariantCulture);
//        }

//        private void combo_box_client_discount_card_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (combo_box_client_discount_card.Text != "0")
//            {
//                deposit_payment_groupBox.Enabled = false;
//                client_info_group_box.Enabled = true;
//                GetClientDataAddClientForm();
//            }
//            else
//            {
//                deposit_payment_groupBox.Enabled = true;
//                client_info_group_box.Enabled = false;
//
//                client_name_textBox.Text = "Usual client";
//                clients_money_left_textBox.Text = "0";
//            }
//        }

        private void current_time_timer_Tick(object sender, EventArgs e)
        {
            _currentDateTime = DateTime.Now;
            current_time_label.Text = _currentDateTime.ToString("dd MMMM");
            labelcurrentTime.Text = _currentDateTime.ToString("HH:mm:ss");
        }

        private void paid_price_numeric_up_down_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void paid_price_numeric_up_down_KeyUp(object sender, KeyEventArgs e)
        {
            if (radioButtonPaidSum.Checked)
            {
                if (paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
                    paid_price_numeric_up_down.Value < 0)
                {
                    paid_price_numeric_up_down.Value = 0;
                    paid_price_numeric_up_down.Text = "0";
                }
                GetTimeOnNumericUpDownValueChanged();
            }
        }

        private void radioButtonTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimeOut.Checked == true)
            {
                radioButtonTimeOut.Checked = true;
                numericUpDownHoursLeft.Enabled = true;
                numericUpDownMinutesLeft.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
            else
            {
                radioButtonTimeOut.Checked = false;
                numericUpDownHoursLeft.Enabled = false;
                numericUpDownMinutesLeft.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
            numericUpDownHoursLeft.Value = 0;
            numericUpDownMinutesLeft.Value = 0;
            paid_price_numeric_up_down.Value = 0;
        }

        private void radioButtonPaidSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked)
            {
                radioButtonTimeOut.Checked = false;
                numericUpDownHoursLeft.Enabled = false;
                numericUpDownMinutesLeft.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
            else
            {
                radioButtonTimeOut.Checked = true;
                numericUpDownHoursLeft.Enabled = true;
                numericUpDownMinutesLeft.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
            numericUpDownHoursLeft.Value = 0;
            numericUpDownMinutesLeft.Value = 0;
            paid_price_numeric_up_down.Value = 0;
        }

        private void paid_price_numeric_up_down_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked)
            {
                if (paid_price_numeric_up_down.Value > 30000 ||
                    paid_price_numeric_up_down.Value < 0)
                {
                    paid_price_numeric_up_down.Value = 0;
                }
                GetTimeOnNumericUpDownValueChanged();
            }
        }

        private void GetTimeOnNumericUpDownValueChanged()
        {
            try
            {
                DateTime paidTime = _opt.GetTimeToPlay((double) paid_price_numeric_up_down.Value,
                    table_numComboBox.Text);
                numericUpDownHoursLeft.Value = (paidTime.Day - 1)*24 + paidTime.Hour;
                numericUpDownMinutesLeft.Value = paidTime.Minute;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error occured during updating paid time values!");
            }
        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan ct = DateTime.Now.TimeOfDay;
            
            if (!String.IsNullOrWhiteSpace(table_numComboBox.Text))
            {
                var q = (from days in db.GetTable<days_sessions_t>()
                         where days.daily_id == _dailyId
                         orderby days.client_num descending
                         select days.client_num).FirstOrDefault();

                var table = (from t in db.GetTable<tables_t>()
                             where t.playstation_id == table_numComboBox.Text
                             select t).Single();
                if (textBoxDiscounts.Text == "0")
                {
                    TimeSpan paidTime =
                        TimeSpan.FromMinutes(
                            (double) ((numericUpDownHoursLeft.Value*60) + numericUpDownMinutesLeft.Value));
                    
                    Table<days_sessions_t> daysT = db.GetTable<days_sessions_t>();
                    var daysSessionT = new days_sessions_t();
                    Table<clents_per_session_t> clientsPersessionTable = db.GetTable<clents_per_session_t>();
                    clents_per_session_t clientsPerSessionT = new clents_per_session_t();
    
                    daysSessionT.daily_id = _dailyId;
                    daysSessionT.client_num = (int) q + 1;
                    daysSessionT.start_game = new TimeSpan(currentTime.Hours, currentTime.Minutes, currentTime.Seconds);
                    daysSessionT.end_game = new TimeSpan(ct.Add(paidTime).Hours, ct.Add(paidTime).Minutes, ct.Add(paidTime).Seconds);
                    daysSessionT.playstation_id = table_numComboBox.Text;
//                    daysSessionT.client_id = combo_box_client_discount_card.Text;
                    daysSessionT.session_state = "opened";
                    //
                    clientsPerSessionT.session_id = daysSessionT.session_id;
                    clientsPerSessionT.client_id = textBoxDiscounts.Text;//------------------------------------------------------------------------------NEED OT FIXED
                    //
                    daysSessionT.payed_sum = (double) (paid_price_numeric_up_down.Value);
                    daysSessionT.money_left = (double) (paid_price_numeric_up_down.Value);
                    daysSessionT.session_discount = 0;
                    daysSessionT.session_id = daysSessionT.session_id;
                    try
                    {
                        daysT.InsertOnSubmit(daysSessionT);
//                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                    if (table.playstation_id != null)
                    {
                        table.playstation_state = "busy";
                        try
                        {
                            db.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't find a playstation " + table.playstation_id);
                    }
                }
            }
            
            Close();
        }

        private void numericUpDownHoursLeft_ValueChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void numericUpDownMinutesLeft_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMinutesLeft.Value >= 60)
            {
                numericUpDownMinutesLeft.Value = 0;
                numericUpDownHoursLeft.Value++;
            }
            SetPrice();
        }

        private void SetPrice()
        {
            Options opt = new Options();
            DateTime currentTime = DateTime.Now;
            if (numericUpDownHoursLeft.Value < 0 || numericUpDownMinutesLeft.Value < 0)
            {
                numericUpDownHoursLeft.Value = 0;
                numericUpDownMinutesLeft.Value = 0;
            }
            if (radioButtonTimeOut.Checked == true)
            {
                if (numericUpDownHoursLeft.Value >= 0 || numericUpDownMinutesLeft.Value >= 0)
                {
                    TimeSpan toPlay = new TimeSpan((int)numericUpDownHoursLeft.Value/24, (int)numericUpDownHoursLeft.Value, (int)numericUpDownMinutesLeft.Value, 0);

                    double price = opt.GetSumToPay(table_numComboBox.Text, toPlay,currentTime);
                    if (price < 0)
                    {
                        paid_price_numeric_up_down.Value = 0;
                    }
                    else if ((decimal)price < paid_price_numeric_up_down.Minimum && (decimal)price > paid_price_numeric_up_down.Maximum)
                    {
                        MessageBox.Show("Price is lower than 0 or higher than 30 000 \nIt is very high price please check entered data");
                    }
                    else
                    {
                        paid_price_numeric_up_down.Value = Math.Round((decimal)price, 2);
                    }
                }
            }
        }

        private void add_payment_button_Click(object sender, EventArgs e)
        {
            //add money on selected card in case if not enough money to play
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
           AddClients();
        }

        private void AddClients()
        {
            AddDiscountCardToSession adcts = new AddDiscountCardToSession(_db);
            adcts.ShowDialog();
            if (IsRepeated(adcts.Result))
            {
                if (textBoxDiscounts.Text.Length <= 0 || textBoxDiscounts.Text == "0")
                {
                    textBoxDiscounts.Text = adcts.Result;
                }
                else
                {
                    textBoxDiscounts.Text += "; " + adcts.Result;
                }
            }
        }

        private bool IsRepeated(string cardId)
        {
            if (textBoxDiscounts.Text.Length <= 0)
            {
                return false;
            }
            List<string> splited = Regex.Split(textBoxDiscounts.Text, "; ").ToList();
            var matchedResult = (from m in splited
                where m == cardId
                select m).SingleOrDefault();
            if (matchedResult != null)
            {
                return false;
            }
            return true;
        }

        private void textBoxDiscounts_MouseClick(object sender, MouseEventArgs e)
        {
            AddClients();
        }
    }
}
