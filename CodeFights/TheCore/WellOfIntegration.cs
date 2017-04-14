using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class WellOfIntegration
    {
        public static int threeSplit(int[] a)
        {
            var third = a.Aggregate(0, (b, c) => b + c) / 3;
            var output = 0;
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            for (var x = 0; x < a.Length - 2; x++)
            {
                sum1 += a[x];
                if (third != sum1)
                    continue;

                sum2 = 0;
                for (var y = x + 1; y < a.Length - 1; y++)
                {
                    sum2 += a[y];
                    if (third != sum2)
                        continue;
                    sum3 = a.Where((s, i) => i > y).Aggregate(0, (e, f) => e + f);

                    if (sum3 == third)
                        output++;
                }
            }

            return output;
        }

        public static bool adaNumber(string line)
        {
            if (line.StartsWith("_") | line.EndsWith("_"))
                return false;
            line = line.Replace("_", "").ToLower();
            if (!line.EndsWith("#") | line.StartsWith("#"))
            {
                return line.All(c => "0123456789".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0);
            }
            else
            {
                var bbbbase = 0;

                var splits = line.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                if (splits.Length != 2)
                    return false;

                if (!int.TryParse(splits[0], out bbbbase) || bbbbase < 2 | bbbbase > 16)
                {
                    return false;
                }

                if (
                    splits[1].Any(
                        c =>
                            "0123456789abcdef".Substring(bbbbase)
                                .IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                {
                    return false;
                }

                if (
                    !splits[1].Any(
                        c => "0123456789".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                    return false;
            }
            return true;
        }


        //areSimilar is in ArcadeIntro4

        public static string integerToStringOfFixedWidth(int number, int width)
        {
            return number.ToString().PadLeft(width, '0').Substring(Math.Max(number.ToString().Length - width, 0));
        }

        //electionWinners is in ArcadeIntro10

        public static int timedReading(int maxLength, string text)
        {
            var formattedString = text.Where(c => "abcdefghijklmnopqrstuvwxyz ".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) > -1).Aggregate(string.Empty, (current, c) => current + c);
            return formattedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count(word => word.Length <= maxLength);
        }

        public static int[] switchLights(int[] a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    for (var n = 0; n <= i; n++)
                    {
                        a[n] = a[n] == 0 ? 1 : 0;
                    }
                }
            }
            return a;
        }

        //addBorder is in ArcadeIntro4

        public static int minimalNumberOfCoins(int[] coins, int price)
        {
            var needed = 0;
            var spent = 0;
            while (spent < price)
            {
                spent += coins.Where(n => n <= price - spent).Max();
                needed++;
            }
            return needed;
        }

        public static bool alphabetSubsequence(string s)
        {
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] <= s[i - 1])
                    return false;
            }
            return true;
        }

        public static int[] houseOfCats(int legs)
        {
            var people = new List<int>();
            var peopleCount = 0;

            while (peopleCount <= legs / 2)
            {
                if ((legs - peopleCount * 2) % 4 == 0)
                {
                    people.Add(peopleCount);
                }

                peopleCount++;
            }
            return people.ToArray();
        }


        public static string[] allLongestStrings(string[] inputArray)
        {
            return inputArray.Where(n => n.Length == inputArray.Max(m => m.Length)).ToArray();
        }

        public static int houseNumbersSum(int[] inputArray)
        {
            var sum = 0;
            foreach (var n in inputArray)
            {
                sum += n;
                if (n == 0)
                    break;
            }
            return sum;
        }
    }
}
