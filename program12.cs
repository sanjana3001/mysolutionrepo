using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program12
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("while loop");
            while (i < 11)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("for loop");
            for(i=0;i<11;i++)
                Console.Write($"{i} ");

            Console.WriteLine("\n==================");
            Console.WriteLine("do while loop");
            i = 1;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i < 11);
        }
    }
}
