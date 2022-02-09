using System;

namespace NepaliCalendar
{
    public struct MonthInfo
    {
        public int Year { get; set; }
        public int month { get; set; }
        public int days => Convert.GetMonthDayCount(Year, month);
        public string Month => month.ToString("D2");
        public string Days => days.ToString("D2");
        public string StartDateNep => $"{Year}-{Month}-01";
        public string EndDateNep => $"{Year}-{Month}-{Days}";
        public DateTime StartDate => Convert.ToEnglish(StartDateNep);
        public DateTime EndDate => Convert.ToEnglish(EndDateNep);
        public override string ToString()
        {
            return StartDateNep;
        }
        public MonthInfo(int year, int Month)
        {
            Year = year;
            month = Month;
        }
        public MonthInfo(string NepaliDate)
        {
            NepDate n = new NepDate(NepaliDate);
            Year = n.Year;
            month = n.Month;
        }

        public MonthInfo PrevMonth()
        {
            int nYear = Year, nMonth = month - 1;
            if (nMonth < 1)
            {
                nMonth = 12; nYear--;
            }
            return new MonthInfo(nYear, nMonth);
        }
        public MonthInfo NextMonth()
        {
            int nYear = Year, nMonth = month + 1;
            if (nMonth > 12)
            {
                nMonth = 1; nYear++;
            }
            return new MonthInfo(nYear, nMonth);
        }
    }
}
