using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NepaliCalendar
{
    public static class NepaliCalendarExtension
    {
        //public static string BSNow(this string str)
        //{
        //    return NepaliCalendar.Convert.Now;
        //}
        /// <summary>
        /// Converts Given string to AD Date
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToAD(this string str)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.ToEnglish(str);
        }
        /// <summary>
        /// Converts Given Datetime to BS Date
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToBS(this DateTime str)
        {
            return NepaliCalendar.Convert.ToNepali(str);
        }
        /// <summary>
        /// Adds given no of months to given date and return new date
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Months"></param>
        /// <returns></returns>
        public static string BSAddMonths(this string str, int Months)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.AddMonths(str, Months);
        }
        /// <summary>
        /// Adds given no of years to given date and return new date
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Years"></param>
        /// <returns></returns>
        public static string BSAddYears(this string str, int Years)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.AddYears(str, Years);
        }

        /// <summary>
        /// Adds given no of months to the date and returns day count to that date
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Months"></param>
        /// <returns></returns>
        public static int BSDayCountAfterMonths(this string str, int Months)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.AddMonthsAndGetDayCount(str, Months);
        }
        /// <summary>
        /// Adds given no of years to the date and returns day count to that date
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Years"></param>
        /// <returns></returns>
        public static int BSDayCountAfterYears(this string str, int Years)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.AddYearsAndGetDayCount(str, Years);
        }
        /// <summary>
        /// Calculates no of days between two dates
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ToNepaliDate"></param>
        /// <returns></returns>
        public static int BSDayCount(this string str, string ToNepaliDate)
        {
            str.BSCheckValidAndThrow();
            ToNepaliDate.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.GetDayCount(str, ToNepaliDate);
        }
        /// <summary>
        /// Calculates no of months between two dates
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ToNepaliDate"></param>
        /// <returns></returns>
        public static int BSMonthCount(this string str, string ToNepaliDate)
        {
            str.BSCheckValidAndThrow();
            ToNepaliDate.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.GetMonthCount(str, ToNepaliDate);
        }
        /// <summary>
        /// Checks if given date is leap year or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsLeapYear(this string str)
        {
            str.BSCheckValidAndThrow();
            return NepaliCalendar.Convert.IsLeapYear(System.Convert.ToInt32(str.Substring(0, 4)));
        }
        /// <summary>
        /// Return Month info of current date
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static MonthInfo BSMonthInfo(this string str)
        {
            str.BSCheckValidAndThrow();
            return new MonthInfo(str);
        }
        /// <summary>
        /// Quick check for nepali date format
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool BSIsValid(this string str)
        {
            return Regex.Match(str, @"\d{4}[\/-]\d{2}[\/-]\d{2}").Success;
            //) { throw new Exception("Should be in yyyy/MM/dd Format with 10 chars as lenght."); }
            //return true;
        }
        public static bool BSCheckValidAndThrow(this string str)
        {
            if (!str.BSIsValid()) { throw new Exception("Should be in yyyy/MM/dd Format with 10 chars as lenght."); }
            return true;
        }


    }
}
