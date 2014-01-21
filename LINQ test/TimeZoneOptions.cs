using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LINQ_test
{
    class TimeZoneOptions
    {
        private Dictionary<string, double> CurrentPlaystationPrice;
        private dbDataContext db;
        
        public void GetPricesFromDb()
        {
            db = new dbDataContext();
            CurrentPlaystationPrice = new Dictionary<string, double>();
            var timezone = (from t in db.GetTable<timezones_t>()
                where t.timezone_start <= DateTime.Now.TimeOfDay
                where t.timezone_end > DateTime.Now.TimeOfDay
                select t.timezone_name).Single();

            var playstationPrice = (from pp in db.GetTable<timezones_t>()
                where pp.timezone_name == timezone
                select new
                {
                    pp.timezone_name
//                    pp.timezone_cost_per_hour
                }).ToList();

//            for (int i = 0; i < playstationPrice.Count; i++)
//            {
//                CurrentPlaystationPrice.Add(playstationPrice[i].timezone_name,
//                    playstationPrice[i].timezone_cost_per_hour);
//            }
//            MessageBox.Show(CurrentPlaystationPrice.ToString());
        }

//
//        public TimeZoneOptions()
//        {
//
//        }
    }
}
