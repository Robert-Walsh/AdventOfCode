using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Days;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day Number: ");
            var userInput = Console.Read();

            RunDay(userInput);
        }

        public static void RunDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case '1':
                    Day1 day1 = new Day1();
                    day1.Run();
                    break;

                case '2':
                    Day2 day2 = new Day2();
                    day2.Run();
                    break;

                case '3':
                    Day3 day3 = new Day3();
                    day3.Run();
                    break;

                case '6':
                    Day6 day6 = new Day6();
                    day6.Run();
                    break;

                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
        }
    }
}
