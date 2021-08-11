using System;

namespace ConsoleApp2
{
    class Program11
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12) Console.WriteLine("Good Morning!");
            else if(hour<16) Console.WriteLine("Good afternoon!");
            else Console.WriteLine("Good Evening!");


            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
            if (day == "sat" || day == "sun")
                Console.WriteLine("TOday is weekend");
            else Console.WriteLine(" weekday");

            Console.WriteLine("Hello World!");
        }
    }
}
