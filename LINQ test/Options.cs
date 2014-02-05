using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LINQ_test
{
    class Options
    {
        private dbDataContext db;

        public Options()
        {
            db = new dbDataContext();
        }

        public double GetSumToPay(string playstationId, TimeSpan timeToAdd)
        {
            double sum = 0.0;
            DateTime timeToWorkWith = DateTime.Now;
            if (timeToAdd.TotalMinutes >= 60)
            {
                if (timeToWorkWith.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - timeToWorkWith.Minute);
                    sum += (60 - timeToWorkWith.Minute)*GetCurrentPriceFor(playstationId, timeToWorkWith)/60;
                    timeToWorkWith = timeToWorkWith.AddMinutes(60 - timeToWorkWith.Minute);
                    timeToAdd = timeToAdd.Subtract(toAccurateTime);
                }
                for (int i = 0; i < timeToAdd.Hours; i++)
                {
                    sum += GetCurrentPriceFor(playstationId, timeToWorkWith);
                    timeToWorkWith = timeToWorkWith.AddHours(1);
                }
                if (timeToAdd.Minutes != 0)
                {
                    sum += GetCurrentPriceFor(playstationId, timeToWorkWith)/60*timeToAdd.Minutes;
                    timeToWorkWith = timeToWorkWith.Add(TimeSpan.FromMinutes(timeToAdd.Minutes));
                }
            }
            else
            {
                TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - timeToWorkWith.Minute);
                if (toAccurateTime <= timeToAdd)
                {
                    sum += (60 - timeToWorkWith.Minute)*GetCurrentPriceFor(playstationId, timeToWorkWith)/60;
                    timeToAdd = timeToAdd.Subtract(toAccurateTime);
                    timeToWorkWith = timeToWorkWith.Add(toAccurateTime);
                }
                if (timeToAdd.TotalMinutes > 0)
                {
                    sum += timeToAdd.TotalMinutes*GetCurrentPriceFor(playstationId, timeToWorkWith)/60;
                }
            }
            return sum;
        }


        public double GetCurrentPriceFor(string playstationId, DateTime atTime)
        {
            double result = 0.0;
            string currentTimeZone = WhichTimeZoneIs(atTime);
            var price = (from p in db.GetTable<playstation_timezone>()
                         where p.timezone_name == currentTimeZone
                         where p.playstation_id == playstationId
                         select p.timezone_cost_per_hour).SingleOrDefault();
            if (price != null)
            {
                result = (double)price;
            }
            return result;
        }

        public bool IsInTimeZone(TimeSpan begTime, TimeSpan endTime, DateTime date)
        {
            DateTime beg = new DateTime(date.Year, date.Month, date.Day, begTime.Hours, begTime.Minutes, begTime.Seconds);
            DateTime end = new DateTime(date.Year, date.Month, date.Day, endTime.Hours, endTime.Minutes, endTime.Seconds);
            if (beg > end)
            {
                end = end.AddDays(1);
            }
            bool res = (beg <= date && date < end) || (beg <= date.AddDays(1) && date.AddDays(1) < end);
            return res;
        }

        public TimeSpan GetTimeToPlay(double paidSum, string playstationId)
        {
            TimeSpan result = new TimeSpan();
            DateTime currentTime = DateTime.Now;
            if (paidSum >= GetCurrentPriceFor(playstationId, currentTime))
            {
                if (currentTime.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - currentTime.Minute);
                    result = result.Add(toAccurateTime);
                    paidSum -= toAccurateTime.Minutes*GetCurrentPriceFor(playstationId, currentTime)/60;
                    currentTime = currentTime.Add(toAccurateTime);

                    double toSubstract = GetCurrentPriceFor(playstationId, currentTime);
                    while (paidSum - toSubstract > 0)
                    {
                        paidSum -= toSubstract;
                        result = result.Add(TimeSpan.FromHours(1));
                        currentTime = currentTime.Add(TimeSpan.FromHours(1));
                        toSubstract = GetCurrentPriceFor(playstationId, currentTime);
                    }
                    
                }   
            }
            if (paidSum > 0)
            {
                result = result.Add(TimeSpan.FromMinutes(paidSum*60/GetCurrentPriceFor(playstationId, currentTime)));
            }
            return result;
        }

        public string WhichTimeZoneIs(DateTime TimeToFind)
        {
            string TimeZone = "";
            try
            {
                var timezonesEndtime = (from t in db.GetTable<timezones_t>()
                    select new
                    {
                        t.timezone_name,
                        t.timezone_start,
                        t.timezone_end

                    }).ToList();
                for (int i = 0; i < timezonesEndtime.Count; i++)
                {
                    DateTime start = new DateTime(timezonesEndtime[i].timezone_start.Ticks);
                    DateTime end = new DateTime(timezonesEndtime[i].timezone_end.Ticks);
                    if (IsInTimeZone(timezonesEndtime[i].timezone_start, timezonesEndtime[i].timezone_end, TimeToFind))
                    {
                        return timezonesEndtime[i].timezone_name;
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
