#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace LINQ_test
{
    internal class Options
    {
        private readonly Table<playstation_timezone> _plstTimeZonesTables;
        private readonly Table<timezones_t> _timeZonesTable;
        private readonly dbDataContext _db;
        private List<Timezones> _timeZonesList; 
        public Options()
        {
            _db = new dbDataContext();
            _plstTimeZonesTables = _db.GetTable<playstation_timezone>();
            _timeZonesTable = _db.GetTable<timezones_t>();
//             _timeZonesList = new List<Timezones>();
            CacheDataFromDb();
        }

        private void CacheDataFromDb()
        {
            _timeZonesList = (from t in _timeZonesTable
                    select new Timezones()
                    {
                        TimezoneName = t.timezone_name,
                        TimezoneStart = t.timezone_start,
                        TimezoneEnd = t.timezone_end
                    }).ToList();
        }

        private string WhichTimeZoneIs(DateTime timeToFind)
        {
            try
            {
                foreach (var tEndTime in _timeZonesList)
                {
                    if (IsInTimeZone(tEndTime.TimezoneStart, tEndTime.TimezoneEnd, timeToFind))
                    {
                        return tEndTime.TimezoneName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }

        public double GetAlreadyPlayedMoneySum(string plstId, TimeSpan startTime, double payedSum)
        {
            DateTime curTime = DateTime.Now;
            var startDate = new DateTime(curTime.Year, curTime.Month, curTime.Day, startTime.Hours, startTime.Minutes,
                startTime.Seconds);
            if (startDate > curTime)
            {
                startDate = startDate.Subtract(TimeSpan.FromDays(1));
            }

            if (startDate < curTime)
            {
                TimeSpan payedTime = curTime - startDate;
                return payedSum - GetSumToPay(plstId, payedTime, startDate);
            }
            return 0.0;
        }

        public double GetSumToPay(string playstationId, TimeSpan payedTime, DateTime startTime)
        {
            double sum = 0.0;
            DateTime timeToWorkWith = DateTime.Now;
            if (payedTime.TotalMinutes >= 60)
            {
                if (timeToWorkWith.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - timeToWorkWith.Minute);
                    sum += (60 - timeToWorkWith.Minute)*GetCurrentPriceForPlaystation(playstationId, timeToWorkWith)/60;
                    timeToWorkWith = timeToWorkWith.AddMinutes(60 - timeToWorkWith.Minute);
                    payedTime = payedTime.Subtract(toAccurateTime);
                }
                for (int i = 0; i < payedTime.TotalHours - 1; i++)
                {
                    sum += GetCurrentPriceForPlaystation(playstationId, timeToWorkWith);
                    timeToWorkWith = timeToWorkWith.AddHours(1);
                }
                if (payedTime.Minutes != 0)
                {
                    sum += GetCurrentPriceForPlaystation(playstationId, timeToWorkWith)/60*payedTime.Minutes;
                    timeToWorkWith = timeToWorkWith.Add(TimeSpan.FromMinutes(payedTime.Minutes));
                }
            }
            else
            {
                TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - timeToWorkWith.Minute);
                if (toAccurateTime <= payedTime)
                {
                    sum += (60 - timeToWorkWith.Minute)*GetCurrentPriceForPlaystation(playstationId, timeToWorkWith)/60;
                    payedTime = payedTime.Subtract(toAccurateTime);
                    timeToWorkWith = timeToWorkWith.Add(toAccurateTime);
                }
                if (payedTime.TotalMinutes > 0)
                {
                    sum += payedTime.TotalMinutes*GetCurrentPriceForPlaystation(playstationId, timeToWorkWith)/60;
                }
            }
            return sum;
        }

        public void TimeOutClosePlaystation(int dayId, DaySessionClass dsc)
        {
            lock (_db)
            {
                var getSessionIdtoDelete = (from s in _db.GetTable<days_sessions_t>()
                    where s.daily_id == dayId
                    where s.session_id == dsc.SessionId
                    select s).SingleOrDefault();
                if (getSessionIdtoDelete == null) return;
                getSessionIdtoDelete.session_state = "closed";
                getSessionIdtoDelete.money_left = dsc.MoneyLeft;
                if (String.IsNullOrEmpty(getSessionIdtoDelete.comments))
                {
                    getSessionIdtoDelete.comments = "";
                }

                var table = (from t in _db.GetTable<tables_t>()
                    where t.playstation_id == getSessionIdtoDelete.playstation_id
                    select t).SingleOrDefault();
                if (table != null)
                    table.playstation_state = "free";
                try
                {
                    _db.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show(
                        "Can't update DataBase during closing client comments! Please contact with Developer");
                }
            }
        }

        public double GetCurrentPriceForPlaystation(string playstationId, DateTime atTime)
        {
            double result = 0.0;
            string currentTimeZone = WhichTimeZoneIs(atTime);
            try
            {
                lock (_db)
                {
                    double? price = (from p in _plstTimeZonesTables
                        where p.timezone_name == currentTimeZone
                        where p.playstation_id == playstationId
                        select p.timezone_cost_per_hour).SingleOrDefault();
                    if (price != null)
                    {
                        result = (double) price;
                    }
                }
            }
            catch (Exception ex)
            {
//                    MessageBox.Show(ex.ToString());
            }
            return result;
        }

        public bool IsInTimeZone(TimeSpan begTime, TimeSpan endTime, DateTime date)
        {
            var beg = new DateTime(date.Year, date.Month, date.Day, begTime.Hours, begTime.Minutes, begTime.Seconds);
            var end = new DateTime(date.Year, date.Month, date.Day, endTime.Hours, endTime.Minutes, endTime.Seconds);
            if (beg > end)
            {
                end = end.AddDays(1);
            }
            bool res = (beg <= date && date < end) || (beg <= date.AddDays(1) && date.AddDays(1) < end);
            return res;
        }

        public DateTime GetTimeToPlay(double paidSum, string playstationId)
        {
            var result = new DateTime();
            DateTime currentTime = DateTime.Now;
            if (paidSum >= GetCurrentPriceForPlaystation(playstationId, currentTime))
            {
                if (currentTime.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - currentTime.Minute);
                    result = result.Add(toAccurateTime);
                    paidSum -= toAccurateTime.Minutes*GetCurrentPriceForPlaystation(playstationId, currentTime)/60;
                    currentTime = currentTime.Add(toAccurateTime);

                    double toSubstract = GetCurrentPriceForPlaystation(playstationId, currentTime);
                    while (paidSum - toSubstract > 0)
                    {
                        paidSum -= toSubstract;
                        result = result.Add(TimeSpan.FromHours(1));

                        currentTime = currentTime.Add(TimeSpan.FromHours(1));
                        toSubstract = GetCurrentPriceForPlaystation(playstationId, currentTime);
                    }
                }
            }
            if (paidSum > 0)
            {
                result =
                    result.Add(TimeSpan.FromMinutes(paidSum*60/GetCurrentPriceForPlaystation(playstationId, currentTime)));
            }
            return result;
        }
    }
}