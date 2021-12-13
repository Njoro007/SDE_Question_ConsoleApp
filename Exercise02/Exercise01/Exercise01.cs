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


        public static string Towards(this int i, int DescribeInteger)
        {
            try
            {
                Int64 amount_int = (Int64)DescribeInteger;
                //Int64 amount_dec = (Int64)Math.Round((DescribeInteger - (double)(amount_int)) * 100);
                //if (amount_dec == 0)
                //{
                return Convert(amount_int) + " Only.";
                //}
                //else
                //{
                //    return Convert(amount_int) + " Point " + Convert(amount_dec) + " Only.";
                //}
            }
            catch (Exception ex)
            {
                return "Error Failed to Describe " + ex.Message;
            }
        }



        public static string Convert(Int64 i)
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
            if (i < 10000000)
            {
                return Convert(i / 10000) + " Million " + ((i % 10000 > 0) ? " " + Convert(i % 10000) : "");
            }
            if (i < 1000000000)
            {
                return Convert(i / 10000000) + " Crore " + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");
            }

            return Convert(i / 1000000000) + " Arab " + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
        }


    }
}
