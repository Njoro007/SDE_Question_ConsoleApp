using System;

namespace Exercise01
{
    public static class Exercise01
    {
        private static String[] units = { "Zero", "One", "Two", "Three",
            "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
            "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen" };

        private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public static string Towards(this long i, long DescribeInteger)
        {
            try
            {
                Int64 amount_int = (Int64)DescribeInteger;
                return Convert(amount_int);
            }
            catch (Exception ex)
            {
                return "Error Failed to Describe " + ex.Message;
            }
        }



        public static string Convert(long i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
            }
            if (i < 1000)
            {
                return units[i / 100] + " Hundred" + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
            }
            if (i < 100000)
            {
                return Convert(i / 1000) + " Thousand " + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
            }
            if (i < 1000000)
            {
                return Convert(i / 100000) + " Hundred " + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "Thousand");
            }
            if (i < 10000000)
            {
                return Convert(i / 1000000) + " Million " + ((i % 1000000 > 0) ? " " + Convert(i % 1000000) : "");
            }
            if (i < 100000000)
            {
                return Convert(i / 10000000) + " Hundred And" + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");
            }

            return Convert(i / 1000000000) + "  " + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
        }


    }
}
