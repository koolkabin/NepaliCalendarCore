Package for conversion between AD to BS too and fro!
----------------------------
Also consists functions for conversion of Number to words function in nepali unicode!
----------------------------
1. Quick Current Nepali Date
	Console.WriteLine($"Lets Convert {DateTime.Now.ToString()} to {NepaliCalendar.Convert.Now}");

2. Quick Convert AD to BS
            DateTime EngDate1 = DateTime.Now.AddMonths(-1);
            Console.WriteLine($"Lets Convert {EngDate1.ToString()} to {NepaliCalendar.Convert.ToNepali(EngDate1)}");

3. Quick BS to AD
            string NepDate1 = "2078-04-01";
            Console.WriteLine($"Lets Convert {NepaliCalendar.Convert.ToEnglish(NepDate1).ToString()} to {NepDate1}");


4. Cool MonthInfo Feature with start date, end date, total days, and recursive next and prev monthinfo

            MonthInfo m = new MonthInfo(NepaliCalendar.Convert.Now);
            Console.WriteLine($"Printing Current Month Info");
            Console.WriteLine("----------------------------");
            PrintMonthInfo(m);
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Printing Last Month Info");
            Console.WriteLine("----------------------------");
            PrintMonthInfo(m.PrevMonth());
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Printing Next Month Info");
            Console.WriteLine("----------------------------");
            PrintMonthInfo(m.NextMonth());
            Console.WriteLine("----------------------------");

Function Defination for sample usage
        static void PrintMonthInfo(MonthInfo m)
        {
            Console.WriteLine($"Month Info: {m.ToString()}");
            Console.WriteLine($"Total Days: {m.days} End Date: {m.EndDateNep}");
            Console.WriteLine($"Start Date in Eng: {m.StartDate.ToString()} End Date in Eng: {m.EndDate.ToString()}");
        }
