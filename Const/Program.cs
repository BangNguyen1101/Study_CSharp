using System;

namespace Const
{
    internal class Program
    {
        // Constants as a fields
        const double PI = 3.14159;
        const int NumberOfWeeksInYear = 52;
        const int NumberOfMonthsInYear = 12;
        const string MyBirthDay = "2000-11-11";
        public static void Main(string[] args)
        {
            double radius = 10;
            Console.WriteLine("My birthday is {0}", MyBirthDay);
            Console.WriteLine(radius * radius * PI);
            Console.ReadKey();
        }

    }
}
