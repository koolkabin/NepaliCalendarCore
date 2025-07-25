using NepaliCalendar.Utils;
using System;
using Convert = NepaliCalendar.Utils.Convert;

namespace NepaliCalendar
{
    public class NepDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        private string _weekDayName;
        public string WeekDayName
        {
            get { return _weekDayName; }
            set { _weekDayName = value; }
        }

        public string MonthName { get; set; }
        public int WeekDay { get; set; }
        private string sep = "-";

        public NepDate() { }

        /// <summary>
        /// Nepali date Converter, format: yyyy/MM/dd
        /// </summary>
        /// <param name="stringDate"></param>
        public NepDate(string stringDate)
        {

            if (stringDate.Length != 10) { throw new Exception("Nepali date must be 10 chars and in format YYYY-MM-DD. Date Tested: " + stringDate); }
            if (stringDate[4] != sep[0] && stringDate[7] != sep[0]) { throw new Exception("Nepali date must be Seperate at pos 5 and 8 with seperator. Format: YYYY-MM-DD. Date Tested: " + stringDate); }

            string strYear, strMonth, strDay;
            strYear = stringDate.Substring(0, 4);
            strMonth = stringDate.Substring(5, 2);
            strDay = stringDate.Substring(8, 2);

            int intYear = 0, intMonth = 0, intDay = 0;
            int.TryParse(strYear, out intYear);
            int.TryParse(strMonth, out intMonth);
            int.TryParse(strDay, out intDay);

            if (intMonth > 12) { throw new Exception("Month in Nepali Date Cannot be greater than 12. Date: " + stringDate); }

            //check in range
            if (Convert.IsRangeNep(intYear, intMonth, intDay))
            {
                this.Year = intYear;
                this.Month = intMonth;
                this.Day = intDay;
            }
            else
            {
                throw new Exception("Invalid Nepali Date provided. Date: " + stringDate);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Year, Month.ToString().PadLeft(2, '0'), Day.ToString().PadLeft(2, '0'));
        }
        public string ToLongDateString()
        {
            return string.Format("{0}, {1} {2}, {3}", WeekDayName, MonthName, Day, Year);
        }


    }
}
