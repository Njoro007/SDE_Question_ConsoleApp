using System;
using Exercise01;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine + "Enter Integer to Describer");
            var Value = Console.ReadLine();
            try
            {
                long ConvertedToInt = Convert.ToInt64(Value);

                long j = new long();
                var describedInteger = j.Towards(ConvertedToInt);

                Console.WriteLine(describedInteger);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Values Entered should be Numbers only! "+ex.Message);
            }
            finally
            {
                Main(args);
            }
        }
    }
}
