using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    class Day2
    {
        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\rwalsh\Documents\Playarounds\input.txt");

            List<int[]> parsedData = ParseFile(lines);

            var totalPaper = CalculatePaperNeeded(parsedData);
            var totalRibbon = CalculateRibbonNeeded(parsedData);

            Console.WriteLine(totalPaper);
            Console.WriteLine(totalRibbon);
            Console.ReadKey();
        }

        private static List<int[]> ParseFile(string[] data)
        {
            List<int[]> parsedData = new List<int[]>();

            foreach (string line in data)
            {
                string[] args = line.Split('x');
                int length = Int32.Parse(args[0]);
                int height = Int32.Parse(args[1]);
                int width = Int32.Parse(args[2]);

                parsedData.Add(new[] { length, height, width });
            }

            return parsedData;
        }

        private static int CalculatePaperNeeded(List<int[]> parsedData)
        {
            int totalPaper = 0;

            foreach (var i in parsedData)
            {
                totalPaper += CalculateArea(i);
                totalPaper += CalculateSlack(i);
            }

            return totalPaper;
        }

        private static int CalculateRibbonNeeded(List<int[]> parsedData)
        {
            int totalPaper = 0;

            foreach (var i in parsedData)
            {
                totalPaper += CalculateRibbonLength(i);
                totalPaper += CalculateBowLength(i);
            }

            return totalPaper;
        }


        private static int CalculateArea(int[] dimensions)
        {
            var length = dimensions[0];
            var width = dimensions[1];
            var height = dimensions[2];

            int area = (2 * length * width) + (2 * width * height) + (2 * height * length);

            return area;
        }

        private static int CalculateSlack(int[] dimensions)
        {
            var length = dimensions[0];
            var width = dimensions[1];
            var height = dimensions[2];

            int side1 = length * height;
            int side2 = length * width;
            int side3 = height * width;

            return new[] { side1, side2, side3 }.Min();

        }

        private static int CalculateRibbonLength(int[] dimensions)
        {
            var length = dimensions[0];
            var width = dimensions[1];
            var height = dimensions[2];

            var ribbonLength = 2 * (length + width + height - new[] { length, width, height }.Max());
            return ribbonLength;
        }

        private static int CalculateBowLength(int[] dimensions)
        {
            var length = dimensions[0];
            var width = dimensions[1];
            var height = dimensions[2];

            return length * width * height;
        }
    }
}
