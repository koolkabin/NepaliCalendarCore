using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliCalendar.Utils
{
    public static class Convert
    {
        private static IDictionary<int, int[]> bs;

        private static IDictionary<int, string> months;

        private static int[] GetYears()
        {
            if (bs == null) InitializeData();
            return (int[])bs.Keys;
        }
        public static IDictionary<int, string> GetMonths()
        {
            if (bs == null) InitializeData();
            return months;
        }

        private static void InitializeData()
        {
            bs = new Dictionary<int, int[]>
                     {
                        {0, new int[] {1975, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {1, new int[] {1976, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {2, new int[] {1977, 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31}},
                        {3, new int[] {1978, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {4, new int[] {1979, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {5, new int[] {1980, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {6, new int[] {1981, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {7, new int[] {1982, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {8, new int[] {1983, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {9, new int[] {1984, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {10, new int[] {1985, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {11, new int[] {1986, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {12, new int[] {1987, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {13, new int[] {1988, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {14, new int[] {1989, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {15, new int[] {1990, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {16, new int[] {1991, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {17, new int[] {1992, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {18, new int[] {1993, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {19, new int[] {1994, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {20, new int[] {1995, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {21, new int[] {1996, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {22, new int[] {1997, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {23, new int[] {1998, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {24, new int[] {1999, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {25, new int[] {2000, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {26, new int[] {2001, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {27, new int[] {2002, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {28, new int[] {2003, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {29, new int[] {2004, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {30, new int[] {2005, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {31, new int[] {2006, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {32, new int[] {2007, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {33, new int[] {2008, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {34, new int[] {2009, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {35, new int[] {2010, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {36, new int[] {2011, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {37, new int[] {2012, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {38, new int[] {2013, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {39, new int[] {2014, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {40, new int[] {2015, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {41, new int[] {2016, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {42, new int[] {2017, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {43, new int[] {2018, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {44, new int[] {2019, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {45, new int[] {2020, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {46, new int[] {2021, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {47, new int[] {2022, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {48, new int[] {2023, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {49, new int[] {2024, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {50, new int[] {2025, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {51, new int[] {2026, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {52, new int[] {2027, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {53, new int[] {2028, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {54, new int[] {2029, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}},
                        {55, new int[] {2030, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {56, new int[] {2031, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {57, new int[] {2032, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {58, new int[] {2033, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {59, new int[] {2034, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {60, new int[] {2035, 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {61, new int[] {2036, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {62, new int[] {2037, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {63, new int[] {2038, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {64, new int[] {2039, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {65, new int[] {2040, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {66, new int[] {2041, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {67, new int[] {2042, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {68, new int[] {2043, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {69, new int[] {2044, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {70, new int[] {2045, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {71, new int[] {2046, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {72, new int[] {2047, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {73, new int[] {2048, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {74, new int[] {2049, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {75, new int[] {2050, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {76, new int[] {2051, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {77, new int[] {2052, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {78, new int[] {2053, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {79, new int[] {2054, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {80, new int[] {2055, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {81, new int[] {2056, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}},
                        {82, new int[] {2057, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {83, new int[] {2058, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {84, new int[] {2059, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {85, new int[] {2060, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {86, new int[] {2061, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {87, new int[] {2062, 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31}},
                        {88, new int[] {2063, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {89, new int[] {2064, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {90, new int[] {2065, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {91, new int[] {2066, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {92, new int[] {2067, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {93, new int[] {2068, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {94, new int[] {2069, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {95, new int[] {2070, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {96, new int[] {2071, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {97, new int[] {2072, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {98, new int[] {2073, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {99, new int[] {2074, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {100, new int[] {2075, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {101, new int[] {2076, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {102, new int[] {2077, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {103, new int[] {2078, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {104, new int[] {2079, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {105, new int[] {2080, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {106, new int[] {2081, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {107, new int[] {2082, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {108, new int[] {2083, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {109, new int[] {2084, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {110, new int[] {2085, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {111, new int[] {2086, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {112, new int[] {2087, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {113, new int[] {2088, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {114, new int[] {2089, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {115, new int[] {2090, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {116, new int[] {2091, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {117, new int[] {2092, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {118, new int[] {2093, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {119, new int[] {2094, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {120, new int[] {2095, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {121, new int[] {2096, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {122, new int[] {2097, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {123, new int[] {2098, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {124, new int[] {2099, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {125, new int[] {2100, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {126, new int[] {2101, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {127, new int[] {2102, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {128, new int[] {2103, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {129, new int[] {2104, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {130, new int[] {2105, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {131, new int[] {2106, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {132, new int[] {2107, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {133, new int[] {2108, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {134, new int[] {2109, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {135, new int[] {2110, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {136, new int[] {2111, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {137, new int[] {2112, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {138, new int[] {2113, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {139, new int[] {2114, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}},
                        {140, new int[] {2115, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {141, new int[] {2116, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {142, new int[] {2117, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {143, new int[] {2118, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {144, new int[] {2119, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {145, new int[] {2120, 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {146, new int[] {2121, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {147, new int[] {2122, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {148, new int[] {2123, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {149, new int[] {2124, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {150, new int[] {2125, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {151, new int[] {2126, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {152, new int[] {2127, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {153, new int[] {2128, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}},
                        {154, new int[] {2129, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {155, new int[] {2130, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {156, new int[] {2131, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {157, new int[] {2132, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {158, new int[] {2133, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {159, new int[] {2134, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {160, new int[] {2135, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {161, new int[] {2136, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {162, new int[] {2137, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {163, new int[] {2138, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}},
                        {164, new int[] {2139, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {165, new int[] {2140, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {166, new int[] {2141, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}},
                        {167, new int[] {2142, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {168, new int[] {2143, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {169, new int[] {2144, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {170, new int[] {2145, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {171, new int[] {2146, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {172, new int[] {2147, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}},
                        {173, new int[] {2148, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                        {174, new int[] {2149, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}},
                        {175, new int[] {2150, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}},
                        {176, new int[] {2151, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}},
                        {177, new int[] {2152, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}},
                     };

            months = new Dictionary<int, string>();
            months.Add(1, "Baishak");
            months.Add(2, "Jestha");
            months.Add(3, "Ashad");
            months.Add(4, "Shrawn");
            months.Add(5, "Bhadra");
            months.Add(6, "Ashwin");
            months.Add(7, "kartik");
            months.Add(8, "Mangshir");
            months.Add(9, "Poush");
            months.Add(10, "Magh");
            months.Add(11, "Falgun");
            months.Add(12, "Chaitra");

        }

        public static bool IsLeapYear(int year)
        {
            int a = year;
            if (a == 0)
            {
                if (a % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (a % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static string GetMonthName(int m)
        {
            return months[m];
        }

        public static int GetMonthDayCount(string nepDate)
        {

            if (bs == null) { InitializeData(); }
            //2 digit year matching reference to arrray
            NepDate objNepDate = new NepDate(nepDate);
            return GetMonthDayCount(objNepDate.Year, objNepDate.Month);
        }

        /// <summary>
        /// Gets the month day count.
        /// </summary>
        /// <param name="Year">The year.</param>
        /// <param name="Month">The month starting from index 1</param>
        /// <returns></returns>
        public static int GetMonthDayCount(int Year, int Month)
        {
            if (bs == null) { InitializeData(); }
            //2 digit year matching reference to arrray
            //Year = Year % 100;
            Year -= 1975;
            return bs[Year][Month];
        }

        private static string GetDayOfWeek(int d)
        {
            string day = "";
            switch (d)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;
            }
            return day;
        }

        public static bool IsRangeEng(int yy, int mm, int dd)
        {
            //if (yy < 1944 || yy > 2033)
            if (yy < 1919 || yy > 2100)
            {
                //Debug.WriteLine("Supported only between 1944-2022");
                return false;
            }

            if (mm < 1 || mm > 12)
            {
                //Debug.WriteLine("Error! value 1-12 only");
                return false;
            }

            if (dd < 1 || dd > 31)
            {
                //Debug.WriteLine("Error! value 1-31 only");
                return false;
            }

            return true;
        }

        public static bool IsRangeNep(int yy, int mm, int dd)
        {
            if (!IsYearRangeNep(yy))
            {
                return false;
            }
            if (mm < 1 || mm > 12)
            {
                //Debug.WriteLine("Error! value 1-12 only");
                return false;
            }

            if (dd < 1 || dd > GetMonthDayCount(yy, mm))
            {
                //Debug.WriteLine("Error! value 1-31 only");
                return false;
            }
            return true;
        }

        public static bool IsYearRangeNep(int yy)
        {
            if (yy < 1975 || yy > 2150)
            {
                //Debug.WriteLine("Supported only between 2000-2089");
                return false;
            }
            return true;
        }

        public static string ToNepali(DateTime dateTime)
        {
            return ToNepali(dateTime.Year, dateTime.Month, dateTime.Day).ToString();
        }

        public static NepDate ToNepali(int yy, int mm, int dd)
        {
            if (bs == null) InitializeData();
            if (IsRangeEng(yy, mm, dd) == false)
            {
                return null;
            }
            else
            {

                // english month data.
                int[] month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int[] lmonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int def_eyy = 1919;                                 //spear head english date...
                int def_nyy = 1975;
                int def_nmm = 9;
                int def_ndd = 18 - 1;       //spear head nepali date...
                int total_eDays = 0;
                int total_nDays = 0; int a = 0; int day = 7 - 1;        //all the initializations...
                int m = 0; int y = 0; int i = 0; int j = 0;
                int numDay = 0;

                // count total no. of days in-terms of year
                for (i = 0; i < yy - def_eyy; i++)
                {   //total days for month calculation...(english)
                    if (IsLeapYear(def_eyy + i))
                        for (j = 0; j < 12; j++)
                            total_eDays += lmonth[j];
                    else
                        for (j = 0; j < 12; j++)
                            total_eDays += month[j];
                }

                // count total no. of days in-terms of month					
                for (i = 0; i < mm - 1; i++)
                {
                    if (IsLeapYear(yy))
                        total_eDays += lmonth[i];
                    else
                        total_eDays += month[i];
                }

                // count total no. of days in-terms of date
                total_eDays += dd;


                i = 0; j = def_nmm;
                total_nDays = def_ndd;
                m = def_nmm;
                y = def_nyy;

                // count nepali date from array
                while (total_eDays != 0)
                {
                    a = bs[i][j];
                    total_nDays++;                      //count the days
                    day++;                              //count the days interms of 7 days
                    if (total_nDays > a)
                    {
                        m++;
                        total_nDays = 1;
                        j++;
                    }
                    if (day > 7)
                        day = 1;
                    if (m > 12)
                    {
                        y++;
                        m = 1;
                    }
                    if (j > 12)
                    {
                        j = 1; i++;
                    }
                    total_eDays--;
                }

                numDay = day;
                var nepDate = new NepDate();
                nepDate.Year = y;
                nepDate.Month = m;
                nepDate.Day = total_nDays;
                nepDate.WeekDayName = GetDayOfWeek(day);
                nepDate.MonthName = GetMonthName(m);
                nepDate.WeekDay = numDay;
                return nepDate;
            }
        }

        public static DateTime ToEnglish(string uDate)
        {
            return ToEnglish(new NepDate(uDate));
        }
        public static DateTime ToEnglish(NepDate dateTime)
        {
            return ToEnglish(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        public static DateTime ToEnglish(int yy, int mm, int dd)
        {


            if (bs == null) InitializeData();
            int def_eyy = 1918;
            int def_emm = 4;
            int def_edd = 13 - 1;       // init english date.
            int def_nyy = 1975; int def_nmm = 1; int def_ndd = 1;       // equivalent nepali date.
            int total_eDays = 0; int total_nDays = 0; int a = 0; int day = 4 - 1;       // initializations...
            int m = 0; int y = 0; int i = 0;
            int j = 0;
            int k = 0; int numDay = 0;

            int[] month = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] lmonth = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsRangeNep(yy, mm, dd) == false)
            {
                return new DateTime();

            }
            else
            {

                // count total days in-terms of year
                for (i = 0; i < yy - def_nyy; i++)
                {
                    for (j = 1; j <= 12; j++)
                    {
                        total_nDays += bs[k][j];
                    }
                    k++;
                }

                // count total days in-terms of month			
                for (j = 1; j < mm; j++)
                {
                    total_nDays += bs[k][j];
                }

                // count total days in-terms of dat
                total_nDays += dd;

                //calculation of equivalent english date...
                total_eDays = def_edd;
                m = def_emm;
                y = def_eyy;
                while (total_nDays != 0)
                {
                    if (IsLeapYear(y))
                    {
                        a = lmonth[m];
                    }
                    else
                    {
                        a = month[m];
                    }
                    total_eDays++;
                    day++;
                    if (total_eDays > a)
                    {
                        m++;
                        total_eDays = 1;
                        if (m > 12)
                        {
                            y++;
                            m = 1;
                        }
                    }
                    if (day > 7)
                        day = 1;
                    total_nDays--;
                }
                numDay = day;

                var date = new DateTime(y, m, total_eDays);
                return date;

            }
        }

        public static int GetDayCount(string nepStartDate, string nepEndDate)
        {
            var engStartDate = ToEnglish(nepStartDate);
            var engEndDate = ToEnglish(nepEndDate);
            return (engEndDate - engStartDate).Days;
        }

        public static string Now
        {
            get
            {
                return ToNepali(DateTime.Today);
            }
        }

        public static string AddDays(string date, int count)
        {
            var englishdate = ToEnglish(date);
            var addedcountdate = englishdate.AddDays(count);
            return ToNepali(addedcountdate);
        }

        public static int GetMonthCount(string opendate, string maturdate)
        {
            var count = 0;
            NepDate OpenEnglish = new NepDate(opendate);
            NepDate MatureEngish = new NepDate(maturdate);
            if (OpenEnglish.Month > MatureEngish.Month)
            {
                count = (MatureEngish.Year - OpenEnglish.Year) * 12 + OpenEnglish.Month - MatureEngish.Month;
            }
            else
            {
                if (OpenEnglish.Day > MatureEngish.Day)
                {
                    count = (MatureEngish.Year - OpenEnglish.Year) * 12 + MatureEngish.Month - OpenEnglish.Month;

                }
                else
                {
                    count = (MatureEngish.Year - OpenEnglish.Year) * 12 + MatureEngish.Month - OpenEnglish.Month + 1;
                }
            }

            return count;
        }

        public static int AddMonthsAndGetDayCount(string date, int month)
        {
            int count = 0;
            NepDate convertDate = new NepDate(date);
            for (int i = 0; i < month; i++)
            {
                int daycount = GetMonthDayCount(convertDate.Year, convertDate.Month);
                convertDate = new NepDate(AddDays(convertDate.ToString(), daycount));
                count += daycount;
            }
            return count;
        }

        public static int AddYearsAndGetDayCount(string date, int year)
        {
            int count = 0;
            NepDate convertDate = new NepDate(date);
            int month = year * 12;
            for (int i = 0; i < month; i++)
            {
                int daycount = GetMonthDayCount(convertDate.Year, convertDate.Month);
                convertDate = new NepDate(AddDays(convertDate.ToString(), daycount));
                count += daycount;
            }
            return count;
        }

        public static string AddMonths(string date, int month)
        {
            NepDate convertDate = new NepDate(date);

            int div1 = month / 12;
            int rem1 = month % 12;

            convertDate.Month += month;
            div1 = convertDate.Month / 12;
            rem1 = convertDate.Month % 12;
            convertDate.Year += div1;
            if (rem1 == 0)
            {
                convertDate.Month = 12;
                convertDate.Year--;
            }
            else
            {
                convertDate.Month = rem1;
            }

            int prevdaycount = GetMonthDayCount(convertDate.Year, convertDate.Month);
            if (prevdaycount < convertDate.Day)
            {
                convertDate.Day = prevdaycount;
            }
            return convertDate.ToString();



            for (int i = 0; i < month; i++)
            {
                prevdaycount = GetMonthDayCount(convertDate.Year, convertDate.Month);
                NepDate newdate = new NepDate(AddDays(convertDate.ToString(), prevdaycount));
                //return newdate.ToString();
                int nextdaycount = GetMonthDayCount(newdate.Year, newdate.Month);

                if (convertDate.Year - newdate.Year == 0)
                {
                    if (newdate.Month - convertDate.Month == 1)
                    {
                        return newdate.ToString();
                        ///bug
                        //if (newdate.Day == nextdaycount)
                        //{

                        //}
                        //else
                        //{
                        //    int daysdifferent = GetDayCount(newdate.ToString(), convertDate.ToString());
                        //    newdate = new NepDate(Convert.AddDays(convertDate.ToString(), nextdaycount));
                        //}
                        //new geneated date fine
                    }
                    else
                    {

                        //nextdaycount = Convert.GetMonthDayCount(convertDate.Year, convertDate.Month );
                        newdate = new NepDate(AddDays(convertDate.ToString(), nextdaycount));
                    }
                    convertDate = newdate;
                }
                else
                {
                    if (newdate.Day == nextdaycount)
                    {

                    }
                    else
                    {
                        int daysdifferent = GetDayCount(newdate.ToString(), convertDate.ToString());
                        newdate = new NepDate(AddDays(convertDate.ToString(), nextdaycount));
                    }
                    convertDate = newdate;

                }

                //comp

                //vr 2 = var1
            }
            return System.Convert.ToString(convertDate);
        }

        public static string AddMonthsWithTracking(string date, int month)
        {
            NepDate convertDate = new NepDate(date);
            NepDate prevDate = convertDate;
            int TrackingDate = convertDate.Day;
            int prevmaxdate = GetMonthDayCount(prevDate.Year, prevDate.Month);

            bool isTrackingDateIsMaxDate = prevmaxdate == TrackingDate;//
            for (int i = 1; i <= month; i++)
            {
                string strPrevDate = prevDate.ToString();
                NepDate newDate = prevDate;
                newDate.Month += 1;
                newDate.Day = TrackingDate;

                if (newDate.Month > 12)
                {
                    newDate.Month = 1;
                    newDate.Year++;
                }

                if (isTrackingDateIsMaxDate)
                {
                    newDate.Day = GetMonthDayCount(newDate.Year, newDate.Month);//max date of current month
                }

                if (IsRangeNep(newDate.Year, newDate.Month, TrackingDate))
                {
                    //continue
                }
                else
                {
                    newDate.Day = GetMonthDayCount(newDate.Year, newDate.Month);
                }


                int dayCount = GetDayCount(strPrevDate, newDate.ToString());


                ///
                prevDate = newDate;
                //add day
            }
            return System.Convert.ToString(prevDate);
        }

        public static string AddYears(string date, int year)
        {
            int month = year * 12;
            NepDate convertDate = new NepDate(date);
            NepDate prevDate = convertDate;
            int TrackingDate = convertDate.Day;
            int prevmaxdate = GetMonthDayCount(prevDate.Year, prevDate.Month);

            bool isTrackingDateIsMaxDate = prevmaxdate == TrackingDate;//
            for (int i = 1; i <= month; i++)
            {
                string strPrevDate = prevDate.ToString();
                NepDate newDate = prevDate;
                newDate.Month += 1;
                newDate.Day = TrackingDate;

                if (newDate.Month > 12)
                {
                    newDate.Month = 1;
                    newDate.Year++;
                }

                if (isTrackingDateIsMaxDate)
                {
                    newDate.Day = GetMonthDayCount(newDate.Year, newDate.Month);//max date of current month
                }

                if (IsRangeNep(newDate.Year, newDate.Month, TrackingDate))
                {
                    //continue
                }
                else
                {
                    newDate.Day = GetMonthDayCount(newDate.Year, newDate.Month);
                }


                int dayCount = GetDayCount(strPrevDate, newDate.ToString());


                ///
                prevDate = newDate;
                //add day
            }
            return System.Convert.ToString(prevDate);
        }
        public static bool CheckEOM(string nepDate)
        {
            NepDate objNepDate = new NepDate(nepDate);
            int d = objNepDate.Day;
            int TotalDays = GetMonthDayCount(objNepDate.Year, objNepDate.Month);

            return TotalDays == d ? true : false;
        }
        public static bool CheckEOQ(string nepDate)
        {
            NepDate objNepDate = new NepDate(nepDate);
            int M = objNepDate.Month;
            int d = objNepDate.Day;
            int TotalDays = GetMonthDayCount(objNepDate.Year, objNepDate.Month);
            if (d == TotalDays)
            {
                if (M % 3 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckEOH(string nepDate)
        {
            NepDate objNepDate = new NepDate(nepDate);
            int M = objNepDate.Month;
            int d = objNepDate.Day;
            int TotalDays = GetMonthDayCount(objNepDate.Year, objNepDate.Month);
            if (d == TotalDays)
            {
                if ((M + 3) % 6 == 0)
                {
                    return true;
                }
            }


            return false;
        }
        public static bool CheckEOY(string nepDate)
        {
            NepDate objNepDate = new NepDate(nepDate);
            int M = objNepDate.Month;
            int d = objNepDate.Day;
            int TotalDays = GetMonthDayCount(objNepDate.Year, objNepDate.Month);
            if (d == TotalDays)
            {
                if ((M - 3) % 12 == 0)
                {
                    return true;
                }
            }


            return false;
        }
        public static string GetEOMDate(string refDate)
        {
            NepDate x = new NepDate(refDate);
            return GetEOMDate(x.Year, x.Month);
        }
        public static string GetEOMDate(int Years, int Months)
        {
            return string.Format("{0}{1}{2}{1}{3}", Years, "-", Months.ToString().PadLeft(2, '0'), GetMonthDayCount(Years, Months).ToString().PadLeft(2, '0'));
        }

    }
}
