using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LINQ_test.bin.Debug
{
    class Options
    {
        private dbDataContext db;
        public double GetPrice(string playstationID)
        {
            double result = 0.0;

            return result;
        }

        public void CheckTimeZone()
        {
            db = new dbDataContext();
            try
            {
                var timezone = (from t in db.GetTable<timezones_t>()
                    where t.timezone_start <= DateTime.Now.TimeOfDay
                    where t.timezone_end > DateTime.Now.TimeOfDay
                    select t.timezone_name).SingleOrDefault();
                MessageBox.Show(timezone);
            }
            catch (Exception)
            {
                var timezone = (from t in db.GetTable<timezones_t>()
                                where t.timezone_start <= DateTime.Now.TimeOfDay
                                where t.timezone_end < DateTime.Now.TimeOfDay
                                select t.timezone_name).Single();
                MessageBox.Show(timezone);
            }
            //bool n = DateTime.Parse("1:00:00") < DateTime.Parse("7:00:00");
            //bool n2 = DateTime.Parse("1:00:00") < DateTime.Parse("12:00:00");

            //bool n = DateTime.Parse("1:00:00") < DateTime.Parse("12:00:00");
            //bool n2 = DateTime.Parse("1:00:00") < DateTime.Parse("19:00:00");

            //bool n = DateTime.Parse("1:00:00") < DateTime.Parse("19:00:00");
            //bool n2 = DateTime.Parse("1:00:00") < DateTime.Parse("7:00:00");
            //MessageBox.Show(n + " " + n2);
        }
    }
}
