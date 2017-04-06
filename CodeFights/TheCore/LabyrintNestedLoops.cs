using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class LabyrintNestedLoops
    {

        public static int crosswordFormation(string[] words)
        {
            var success = 0;
            //    x
            // a    b
            //    y
            for (var x = 0; x < 4; x++)
            {
                for (var y = 0; y < 4; y++)
                {
                    for (var a = 0; a < 4; a++)
                    {
                        for (var b = 0; b < 4; b++)
                        {
                            if (a == b | a == x | a == y |
                                b == x | b == y |
                                x == y)
                                continue;

                            var topWord = words[x];
                            var bottomWord = words[y];
                            var leftWord = words[a];
                            var rightWord = words[b];

                            var yOffset = new[] {leftWord.Length, rightWord.Length}.Max();
                            var xOffset = new[] {topWord.Length, bottomWord.Length}.Max();

                            var topRight = new List<int[]>();
                            for (var c1 = 0; c1 < topWord.Length; c1++)
                            {
                                for (var c2 = 0; c2 < rightWord.Length; c2++)
                                {
                                    if (topWord[c1] == rightWord[c2])
                                        topRight.Add(new[] { c1, c2 });
                                }
                            }
                            if (topRight.Count == 0)
                                continue;

                            var bottomRight = new List<int[]>();
                            for (var c1 = 0; c1 < bottomWord.Length; c1++)
                            {
                                for (var c2 = 0; c2 < rightWord.Length; c2++)
                                {
                                    if (bottomWord[c1] == rightWord[c2])
                                        bottomRight.Add(new[] { c1, c2 });
                                }
                            }
                            if (bottomRight.Count == 0)
                                continue;


                            var bottomLeft = new List<int[]>();
                            for (var c1 = 0; c1 < bottomWord.Length; c1++)
                            {
                                for (var c2 = 0; c2 < leftWord.Length; c2++)
                                {
                                    if (bottomWord[c1] == leftWord[c2])
                                        bottomLeft.Add(new[] { c1, c2 });
                                }
                            }
                            if (bottomLeft.Count == 0)
                                continue;

                            var topLeft = new List<int[]>();
                            for (var c1 = 0; c1 < topWord.Length; c1++)
                            {
                                for (var c2 = 0; c2 < leftWord.Length; c2++)
                                {
                                    if (topWord[c1] == leftWord[c2])
                                        topLeft.Add(new[] { c1, c2 });
                                }
                            }
                            if (topLeft.Count == 0)
                                continue;

                            Debug.WriteLine("Currently there are {0} possibilities", (topLeft.Count * topRight.Count * bottomRight.Count * bottomLeft.Count -3));
                            foreach (var tl in topLeft)
                            {
                                foreach (var tr in topRight)
                                {
                                    foreach (var br in bottomRight)
                                    {
                                        foreach (var bl in bottomLeft)
                                        {
                                            if(bl[0] - tl[0] == br[0] - tr[0] &&
                                                tr[0] - tl[0] == br[0] - bl[0] &&
                                                br[1] - tr[1] == bl[1] - tl[1] &&
                                                tr[1] - tl[1] == br[1] - bl[1]
                                                && tl[0] < tr[0] && tl[1] < bl[1])
                                            //if (xOffset - topWord.Length + tl[0] == xOffset - bottomWord.Length + bl[0] &&
                                            //    xOffset - topWord.Length + tr[0] == xOffset - bottomWord.Length + br[0] &&
                                            //    yOffset - leftWord.Length + tl[1] == yOffset - rightWord.Length + tr[1] &&
                                            //    yOffset - leftWord.Length + bl[1] == yOffset - rightWord.Length + br[1]
                                            //    && tl[0] < tr[0] && tl[1] < bl[1])
                                                success++;
                                        }
                                    }
                                }
                            }




                        }
                    }
                }

            }
            return success;
        }

        public static int rectangleRotation(int a, int b)
        {
            var ret = 0;
            for (var x = -a - b; x <= a + b; x++)
            {
                for (var y = -a - b; y <= a + b; y++)
                {
                    if (2 * (x - y) * (x - y) <= a * a & 2 * (x + y) * (x + y) <= b * b)
                        ret++;
                }
            }
            return ret;
        }


        public static int[] weakNumbers(int n)
        {
            //list of array going [number, divisors, weakness]
            var numbers = new List<int[]>();
            var tempDivisors = 0;
            for (var i = 1; i <= n; i++)
            {
                tempDivisors = 0;
                //find divisors
                for (var d = 1; d <= Math.Sqrt(i); d++)
                {
                    if (i % d != 0) continue;
                    if (i / d == d)
                        tempDivisors++;
                    else
                        tempDivisors += 2;
                }

                numbers.Add(new[] { i, tempDivisors, numbers.Count(a => a[1] > tempDivisors) });
            }
            var max = numbers.Max(b => b[2]);
            return new[] { max, numbers.Count(c => c[2] == max) };
        }

        public static int comfortableNumbers(int L, int R)
        {
            var comfort = 0;

            for (var a = L; a <= R; a++)
            {
                for (var b = a + 1; b <= R; b++)
                {
                    var sumOfDigitsA = a.ToString().ToCharArray().Select(n => int.Parse(n.ToString())).Sum();
                    var sumOfDigitsB = b.ToString().ToCharArray().Select(n => int.Parse(n.ToString())).Sum();
                    var lowerA = a - sumOfDigitsA;
                    var upperA = a + sumOfDigitsA;
                    var lowerB = b - sumOfDigitsB;
                    var upperB = b + sumOfDigitsB;
                    if (b >= lowerA & b <= upperA
                        & a >= lowerB & a <= upperB)
                        comfort++;
                }
            }

            return comfort;
        }

        public static int pagesNumberingWithInk(int current, int numberOfDigits)
        {
            while (numberOfDigits >= 0)
            {
                numberOfDigits -= current.ToString().Length;
                current++;
            }

            return current - 2;

        }


        public static int squareDigitsSequence(int a0)
        {
            var it = 1;
            var results = new List<int>();
            results.Add(a0);
            while (results.GroupBy(b => b).All(c => c.Count() == 1))
            {
                results.Add(
                    results[results.Count - 1].ToString().ToCharArray().Select(c => int.Parse(c.ToString()) * int.Parse(c.ToString())).Sum());
                it++;

            }

            return it;
        }


        public static int isSumOfConsecutive2(int n)
        {
            var temp = 0;
            var output = 0;
            for (var start = 1; start <= n - 1; start++)
            {
                temp = start * 2 + 1;
                for (var i = 2; temp <= n; i++)
                {
                    if (temp == n)
                        output++;

                    temp += start + i;
                }
            }

            return output;
        }


        public static bool isPower(int n)
        {
            if (n <= 1)
                return true;

            for (var a = 2; a <= 350; a++)
            {
                for (var b = 2; b <= 350; b++)
                {

                    if (Math.Pow(a, b) == (double)n)
                        return true;

                    if (Math.Pow(a, b) > n)
                        break;
                }
            }
            return false;
        }

    }
}
