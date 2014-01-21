using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    public partial class AddNewClient : Form
    {
        private bool _opTable = false;
        private bool _opClients = false;
        private Options opt;
        private dbDataContext _db;
        public AddNewClient()
        {
            InitializeComponent();
        }

        private void addNewClient_Load(object sender, EventArgs e)
        {
            opt = new Options();
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
                client_DATE_out_field.Enabled = true;
                client_TIME_out_field.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
            else
            {
                radioButtonTimeOut.Checked = false;
                client_DATE_out_field.Enabled = false;
                client_TIME_out_field.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
        }

        private void radioButtonPaidSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
            {
                radioButtonTimeOut.Checked = false;
                client_DATE_out_field.Enabled = false;
                client_TIME_out_field.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
            else
            {
                radioButtonTimeOut.Checked = true;
                client_DATE_out_field.Enabled = true;
                client_TIME_out_field.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
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
                    paidTime = (double)paid_price_numeric_up_down.Value / (opt.GetCurrentPriceFor(table_numComboBox.Text) / 60);
                    client_TIME_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
                    client_DATE_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
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
            if (DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm")) <
                                DateTime.Parse(currentDateTime.ToString("dd.MM.yyyy HH:mm")))
            {
                client_TIME_out_field.Text = currentDateTime.ToString("HH:mm");
            }
            if (radioButtonTimeOut.Checked == true)
            {
                if ((client_DATE_out_field.Value.ToString("dd.MM.yyyy") + client_TIME_out_field.Value.ToString("HH:mm") != DateTime.Now.ToString("dd.MM.yyyy HH:mm")))
                {
                    TimeSpan days_span = DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MM.yyyy") +
                                                    " " + client_TIME_out_field.Value.ToString("HH:mm")).Subtract(currentDateTime);
                    double minutes = days_span.TotalMinutes;
                    client_DATE_out_field.Value.AddMinutes(minutes);
                    double price = minutes * opt.GetCurrentPriceFor(table_numComboBox.Text) / 60;
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
    }
}
