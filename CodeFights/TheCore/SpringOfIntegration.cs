using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class SpringOfIntegration
    {

        //fileNaming is in ArcadeIntro12

        public static string[] christmasTree(int levelNum, int levelHeight)
        {
            var sb = new List<string>();
            var max = 5 + (levelHeight - 1) * 2 + (levelNum - 1) * 2;
            var middle = max / 2 + max % 2;

            for (var x = 0; x < 2; x++)
            {
                sb.Add(new string(' ', middle-1) + "*");
            }
            sb.Add(new string(' ', middle-2) + "***");
            for (var i = 0; i < levelNum; i++)
            {
                for (var j = 0; j < levelHeight; j++)
                {
                    sb.Add(new string(' ', middle - j - i - 3) + new string('*', 5 + j * 2 + i*2));
                }
            }

            var add = levelHeight % 2 == 0;
            for (var i = 0; i < levelNum; i++)
            {
                sb.Add(new string(' ', max / 2 + max % 2 - levelHeight / 2 - levelHeight % 2 - (add ? 1 : 0)) 
                    + new string('*', levelHeight + (add ? 1 : 0)));
            }
            return sb.ToArray();
        }

        public static int runnersMeetings(int[] startPosition, int[] speed)
        {
            var retVal = 1;
            var len = startPosition.Length;
            for (var x = 0; x < len; x++)
            {
                for (var y = x + 1; y < len; y++)
                {
                    var distDiff = startPosition[y] - startPosition[x];
                    var speedDiff = speed[x] - speed[y];
                       var sum = 0;
                    if (speedDiff == 0 && distDiff != 0)
                        continue;
                    for (var z = 0; z < len; z++)
                    {
                        if (startPosition[z] * speedDiff + speed[z] * distDiff
                            == startPosition[x] * speedDiff + speed[x] * distDiff)
                        {
                            sum++;
                        }
                    }
                    if (sum > retVal)
                    {
                        retVal = sum;
                    }
                }
            }
            return retVal == 1 ? -1 : retVal;


        }

        public static bool beautifulText(string inputString, int l, int r)
        {
            var splits = inputString.Split(' ');

            for (var len = l; len <= r; len++)
            {
                var tot = 0;
                foreach (var s in splits)
                {
                    if (tot > 0)
                        tot += s.Length + 1;
                    else
                        tot += s.Length;

                    if (tot > r)
                        break;

                    if (tot == len)
                        tot = 0;
                }
                if(tot == 0)
                return true;
            }
            return false;
        }


        public static int cyclicString(string s)
        {
            var b = string.Empty;
            
           for(var len = 1; len <= s.Length; len++)
           {
               var repeats = true;
                b= s.Substring(0, len);
                for (var i = b.Length; i < s.Length; i++)
                {
                    if (b[i % b.Length] != s[i])
                    {
                        repeats = false;
                        break;
                    }
                }
               if (repeats)
                   break;
           }
            return b.Length;
        }

        public static int stringsCrossover(string[] inputArray, string result)
        {
            var poss = 0;
            for (var x = 0; x < inputArray.Length - 1; x++)
            {
                var a = inputArray[x];
                for (var y = x + 1; y < inputArray.Length; y++)
                {
                    var b = inputArray[y];
                    var nope = false;
                    for (var c = 0; c < result.Length; c++)
                    {

                        if (a[c] != result[c] && b[c] != result[c])
                        {
                            nope = true;
                            break;
                        }
                    }
                    if (!nope)
                        poss++;
                }

            }
            return poss;
        }

        public static int combs(string comb1, string comb2)
        {
            var smGap = comb1.Length + comb2.Length;
            var smallest = smGap;
            var offSet = 1;
            var comb2Pad = new string('.', comb1.Length) + comb2 + new string('.', comb1.Length);
            while (offSet != smGap)
            {
                var fit = true;
                var comb1Pad = new string('.', offSet) + comb1;
                for (var i = 0; i < comb1Pad.Length; i++)
                {
                    if (comb1Pad[i] == '*' & comb2Pad[i] == '*')
                    {
                        fit = false;
                        break;
                    }
                }
                if (fit)
                {
                    var totalLength = smGap;
                    if (comb1Pad.Length > smGap)
                    {
                        totalLength = comb2.Length + comb1Pad.Length - smGap;
                    }
                    else
                    {
                        totalLength = comb2.Length + comb1.Length - offSet;
                    }
                    totalLength = Math.Max(comb1.Length, Math.Max(comb2.Length, totalLength));
                    if (smallest > totalLength)
                        smallest = totalLength;
                }
                offSet++;
            }

            return smallest;

        }


        public static bool pairOfShoes(int[][] shoes)
        {
            var pairs = shoes.GroupBy(f => f[1]);
            return pairs.All(p => p.Count(f1 => f1[0] == 0) == p.Count(f1 => f1[0] == 1));
        }


        public static int[] arrayPreviousLess(int[] items)
        {
            var output = new int[items.Length];
            output = output.Select(n => -1).ToArray();

            for (var i = 0; i < items.Length; i++)
            {
                for (var y = i - 1; y >= 0; y--)
                {
                    if (items[y] < items[i])
                    {
                        output[i] = items[y];
                        break;
                    }
                }
            }
            return output;
        }


        public static int arrayConversion(int[] inputArray)
        {
            var totalOut = 1;
            var scratchList = new List<int>(inputArray);
            var outList = new List<int>();

            while (outList.Count != 1)
            {
                outList = new List<int>();
                for (var i = 0; i < scratchList.Count; i += 2)
                {
                    if (i + 1 == scratchList.Count)
                        outList.Add(scratchList[i]);
                    else if (totalOut % 2 == 0)
                    {
                        outList.Add(scratchList[i] * scratchList[i + 1]);
                    }
                    else
                    {
                        outList.Add(scratchList[i] + scratchList[i + 1]);
                    }
                }

                scratchList = outList;
                totalOut++;
            }

            return outList[0];
        }

    }
}
