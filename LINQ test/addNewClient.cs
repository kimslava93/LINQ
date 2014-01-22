using System;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class AddNewClient : Form
    {
        private bool _opTable = false;
        private bool _opClients = false;
        private Options _opt;
        private dbDataContext _db;
        private readonly int _dailyId;
        public AddNewClient(int dayId)
        {
            _dailyId = dayId;
            InitializeComponent();
        }

        private void addNewClient_Load(object sender, EventArgs e)
        {
            db = new dbDataContext();
            _opt = new Options();
            _db = new dbDataContext();
            StartTimer();
            OpenTables();
            table_numComboBox.SelectedIndex = 0;
        }

        private void StartTimer()
        {
            current_time_timer.Start();
            current_time_timer.Enabled = true;
            current_time_label.Text = "Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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

        private void combo_box_client_discount_card_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_opClients)
            {
                _opClients = true;

                var clientsList = (from c in _db.GetTable<client_info_t>()
                    orderby c.client_id ascending
                    select new
                    {
                        c.client_id
                    }).ToList();
                
                foreach (var cl in clientsList)
                {
                    combo_box_client_discount_card.Items.Add(cl.client_id);
                }
            }
        }

        private void get_client_data_add_client_form()
        {
            var clients = (from clientName in _db.GetTable<client_info_t>()
                from clientSavings in _db.GetTable<account_savings_t>()
                where
                    clientName.client_id == combo_box_client_discount_card.Text &&
                    clientSavings.client_id == combo_box_client_discount_card.Text
                select new
                {
                    clientName.name,
                    clientSavings.savings
                }).ToList();

            client_name_textBox.Text = clients[0].name;
            clients_money_left_textBox.Text = clients[0].savings.ToString(CultureInfo.InvariantCulture);
        }

        private void combo_box_client_discount_card_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_box_client_discount_card.Text != "0")
            {
                deposit_payment_groupBox.Enabled = false;
                client_info_group_box.Enabled = true;
                get_client_data_add_client_form();
            }
            else
            {
                deposit_payment_groupBox.Enabled = true;
                client_info_group_box.Enabled = false;

                client_name_textBox.Text = "Usual client";
                clients_money_left_textBox.Text = "0";
            }
        }

        private void current_time_timer_Tick(object sender, EventArgs e)
        {
            current_time_label.Text = "Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
//            if (radioButtonPaidSum.Checked == true)
//            {
//                if (paid_price_numeric_up_down.Value <= 0 || paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
//                    paid_price_numeric_up_down.Value < paid_price_numeric_up_down.Minimum)
//                {
//                    paid_price_numeric_up_down.Value = 0;
//                }
//
//                double paidTime = 0;
//                try
//                {
//                    paidTime = (double)paid_price_numeric_up_down.Value / opt.getPrice(int.Parse(table_num.Text));
//                    client_TIME_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
//                    client_DATE_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
//                }
//                catch (FormatException)
//                {
//                    MessageBox.Show("Error");
//                }
//            }
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
        }

        private void radioButtonPaidSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
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
        }

        private void paid_price_numeric_up_down_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
            {
                if (paid_price_numeric_up_down.Value <= 0 || paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
                    paid_price_numeric_up_down.Value < paid_price_numeric_up_down.Minimum)
                {
                    paid_price_numeric_up_down.Value = 0;
                }

                double paidTime = 0;
                try
                {
                    paidTime = (double)paid_price_numeric_up_down.Value / (_opt.GetCurrentPriceFor(table_numComboBox.Text)/60);
                    numericUpDownHoursLeft.Value = (int)paidTime / 60;
                    if (paidTime >= 60)
                    {
                        numericUpDownMinutesLeft.Value = (int)paidTime%60;
                    }
                    else
                    {
                        numericUpDownMinutesLeft.Value = (int)paidTime;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void client_TIME_out_field_ValueChanged(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            if (numericUpDownHoursLeft.Value <0 || numericUpDownMinutesLeft.Value < 0)
            {
                numericUpDownHoursLeft.Value = 0;
                numericUpDownMinutesLeft.Value = 0;
            }
            if (radioButtonTimeOut.Checked == true)
            {
                if (numericUpDownHoursLeft.Value != 0 || numericUpDownMinutesLeft.Value != 0)
                {
                    int minutes = (int)((numericUpDownHoursLeft.Value*60) + numericUpDownMinutesLeft.Value);
                    double price = minutes * _opt.GetCurrentPriceFor(table_numComboBox.Text) / 60;
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
        private void GetCurrentDiscount()
        {

        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Parse(DateTime.Now.TimeOfDay.ToString("HH:mm:00"));
            TimeSpan ct = TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString("HH:mm:00"));
             var q = (from days in db.GetTable<days_sessions_t>()
                    from account in db.GetTable<session_accounting_t>()
                    where days.daily_id == _dailyId
                    orderby days.client_num ascending
                    select new
                    {
                        days.client_num,
                        days.playstation_id,
                        days.start_game,
                        days.end_game,
                        days.client_id,
                        account.played_money,
                        account.payed_sum
                    }).ToList();
            if (table_numComboBox.Text != "" || table_numComboBox.Text != null)
            {
                if (combo_box_client_discount_card.Text == "0")
                {
                    TimeSpan toAdd = TimeSpan.FromMinutes((double)((numericUpDownHoursLeft.Value*60) + numericUpDownMinutesLeft.Value));
                    Table<days_sessions_t> daysT = db.GetTable<days_sessions_t>();
                    days_sessions_t daysSessionT = new days_sessions_t();

                    daysSessionT.client_num = q[q.Count - 1].client_num;
                    daysSessionT.playstation_id = table_numComboBox.Text;
                    daysSessionT.start_game = currentTime.TimeOfDay;
                    daysSessionT.end_game = ct.Add(toAdd);
                    daysSessionT.client_id = combo_box_client_discount_card.Text;
                    daysT.InsertOnSubmit(daysSessionT);
                    db.SubmitChanges();


                    Table<session_accounting_t> sessAccount = db.GetTable<session_accounting_t>();
                    session_accounting_t sessionAccountingT = new session_accounting_t();
                    sessionAccountingT.played_money = 0;
                    sessionAccountingT.payed_sum = (double)(paid_price_numeric_up_down.Value);
                    sessionAccountingT.session_discount = 0;
                }
            }
        }

        private void numericUpDownHoursLeft_ValueChanged(object sender, EventArgs e)
        {
           setPrice();
        }

        private void numericUpDownMinutesLeft_ValueChanged(object sender, EventArgs e)
        {
            setPrice();
        }

        private void setPrice()
        {

            if (numericUpDownHoursLeft.Value < 0 || numericUpDownMinutesLeft.Value < 0)
            {
                numericUpDownHoursLeft.Value = 0;
                numericUpDownMinutesLeft.Value = 0;
            }
            else if (numericUpDownHoursLeft.Value < 0 || numericUpDownMinutesLeft.Value < 0)
            {
                paid_price_numeric_up_down.Value = 0;
            }
            if (radioButtonTimeOut.Checked == true)
            {
                if (numericUpDownHoursLeft.Value >= 0 || numericUpDownMinutesLeft.Value >= 0)
                {
                    int minutes = (int)((numericUpDownHoursLeft.Value * 60) + numericUpDownMinutesLeft.Value);
                    double price = minutes * _opt.GetCurrentPriceFor(table_numComboBox.Text) / 60;
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

        }
    }
}
