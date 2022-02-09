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
            RandomNum();
        }

        private static void RandomNum()
        {
            Random randomNum = new Random();

            Console.WriteLine("\nRandom Number Generator\n");

            for (int i = 0; i<20; i++)
            {
                Console.WriteLine($"Number {i} is: {randomNum.Next(1,101)}" );
            }
        }

        static double InputFromUser()
        {
            double numDou = 0;
            bool parseIndicator = false;

            while(parseIndicator == false)
            {
                Console.Write("Enter a any number with decimals : ");
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
            Console.WriteLine("Round up to nearest Integer by Math.Ceiling : {0}",Math.Ceiling(stdDecimal));
            Console.WriteLine("Round up to nearest 2 Decimal by Math.Round : " + Math.Round(stdDecimal, 2));
            Console.WriteLine("Assigned stdDec to Int numberA = " + numberA);

            Console.Write("Hit any key for next example!");
            Console.ReadKey();
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
