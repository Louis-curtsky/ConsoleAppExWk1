using System;

namespace ConsoleAppExWk1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTimeExp();
            //            int numInt1 = 1/0;
            //            Console.WriteLine("numInt1 = "+numInt1);
            NumExcercise();
        }

        static double InputFromUser()
        {
            double numDou = 0;
            bool parseIndicator = false;

            while(parseIndicator == false)
            {
                Console.Write("Enter a any number : ");
                parseIndicator = double.TryParse(Console.ReadLine(), out numDou);

                if ( ! parseIndicator)
                {
                    Console.WriteLine("Indicator shows "+parseIndicator+" so please enter a valid number");
                }
             
            }

            return numDou;
        }
        private static void NumExcercise()
        {
            Console.WriteLine("\n\nNumber Excercise\n========\n");
            double stdDecimal = InputFromUser();

            int numberA = (int)stdDecimal;

            Console.WriteLine("stdDecimal = " + stdDecimal);
            Console.WriteLine("Round up to nearest Integer by Math.Ceiling : " + Math.Ceiling(stdDecimal));
            Console.WriteLine("Round up to nearest Decimal by Math.Round : " + Math.Round(stdDecimal, 2));
            Console.WriteLine("Assigned stdDec to Int numberA = " + numberA);

        }

        private static void DateTimeExp()
        {
            Console.WriteLine("Date Excercise\n----------\n");
            DateTime currentDateTime = DateTime.Now;
            DateTime mychildDate = DateTime.Parse("2017-08-16");

            Console.WriteLine("Default Current Date and Time : " + currentDateTime);
            Console.WriteLine("And yesterday is : " + currentDateTime.AddDays(-1));

            Console.WriteLine("Date Time Tick from Now, " +  " " + currentDateTime.Ticks);

            Console.WriteLine("She was born in : " + mychildDate.ToShortDateString());
        }
    }
}
