using NepaliCalendar;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProj
{
    public class MonthInfoTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void BasicTest()
        {
            MonthInfo x = new MonthInfo() { Year = 2078, month = 4 };
            Assert.AreEqual(x.StartDate, new DateTime(2021, 7, 16));
            Assert.AreEqual(x.EndDate, new DateTime(2021, 8, 16));
            Assert.AreEqual(x.days, 32);
            Assert.AreEqual(x.NextMonth().StartDate, new DateTime(2021, 8, 17));
            Assert.AreEqual(x.NextMonth().EndDate, new DateTime(2021, 9, 16));
            Assert.AreEqual(x.NextMonth().days, 31);
            Assert.AreEqual(x.PrevMonth().StartDate, new DateTime(2021, 6, 15));
            Assert.AreEqual(x.PrevMonth().EndDate, new DateTime(2021, 7, 15));
            Assert.AreEqual(x.PrevMonth().days, 31);
        }
    }
}
