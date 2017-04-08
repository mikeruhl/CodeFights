using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
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

            for (var i1 = 0; i1 < 4; i1++)
            {
                var topWord = words[i1];
                for(var t1 = 0; t1 < topWord.Length; t1++)
                {
                    for (var i2 = 0; i2 < 4; i2++)
                    {
                        if (i1 == i2)
                            continue;
                        var leftWord = words[i2];
                        for (var l1 = 0; l1 < leftWord.Length-2; l1++)
                        {
                            if (topWord[t1] != leftWord[l1])
                                continue;
                            //found one match for left word, now let's find the other.
                            for (var l2 = l1 + 2; l2 < leftWord.Length; l2++)
                            {
                                for (var i3 = 0; i3 < 4; i3++)
                                {
                                    if (i3 == i1 | i3 == i2)
                                        continue;

                                    var bottomWord = words[i3];
                                    var rightWord = words[6 - i1 - i2 - i3];
                                    if (l2 - l1 >= rightWord.Length)
                                        continue;
                                    for(var b1 = 0; b1 < bottomWord.Length-2; b1++)
                                    {
                                        if (leftWord[l2] != bottomWord[b1])
                                            continue;

                                        for(var b2 = b1+2; b2 < bottomWord.Length; b2++)
                                        {
                                            var t2 = t1 + b2 - b1;
                                            if (t2 >= topWord.Length)
                                                continue;

                                            for(var r1 = 0; r1 < rightWord.Length; r1++)
                                            {
                                                if (topWord[t2] != rightWord[r1])
                                                    continue;
                                                var r2 = r1 + l2 - l1;
                                                if (r2 >= rightWord.Length)
                                                    continue;
                                                if (bottomWord[b2] != rightWord[r2])
                                                    continue;

                                                success++;
                                            }
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
