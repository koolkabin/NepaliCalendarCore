using NUnit.Framework;
using System;
using System.Linq;

namespace NUnitTestProj
{
    public class ConvertTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test2000101Eng()
        {
            string nDate = "2000-01-01";
            DateTime eDate = new DateTime(1943, 4, 14);

            var res = NepaliCalendar.Convert.ToEnglish(nDate);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void Test19440413Nep()
        {
            string nDate = "2001-01-01";
            DateTime eDate = new DateTime(1944, 4, 13);

            var res = NepaliCalendar.Convert.ToNepali(eDate);
            Assert.AreEqual(res, nDate);
        }
        [Test]
        public void TestToEng()
        {
            string nDate = "2074-04-01";
            DateTime eDate = new DateTime(2017, 07, 16);

            var res = NepaliCalendar.Convert.ToEnglish(nDate);
            Assert.AreEqual(eDate.ToString("yyyy-MM-dd"), res.ToString("yyyy-MM-dd"));
        }

        [Test]
        public void TestToNep()
        {
            string nDate = "2074-04-01";
            DateTime eDate = new DateTime(2017, 07, 16);

            var res = NepaliCalendar.Convert.ToNepali(eDate);
            Assert.AreEqual(nDate, res);
        }

        [Test]
        public void TestAdd1Month()
        {
            string nDate = "2074-09-02";
            string eDate = "2074-10-02";

            var res = NepaliCalendar.Convert.AddMonths(nDate, 1);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void TestAdd1Month_2()
        {
            string nDate = "2074-07-22";
            string eDate = "2075-12-22";

            var res = NepaliCalendar.Convert.AddMonths(nDate, 17);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void TestAdd24Days_2()
        {
            string nDate = "2074-07-22";
            string eDate = "2074-08-16";

            var res = NepaliCalendar.Convert.AddDays(nDate, 24);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void TestAdd5Month()
        {
            string nDate = "2074-09-02";
            string eDate = "2075-02-02";

            var res = NepaliCalendar.Convert.AddMonths(nDate, 5);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void TestAdd1MonthEOM432()
        {
            string nDate = "2074-04-32";
            string eDate = "2074-05-31";

            var res = NepaliCalendar.Convert.AddMonths(nDate, 1);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void TestAdd3MonthEOM432()
        {
            string nDate = "2074-04-32";
            string eDate = "2074-07-30";

            var res = NepaliCalendar.Convert.AddMonths(nDate, 3);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void Test19750101Eng()
        {
            string nDate = "1975-01-01";
            DateTime eDate = new DateTime(1918, 4, 13);

            var res = NepaliCalendar.Convert.ToEnglish(nDate);
            Assert.AreEqual(res, eDate);
        }
        [Test]
        public void Test1918413Nep()
        {
            string nDate = "1976-01-01";
            DateTime eDate = new DateTime(1919, 4, 13);

            var res = NepaliCalendar.Convert.ToNepali(eDate);
            Assert.AreEqual(res, nDate);
        }
        [Test]
        public void TestEachNewYearNepUpto2000()
        {
            string[] nDate = { "1975-01-01", "1976-01-01", "1977-01-01", "1978-01-01", "1979-01-01", "1980-01-01", "1981-01-01", "1982-01-01", "1983-01-01", "1984-01-01", "1985-01-01", "1986-01-01", "1987-01-01", "1988-01-01", "1989-01-01", "1990-01-01", "1991-01-01", "1992-01-01", "1993-01-01", "1994-01-01", "1995-01-01", "1996-01-01", "1997-01-01", "1998-01-01", "1999-01-01" };
            DateTime[] eDate = { new DateTime(1918, 04, 13), new DateTime(1919, 04, 13), new DateTime(1920, 04, 13), new DateTime(1921, 04, 13), new DateTime(1922, 04, 13), new DateTime(1923, 04, 13), new DateTime(1924, 04, 13), new DateTime(1925, 04, 13), new DateTime(1926, 04, 13), new DateTime(1927, 04, 13), new DateTime(1928, 04, 13), new DateTime(1929, 04, 13), new DateTime(1930, 04, 13), new DateTime(1931, 04, 13), new DateTime(1932, 04, 13), new DateTime(1933, 04, 13), new DateTime(1934, 04, 13), new DateTime(1935, 04, 13), new DateTime(1936, 04, 13), new DateTime(1937, 04, 13), new DateTime(1938, 04, 13), new DateTime(1939, 04, 13), new DateTime(1940, 04, 13), new DateTime(1941, 04, 13), new DateTime(1942, 04, 13) };

            var res = nDate.OfType<string>().ToList().Select(x => NepaliCalendar.Convert.ToEnglish(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], eDate[i]);
            }
            CollectionAssert.AreEqual(res, eDate);
        }
        [Test]
        public void TestEachNewYearEngUpto2000()
        {
            string[] nDate = { "1976-01-01", "1977-01-01", "1978-01-01", "1979-01-01", "1980-01-01", "1981-01-01", "1982-01-01", "1983-01-01", "1984-01-01", "1985-01-01", "1986-01-01", "1987-01-01", "1988-01-01", "1989-01-01", "1990-01-01", "1991-01-01", "1992-01-01", "1993-01-01", "1994-01-01", "1995-01-01", "1996-01-01", "1997-01-01", "1998-01-01", "1999-01-01" };
            DateTime[] eDate = { new DateTime(1919, 04, 13), new DateTime(1920, 04, 13), new DateTime(1921, 04, 13), new DateTime(1922, 04, 13), new DateTime(1923, 04, 13), new DateTime(1924, 04, 13), new DateTime(1925, 04, 13), new DateTime(1926, 04, 13), new DateTime(1927, 04, 13), new DateTime(1928, 04, 13), new DateTime(1929, 04, 13), new DateTime(1930, 04, 13), new DateTime(1931, 04, 13), new DateTime(1932, 04, 13), new DateTime(1933, 04, 13), new DateTime(1934, 04, 13), new DateTime(1935, 04, 13), new DateTime(1936, 04, 13), new DateTime(1937, 04, 13), new DateTime(1938, 04, 13), new DateTime(1939, 04, 13), new DateTime(1940, 04, 13), new DateTime(1941, 04, 13), new DateTime(1942, 04, 13) };

            var res = eDate.OfType<DateTime>().ToList().Select(x => NepaliCalendar.Convert.ToNepali(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], nDate[i]);
            }
            CollectionAssert.AreEqual(res, nDate);
        }
        [Test]
        public void TestNewYearDaysNep()
        {
            string[] nDate = { "2075-04-01", "2076-04-01", "2077-04-01", "2078-04-01", "2079-04-01" };
            DateTime[] eDate = { new DateTime(2018, 07, 17), new DateTime(2019, 07, 17),
            new DateTime(2020, 07, 16), new DateTime(2021, 07, 16) , new DateTime(2022, 07, 17)};

            var res = nDate.OfType<string>().ToList().Select(x => NepaliCalendar.Convert.ToEnglish(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], eDate[i]);
            }
            CollectionAssert.AreEqual(res, eDate);

            //Assert.AreEqual(eDate.ToString("yyyy-MM-dd"), res.ToString("yyyy-MM-dd"));
        }

        [Test]
        public void TestNewYearDaysEng()
        {
            string[] nDate = { "2075-04-01", "2076-04-01", "2077-04-01", "2078-04-01", "2079-04-01" };
            DateTime[] eDate = { new DateTime(2018, 07, 17), new DateTime(2019, 07, 17),
            new DateTime(2020, 07, 16), new DateTime(2021, 07, 16) , new DateTime(2022, 07, 17)};

            var res = eDate.OfType<DateTime>().ToList().Select(x => NepaliCalendar.Convert.ToNepali(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], nDate[i]);
            }
            CollectionAssert.AreEqual(res, nDate);

        }


        [Test]
        public void TestEachNewYearNep2000n2090()
        {
            string[] nDate = { "2000-01-01", "2001-01-01", "2002-01-01", "2003-01-01", "2004-01-01", "2005-01-01", "2006-01-01", "2007-01-01", "2008-01-01", "2009-01-01", "2010-01-01", "2011-01-01", "2012-01-01", "2013-01-01", "2014-01-01", "2015-01-01", "2016-01-01", "2017-01-01", "2018-01-01", "2019-01-01", "2020-01-01", "2021-01-01", "2022-01-01", "2023-01-01", "2024-01-01", "2025-01-01", "2026-01-01", "2027-01-01", "2028-01-01", "2029-01-01", "2030-01-01", "2031-01-01", "2032-01-01", "2033-01-01", "2034-01-01", "2035-01-01", "2036-01-01", "2037-01-01", "2038-01-01", "2039-01-01", "2040-01-01", "2041-01-01", "2042-01-01", "2043-01-01", "2044-01-01", "2045-01-01", "2046-01-01", "2047-01-01", "2048-01-01", "2049-01-01", "2050-01-01", "2051-01-01", "2052-01-01", "2053-01-01", "2054-01-01", "2055-01-01", "2056-01-01", "2057-01-01", "2058-01-01", "2059-01-01", "2060-01-01", "2061-01-01", "2062-01-01", "2063-01-01", "2064-01-01", "2065-01-01", "2066-01-01", "2067-01-01", "2068-01-01", "2069-01-01", "2070-01-01", "2071-01-01", "2072-01-01", "2073-01-01", "2074-01-01", "2075-01-01", "2076-01-01", "2077-01-01", "2078-01-01", "2079-01-01", "2080-01-01", "2081-01-01", "2082-01-01", "2083-01-01", "2084-01-01", "2085-01-01", "2086-01-01", "2087-01-01", "2088-01-01", "2089-01-01", "2090-01-01" };
            DateTime[] eDate = { new DateTime(1943, 04, 14), new DateTime(1944, 04, 13), new DateTime(1945, 04, 13), new DateTime(1946, 04, 13), new DateTime(1947, 04, 14), new DateTime(1948, 04, 13), new DateTime(1949, 04, 13), new DateTime(1950, 04, 13), new DateTime(1951, 04, 14), new DateTime(1952, 04, 13), new DateTime(1953, 04, 13), new DateTime(1954, 04, 13), new DateTime(1955, 04, 14), new DateTime(1956, 04, 13), new DateTime(1957, 04, 13), new DateTime(1958, 04, 13), new DateTime(1959, 04, 14), new DateTime(1960, 04, 13), new DateTime(1961, 04, 13), new DateTime(1962, 04, 13), new DateTime(1963, 04, 14), new DateTime(1964, 04, 13), new DateTime(1965, 04, 13), new DateTime(1966, 04, 13), new DateTime(1967, 04, 14), new DateTime(1968, 04, 13), new DateTime(1969, 04, 13), new DateTime(1970, 04, 14), new DateTime(1971, 04, 14), new DateTime(1972, 04, 13), new DateTime(1973, 04, 13), new DateTime(1974, 04, 14), new DateTime(1975, 04, 14), new DateTime(1976, 04, 13), new DateTime(1977, 04, 13), new DateTime(1978, 04, 14), new DateTime(1979, 04, 14), new DateTime(1980, 04, 13), new DateTime(1981, 04, 13), new DateTime(1982, 04, 14), new DateTime(1983, 04, 14), new DateTime(1984, 04, 13), new DateTime(1985, 04, 13), new DateTime(1986, 04, 14), new DateTime(1987, 04, 14), new DateTime(1988, 04, 13), new DateTime(1989, 04, 13), new DateTime(1990, 04, 14), new DateTime(1991, 04, 14), new DateTime(1992, 04, 13), new DateTime(1993, 04, 13), new DateTime(1994, 04, 14), new DateTime(1995, 04, 14), new DateTime(1996, 04, 13), new DateTime(1997, 04, 13), new DateTime(1998, 04, 14), new DateTime(1999, 04, 14), new DateTime(2000, 04, 13), new DateTime(2001, 04, 14), new DateTime(2002, 04, 14), new DateTime(2003, 04, 14), new DateTime(2004, 04, 13), new DateTime(2005, 04, 14), new DateTime(2006, 04, 14), new DateTime(2007, 04, 14), new DateTime(2008, 04, 13), new DateTime(2009, 04, 14), new DateTime(2010, 04, 14), new DateTime(2011, 04, 14), new DateTime(2012, 04, 13), new DateTime(2013, 04, 14), new DateTime(2014, 04, 14), new DateTime(2015, 04, 14), new DateTime(2016, 04, 13), new DateTime(2017, 04, 14), new DateTime(2018, 04, 14), new DateTime(2019, 04, 14), new DateTime(2020, 04, 13), new DateTime(2021, 04, 14), new DateTime(2022, 04, 14), new DateTime(2023, 04, 14), new DateTime(2024, 04, 13), new DateTime(2025, 04, 14), new DateTime(2026, 04, 14), new DateTime(2027, 04, 14), new DateTime(2028, 04, 14), new DateTime(2029, 04, 14), new DateTime(2030, 04, 14), new DateTime(2031, 04, 14), new DateTime(2032, 04, 14), new DateTime(2033, 04, 14) };

            var res = nDate.OfType<string>().ToList().Select(x => NepaliCalendar.Convert.ToEnglish(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], eDate[i]);
            }
            CollectionAssert.AreEqual(res, eDate);
        }
        [Test]
        public void TestEachNewYearEng2000n2090()
        {
            string[] nDate = { "2001-01-01", "2002-01-01", "2003-01-01", "2004-01-01", "2005-01-01", "2006-01-01", "2007-01-01", "2008-01-01", "2009-01-01", "2010-01-01", "2011-01-01", "2012-01-01", "2013-01-01", "2014-01-01", "2015-01-01", "2016-01-01", "2017-01-01", "2018-01-01", "2019-01-01", "2020-01-01", "2021-01-01", "2022-01-01", "2023-01-01", "2024-01-01", "2025-01-01", "2026-01-01", "2027-01-01", "2028-01-01", "2029-01-01", "2030-01-01", "2031-01-01", "2032-01-01", "2033-01-01", "2034-01-01", "2035-01-01", "2036-01-01", "2037-01-01", "2038-01-01", "2039-01-01", "2040-01-01", "2041-01-01", "2042-01-01", "2043-01-01", "2044-01-01", "2045-01-01", "2046-01-01", "2047-01-01", "2048-01-01", "2049-01-01", "2050-01-01", "2051-01-01", "2052-01-01", "2053-01-01", "2054-01-01", "2055-01-01", "2056-01-01", "2057-01-01", "2058-01-01", "2059-01-01", "2060-01-01", "2061-01-01", "2062-01-01", "2063-01-01", "2064-01-01", "2065-01-01", "2066-01-01", "2067-01-01", "2068-01-01", "2069-01-01", "2070-01-01", "2071-01-01", "2072-01-01", "2073-01-01", "2074-01-01", "2075-01-01", "2076-01-01", "2077-01-01", "2078-01-01", "2079-01-01", "2080-01-01", "2081-01-01", "2082-01-01", "2083-01-01", "2084-01-01", "2085-01-01", "2086-01-01", "2087-01-01", "2088-01-01", "2089-01-01", "2090-01-01" };
            DateTime[] eDate = { new DateTime(1944, 04, 13), new DateTime(1945, 04, 13), new DateTime(1946, 04, 13), new DateTime(1947, 04, 14), new DateTime(1948, 04, 13), new DateTime(1949, 04, 13), new DateTime(1950, 04, 13), new DateTime(1951, 04, 14), new DateTime(1952, 04, 13), new DateTime(1953, 04, 13), new DateTime(1954, 04, 13), new DateTime(1955, 04, 14), new DateTime(1956, 04, 13), new DateTime(1957, 04, 13), new DateTime(1958, 04, 13), new DateTime(1959, 04, 14), new DateTime(1960, 04, 13), new DateTime(1961, 04, 13), new DateTime(1962, 04, 13), new DateTime(1963, 04, 14), new DateTime(1964, 04, 13), new DateTime(1965, 04, 13), new DateTime(1966, 04, 13), new DateTime(1967, 04, 14), new DateTime(1968, 04, 13), new DateTime(1969, 04, 13), new DateTime(1970, 04, 14), new DateTime(1971, 04, 14), new DateTime(1972, 04, 13), new DateTime(1973, 04, 13), new DateTime(1974, 04, 14), new DateTime(1975, 04, 14), new DateTime(1976, 04, 13), new DateTime(1977, 04, 13), new DateTime(1978, 04, 14), new DateTime(1979, 04, 14), new DateTime(1980, 04, 13), new DateTime(1981, 04, 13), new DateTime(1982, 04, 14), new DateTime(1983, 04, 14), new DateTime(1984, 04, 13), new DateTime(1985, 04, 13), new DateTime(1986, 04, 14), new DateTime(1987, 04, 14), new DateTime(1988, 04, 13), new DateTime(1989, 04, 13), new DateTime(1990, 04, 14), new DateTime(1991, 04, 14), new DateTime(1992, 04, 13), new DateTime(1993, 04, 13), new DateTime(1994, 04, 14), new DateTime(1995, 04, 14), new DateTime(1996, 04, 13), new DateTime(1997, 04, 13), new DateTime(1998, 04, 14), new DateTime(1999, 04, 14), new DateTime(2000, 04, 13), new DateTime(2001, 04, 14), new DateTime(2002, 04, 14), new DateTime(2003, 04, 14), new DateTime(2004, 04, 13), new DateTime(2005, 04, 14), new DateTime(2006, 04, 14), new DateTime(2007, 04, 14), new DateTime(2008, 04, 13), new DateTime(2009, 04, 14), new DateTime(2010, 04, 14), new DateTime(2011, 04, 14), new DateTime(2012, 04, 13), new DateTime(2013, 04, 14), new DateTime(2014, 04, 14), new DateTime(2015, 04, 14), new DateTime(2016, 04, 13), new DateTime(2017, 04, 14), new DateTime(2018, 04, 14), new DateTime(2019, 04, 14), new DateTime(2020, 04, 13), new DateTime(2021, 04, 14), new DateTime(2022, 04, 14), new DateTime(2023, 04, 14), new DateTime(2024, 04, 13), new DateTime(2025, 04, 14), new DateTime(2026, 04, 14), new DateTime(2027, 04, 14), new DateTime(2028, 04, 14), new DateTime(2029, 04, 14), new DateTime(2030, 04, 14), new DateTime(2031, 04, 14), new DateTime(2032, 04, 14), new DateTime(2033, 04, 14) };

            var res = eDate.OfType<DateTime>().ToList().Select(x => NepaliCalendar.Convert.ToNepali(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], nDate[i]);
            }
            CollectionAssert.AreEqual(res, nDate);
        }

