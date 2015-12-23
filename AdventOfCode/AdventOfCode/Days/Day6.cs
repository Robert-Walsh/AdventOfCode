using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    class Day6
    {

        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\rwalsh\Documents\Playarounds\Day6.txt");

           // coordinatesDay6[][] grid = CreateGrid();

            ParseData(lines);
        }

        private void ParseData(string[] data)
        {
            foreach (string line in data)
            {
                string[] args = line.Split(' ');
                String command = args[0];
                Console.WriteLine();
/*                int height = Int32.Parse(args[1]);
                int width = Int32.Parse(args[2]);*/

            }
            Console.ReadKey();
        }

        private coordinatesDay6[][] CreateGrid()
        {
            coordinatesDay6[][] grid = new coordinatesDay6[][]{};

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    grid[i][j] = new coordinatesDay6()
                    {
                        X = i,
                        Y = j
                    };
                }
            }

            return grid;
        }

       

        private void TurnOn(coordinatesDay6 coordinates)
        {
            coordinates.On = true;
        }

        private void TurnOff(coordinatesDay6 coordinates)
        {
            coordinates.On = false;
        }

        private void Toggle(coordinatesDay6 coordinates)
        {
            coordinates.On = !coordinates.On;
        }


    }

    class coordinatesDay6
    {
        public int X;
        public int Y;
        public bool On = false;
    }
}
