using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    class Day5
    {
        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\rwalsh\Documents\Playarounds\day5.txt");

            string[] bannedSubstrings = { "ab", "cd", "pq", "xy" };

            Console.WriteLine(ParseData(lines, bannedSubstrings));
            Console.ReadKey();
        }

        private int ParseData(string[] lines, string[] bannedSubstrings)
        {
            int count = lines.Count(_string => ThreeVowelsRuleCheck(_string) && TwiceInARowCheck(_string) && BannedSubstringsCheck(_string, bannedSubstrings));


            return count;
        }

        private bool ThreeVowelsRuleCheck(string _string)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;


            foreach (char c in _string)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count >= 3;
        }

        private bool TwiceInARowCheck(string _string)
        {
            for (int i = 0; i < _string.Length; i++)
            {
                if (i != _string.Length - 1)
                {
                    if (_string[i] == _string[i + 1])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool BannedSubstringsCheck(string _string, string[] bannedSubStrings)
        {
            foreach (var substring in bannedSubStrings)
            {
                if (_string.Contains(substring))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