        [Test]
        public void TestEachNewYearNep2001n2150()
        {
            string[] nDate = { "2091-01-01", "2092-01-01", "2093-01-01", "2094-01-01", "2095-01-01", "2096-01-01", "2097-01-01", "2098-01-01", "2099-01-01", "2100-01-01", "2101-01-01", "2102-01-01", "2103-01-01", "2104-01-01", "2105-01-01", "2106-01-01", "2107-01-01", "2108-01-01", "2109-01-01", "2110-01-01", "2111-01-01", "2112-01-01", "2113-01-01", "2114-01-01", "2115-01-01", "2116-01-01", "2117-01-01", "2118-01-01", "2119-01-01", "2120-01-01", "2121-01-01", "2122-01-01", "2123-01-01", "2124-01-01", "2125-01-01", "2126-01-01", "2127-01-01", "2128-01-01", "2129-01-01", "2130-01-01", "2131-01-01", "2132-01-01", "2133-01-01", "2134-01-01", "2135-01-01", "2136-01-01", "2137-01-01", "2138-01-01", "2139-01-01", "2140-01-01", "2141-01-01", "2142-01-01", "2143-01-01", "2144-01-01", "2145-01-01", "2146-01-01", "2147-01-01", "2148-01-01", "2149-01-01", "2150-01-01" };
            DateTime[] eDate = { new DateTime(2034, 4, 14), new DateTime(2035, 4, 14), new DateTime(2036, 4, 14), new DateTime(2037, 4, 14), new DateTime(2038, 4, 14), new DateTime(2039, 4, 14), new DateTime(2040, 4, 14), new DateTime(2041, 4, 14), new DateTime(2042, 4, 14), new DateTime(2043, 4, 14), new DateTime(2044, 4, 14), new DateTime(2045, 4, 14), new DateTime(2046, 4, 14), new DateTime(2047, 4, 14), new DateTime(2048, 4, 14), new DateTime(2049, 4, 14), new DateTime(2050, 4, 14), new DateTime(2051, 4, 14), new DateTime(2052, 4, 14), new DateTime(2053, 4, 14), new DateTime(2054, 4, 14), new DateTime(2055, 4, 14), new DateTime(2056, 4, 14), new DateTime(2057, 4, 14), new DateTime(2058, 4, 14), new DateTime(2059, 4, 15), new DateTime(2060, 4, 14), new DateTime(2061, 4, 14), new DateTime(2062, 4, 14), new DateTime(2063, 4, 15), new DateTime(2064, 4, 14), new DateTime(2065, 4, 14), new DateTime(2066, 4, 14), new DateTime(2067, 4, 15), new DateTime(2068, 4, 14), new DateTime(2069, 4, 14), new DateTime(2070, 4, 14), new DateTime(2071, 4, 15), new DateTime(2072, 4, 14), new DateTime(2073, 4, 14), new DateTime(2074, 4, 14), new DateTime(2075, 4, 15), new DateTime(2076, 4, 14), new DateTime(2077, 4, 14), new DateTime(2078, 4, 14), new DateTime(2079, 4, 15), new DateTime(2080, 4, 14), new DateTime(2081, 4, 14), new DateTime(2082, 4, 14), new DateTime(2083, 4, 15), new DateTime(2084, 4, 14), new DateTime(2085, 4, 14), new DateTime(2086, 4, 15), new DateTime(2087, 4, 15), new DateTime(2088, 4, 14), new DateTime(2089, 4, 14), new DateTime(2090, 4, 15), new DateTime(2091, 4, 15), new DateTime(2092, 4, 14), new DateTime(2093, 4, 14) };

            var res = nDate.OfType<string>().ToList().Select(x => NepaliCalendar.Convert.ToEnglish(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], eDate[i]);
            }
            CollectionAssert.AreEqual(res, eDate);
        }
        [Test]
        public void TestEachNewYearEng2001n2150()
        {
            string[] nDate = { "2091-01-01", "2092-01-01", "2093-01-01", "2094-01-01", "2095-01-01", "2096-01-01", "2097-01-01", "2098-01-01", "2099-01-01", "2100-01-01", "2101-01-01", "2102-01-01", "2103-01-01", "2104-01-01", "2105-01-01", "2106-01-01", "2107-01-01", "2108-01-01", "2109-01-01", "2110-01-01", "2111-01-01", "2112-01-01", "2113-01-01", "2114-01-01", "2115-01-01", "2116-01-01", "2117-01-01", "2118-01-01", "2119-01-01", "2120-01-01", "2121-01-01", "2122-01-01", "2123-01-01", "2124-01-01", "2125-01-01", "2126-01-01", "2127-01-01", "2128-01-01", "2129-01-01", "2130-01-01", "2131-01-01", "2132-01-01", "2133-01-01", "2134-01-01", "2135-01-01", "2136-01-01", "2137-01-01", "2138-01-01", "2139-01-01", "2140-01-01", "2141-01-01", "2142-01-01", "2143-01-01", "2144-01-01", "2145-01-01", "2146-01-01", "2147-01-01", "2148-01-01", "2149-01-01", "2150-01-01" };
            DateTime[] eDate = { new DateTime(2034, 4, 14), new DateTime(2035, 4, 14), new DateTime(2036, 4, 14), new DateTime(2037, 4, 14), new DateTime(2038, 4, 14), new DateTime(2039, 4, 14), new DateTime(2040, 4, 14), new DateTime(2041, 4, 14), new DateTime(2042, 4, 14), new DateTime(2043, 4, 14), new DateTime(2044, 4, 14), new DateTime(2045, 4, 14), new DateTime(2046, 4, 14), new DateTime(2047, 4, 14), new DateTime(2048, 4, 14), new DateTime(2049, 4, 14), new DateTime(2050, 4, 14), new DateTime(2051, 4, 14), new DateTime(2052, 4, 14), new DateTime(2053, 4, 14), new DateTime(2054, 4, 14), new DateTime(2055, 4, 14), new DateTime(2056, 4, 14), new DateTime(2057, 4, 14), new DateTime(2058, 4, 14), new DateTime(2059, 4, 15), new DateTime(2060, 4, 14), new DateTime(2061, 4, 14), new DateTime(2062, 4, 14), new DateTime(2063, 4, 15), new DateTime(2064, 4, 14), new DateTime(2065, 4, 14), new DateTime(2066, 4, 14), new DateTime(2067, 4, 15), new DateTime(2068, 4, 14), new DateTime(2069, 4, 14), new DateTime(2070, 4, 14), new DateTime(2071, 4, 15), new DateTime(2072, 4, 14), new DateTime(2073, 4, 14), new DateTime(2074, 4, 14), new DateTime(2075, 4, 15), new DateTime(2076, 4, 14), new DateTime(2077, 4, 14), new DateTime(2078, 4, 14), new DateTime(2079, 4, 15), new DateTime(2080, 4, 14), new DateTime(2081, 4, 14), new DateTime(2082, 4, 14), new DateTime(2083, 4, 15), new DateTime(2084, 4, 14), new DateTime(2085, 4, 14), new DateTime(2086, 4, 15), new DateTime(2087, 4, 15), new DateTime(2088, 4, 14), new DateTime(2089, 4, 14), new DateTime(2090, 4, 15), new DateTime(2091, 4, 15), new DateTime(2092, 4, 14), new DateTime(2093, 4, 14) };

            var res = eDate.OfType<DateTime>().ToList().Select(x => NepaliCalendar.Convert.ToNepali(x)).ToArray();
            for (var i = 0; i < nDate.Length; i++)
            {
                Assert.AreEqual(res[i], nDate[i]);
            }
            CollectionAssert.AreEqual(res, nDate);
        }

        #region Get Month Day Count
        [Test]
        public void TestMonthDayCount0()
        {
            string nDate = "2074-01-02";
            int dCount = 31;

            var res = NepaliCalendar.Convert.GetMonthDayCount(nDate);
            Assert.AreEqual(res, dCount);
        }
        [Test]
        public void TestMonthDayCount()
        {
            string nDate = "2074-09-02";
            int dCount = 30;

            var res = NepaliCalendar.Convert.GetMonthDayCount(nDate);
            Assert.AreEqual(res, dCount);
        }
        [Test]
        public void TestMonthDayCount1()
        {
            string nDate = "2074-10-02";
            int dCount = 29;

            var res = NepaliCalendar.Convert.GetMonthDayCount(nDate);
            Assert.AreEqual(res, dCount);
        }
        [Test]
        public void TestMonthDayCount2()
        {
            string nDate = "2074-12-02";
            int dCount = 30;

            var res = NepaliCalendar.Convert.GetMonthDayCount(nDate);
            Assert.AreEqual(res, dCount);
        }
        #endregion
    }
}