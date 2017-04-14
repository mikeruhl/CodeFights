using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class MirrorLake
    {

        public static int numberOfClans(int[] divisors, int k)
        {
            var clans = new Dictionary<string, int>();
            var allNumbers = Enumerable.Range(1, k).ToDictionary(n=>n, n=>string.Join(",",divisors.Where(m=>n % m == 0).OrderBy(p=>p)));

            foreach (var kvp in allNumbers)
            {
                if (clans.ContainsKey(kvp.Value))
                {
                    clans[kvp.Value]++;
                }
                else
                {
                    clans.Add(kvp.Value, 0);
                }
            }

            return clans.Count;
        }

        public static int mostFrequentDigitSum(int n)
        {
            var sX = new List<int>();

            while (n != 0)
            {
                sX.Add(n.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).Sum());
                n = n - sX[sX.Count-1];
            }

            return sX.GroupBy(x=>x).OrderByDescending(y=>y.Count()).ThenByDescending(z=>z.Key).FirstOrDefault().Key;
        }


        public static int differentSquares(int[][] matrix)
        {
            var diff = 0;
            var squares = new List<int[]>();
            for (var y = 1; y < matrix[0].Length; y++)
            {
                for (var x = 1; x < matrix.Length; x++)
                {
                    if (
                        !squares.Any(
                            q =>
                                q[0] == matrix[x - 1][y - 1] && 
                                q[1] == matrix[x][y - 1] && 
                                q[2] == matrix[x][y] &&
                                q[3] == matrix[x - 1][y]))
                    {
                        squares.Add(new[]
                            {matrix[x - 1][y - 1], matrix[x][y - 1], matrix[x][y], matrix[x - 1][y]});
                    }
                }
            }

            return squares.Count;
        }


        public static int numbersGrouping(int[] a)
        {
            a = a.OrderBy(n => n).ToArray();
            var last = -1.0;
            var current = 0.0;
            var lines = 0;

            foreach (var n in a)
            {
                current = Math.Max(Math.Ceiling(n / 10000.00), 1);
                if (current != last)
                    lines++;
                lines++;
                last = current;
            }

            return lines;

            //Below executes too long but is prettier code.
            //return a.GroupBy(n => Math.Max(Math.Ceiling(n / 10000.00), 1))
            //    .Select(n=>n.Count()+1).Sum();
        }

        public static int constructSquare(string s)
        {
            var minNumber = (int)Math.Min(double.Parse(new string('9', s.Length)), int.MaxValue) / 10;
            var topNumber = (int)Math.Min(double.Parse(new string('9', s.Length)), int.MaxValue);

            var counts = s.GroupBy(c => c).GroupBy(c => c.Count()).ToDictionary(d => d.Key, d => d.Count());

            var currentSquare = (int)Math.Floor(Math.Sqrt(topNumber));

            var satisfiesAll = false;
            while (!satisfiesAll)
            {
                topNumber = currentSquare * currentSquare;
                var topString = topNumber.ToString()
                    .GroupBy(c => c)
                    .GroupBy(c => c.Count())
                    .ToDictionary(d => d.Key, d => d.Count());
                satisfiesAll = counts.All(kvp => topString.ContainsKey(kvp.Key) && topString[kvp.Key] == kvp.Value);

                if (topNumber < minNumber)
                    return -1;
                currentSquare--;
            }

            return topNumber;
        }

        public static int createAnagram(string s, string t)
        {
            var additions = 0;

            var tGroup = t.GroupBy(c => c).ToDictionary(d => d.Key, d => d.Count());
            var sGroup = s.GroupBy(c => c).ToDictionary(d => d.Key, d => d.Count());
            foreach (var kvp in tGroup)
            {
                if (!sGroup.ContainsKey(kvp.Key))
                {
                    sGroup.Add(kvp.Key, kvp.Value);
                    additions += kvp.Value;
                }
                else if (sGroup[kvp.Key] < kvp.Value)
                {
                    additions += kvp.Value - sGroup[kvp.Key];
                }

            }

            return additions;
        }

        public static bool isSubstitutionCipher(string string1, string string2)
        {
            var cipher = new Dictionary<char, char>();
            for (var i = 0; i < string1.Length; i++)
            {
                if (!cipher.ContainsKey(string1[i]))
                {
                    cipher.Add(string1[i], string2[i]);
                }
                else
                {
                    if (cipher[string1[i]] != string2[i] | cipher.GroupBy(b => b.Value).Max(d => d.Count()) > 1)
                        return false;
                }

            }
            return true;
        }

        public static int stringsConstruction(string A, string B)
        {
            var bList = B.ToCharArray().ToList();
            var finds = 0;
            var found = true;
            while (found)
            {

                foreach (var c in A)
                {
                    var i = bList.IndexOf(c);
                    if (i == -1)
                    {
                        found = false;
                        break;
                    }
                    bList.RemoveAt(i);
                }
                if (found)
                    finds++;
            }

            return finds;
        }

    }
}
