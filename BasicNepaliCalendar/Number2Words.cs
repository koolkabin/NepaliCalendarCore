using System;

namespace NepaliCalendar
{
    public static class Number2Words
    {
        private static string[] units = { "सुन्य", "एक", "दुई", "तीन", "चार", "पाँच", "छ", "सात", "आठ", "नौ", "दस" };
        private static string[] teens = { "सुन्य", "एक", "दुई", "तीन", "चार", "पाँच", "छ", "सात", "आठ", "नौ", "दस", "एघार", "बाह्र", "तेह्र", "चौध", "पन्ध्र", "सोह्र", "सत्र", "अठाह्र", "उन्नाइस", "बीस", "एकाइस", "बाइस", "तेइस", "चौबीस", "पचीस", "छब्बीस", "सत्ताइस", "अठ्ठाइस", "उनन्तीस", "तीस", "एकतीस", "बतीस", "तेतीस", "चौतीस", "पैतीस", "छतीस", "सरतीस", "अरतीस", "उननचालीस", "चालीस", "एकचालीस", "बयालिस", "तीरचालीस", "चौवालिस", "पैंतालिस", "छयालिस", "सरचालीस", "अरचालीस", "उननचास", "पचास", "एकाउन्न", "बाउन्न", "त्रिपन्न", "चौवन्न", "पच्पन्न", "छपन्न", "सन्ताउन्न", "अन्ठाउँन्न", "उनान्न्साठी ", "साठी", "एकसाठी", "बासाठी", "तीरसाठी", "चौंसाठी", "पैसाठी", "छैसठी", "सत्सठ्ठी", "अर्सठ्ठी", "उनन्सत्तरी", "सतरी", "एकहत्तर", "बहत्तर", "त्रिहत्तर", "चौहत्तर", "पचहत्तर", "छहत्तर", "सत्हत्तर", "अठ्हत्तर", "उनास्सी", "अस्सी", "एकासी", "बयासी", "त्रीयासी", "चौरासी", "पचासी", "छयासी", "सतासी", "अठासी", "उनान्नब्बे", "नब्बे", "एकान्नब्बे", "बयान्नब्बे", "त्रियान्नब्बे", "चौरान्नब्बे", "पंचान्नब्बे", "छयान्नब्बे", "सन्तान्‍नब्बे", "अन्ठान्नब्बे", "उनान्सय" };
        private static string[] tens = { "", "दस", "बीस", "तीस", "चालीस", "पचास", "साठी", "सतरी", "अस्सी", "नब्बे" };
        private static String[] units_eng = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
        private static String[] tens_eng = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public static String ConvertAmountUniCode(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return (ConvertUniCode(amount_int) + " रुपैंया मात्र").Replace("  ", " ");
                }
                else
                {
                    return (ConvertUniCode(amount_int) + " रुपैंया " + ConvertUniCode(amount_dec) + " पैसा मात्र").Replace("  ", " ");
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }
        public static String ConvertUniCode(Int64 i)
        {
            if (i < 100)
            {
                return teens[i];
            }
            //if (i < 100)
            //{
            //    return tens[i / 10] + ((i % 10 > 0) ? " " + ConvertUniCode(i % 10) : "");
            //}
            if (i < 1000)
            {
                return units[i / 100] + " सय "
                        + ((i % 100 > 0) ? ConvertUniCode(i % 100) : "");
            }
            if (i < 100000)
            {
                return ConvertUniCode(i / 1000) + " हजार "
                + ((i % 1000 > 0) ? " " + ConvertUniCode(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return ConvertUniCode(i / 100000) + " लाख "
                        + ((i % 100000 > 0) ? " " + ConvertUniCode(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return ConvertUniCode(i / 10000000) + " करोड "
                        + ((i % 10000000 > 0) ? " " + ConvertUniCode(i % 10000000) : "");
            }
            if (i < 100000000000)
            {
                return ConvertUniCode(i / 1000000000) + " अरब "
                        + ((i % 1000000000 > 0) ? " " + ConvertUniCode(i % 1000000000) : "");
            }
            return ConvertUniCode(i / 100000000000) + " खरब "
                    + ((i % 100000000000 > 0) ? " " + ConvertUniCode(i % 100000000000) : "");
        }
        #region "English"

        public static String ConvertAmount(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return Convert(amount_int) + " Only.";
                }
                else
                {
                    return Convert(amount_int) + " Point " + Convert(amount_dec) + " Only.";
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }

        public static String Convert(Int64 i)
        {
            if (i < 20)
            {
                return units_eng[i];
            }
            if (i < 100)
            {
                return tens_eng[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
            }
            if (i < 1000)
            {
                return units_eng[i / 100] + " Hundred"
                        + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
            }
            if (i < 100000)
            {
                return Convert(i / 1000) + " Thousand "
                + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return Convert(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return Convert(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");
            }
            if (i < 100000000000)
            {
                return Convert(i / 1000000000) + " Arab "
                        + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
            }
            return Convert(i / 100000000000) + " Kharab "
                    + ((i % 100000000000 > 0) ? " " + Convert(i % 100000000000) : "");
        }
        #endregion

    }
}
