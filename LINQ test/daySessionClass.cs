#region

using System;

#endregion

namespace LINQ_test
{
    internal class DaySessionClass
    {
        public int SessionId { get; set; }
        public string PlaystationId { get; set; }
        public TimeSpan StartGame { get; set; }
        public TimeSpan EndGame { get; set; }
        public string ClientId { get; set; }
        public double MoneyLeft { get; set; }
        public double SessionDiscount { get; set; }
        public double PayedSum { get; set; }
    }
}