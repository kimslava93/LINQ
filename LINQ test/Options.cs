using System;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_test
{
    class Options
    {
        private dbDataContext db;

        public Options()
        {
            db = new dbDataContext();
        }

        public double GetCurrentPriceFor(string playstationID)
        {
            double result = 0.0;
            string currentTimeZone = WhichTimeZoneIsNow();
            var price = (from p in db.GetTable<playstation_timezone>()
                         where p.timezone_name == currentTimeZone
                         where p.playstation_id == playstationID
                         select p.timezone_cost_per_hour).SingleOrDefault();
            if (price != null)
            {
                result = (double)price;
            }
            return result;

        }

        public string WhichTimeZoneIsNow()
        {
            string TimeZone = "";
            TimeSpan currentHour = DateTime.Now.TimeOfDay;
            try
            {
                var timezonesEndtime = (from t in db.GetTable<timezones_t>()
                                        select new
                                        {
                                            t.timezone_name,
                                            t.timezone_end
                                        }).ToList();
                bool finish = false;
                while (true)
                {
                    for (int i = 0; i < timezonesEndtime.Count; i++)
                    {
                        if (currentHour.Hours == timezonesEndtime[i].timezone_end.Hours)
                        {
                            TimeZone = timezonesEndtime[i].timezone_name;
                            finish = true;
                        }
                    }
                    currentHour = currentHour.Add(TimeSpan.FromHours(1));
                    if (finish)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return TimeZone;
        }
    }
}
