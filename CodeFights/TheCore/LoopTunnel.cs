using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class LoopTunnel
    {

        public static int countBlackCells(int n, int m)
        {
            var getGcdFunc = new Func<int, int, int>((a, b) =>
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }

                return a == 0 ? b : a;
            });

            var gcd = getGcdFunc(n, m);

            var noDots = n + m - gcd;
            var addedDots = gcd > 1 ? (gcd -1) * 2 : 0;
            return noDots + addedDots;

        }

        public static int candles(int candlesNumber, int makeNew)
        {
            var currentCandles = candlesNumber;
            var newCandles = candlesNumber;
            var currentLeftOvers = candlesNumber;
            while (currentLeftOvers >= makeNew)
            {
                candlesNumber += (int)Math.Floor((double)currentLeftOvers / (double)makeNew);
                newCandles = candlesNumber - currentCandles;
                currentLeftOvers = (currentLeftOvers % makeNew) + newCandles;
                currentCandles = candlesNumber;
            }
            return candlesNumber;
        }


        public static int rounders(int value)
        {
            var digits = value.ToString().Length - 1;
            var temp = (double)value; 
            for (var i = 1; i <= digits; i++)
            {
                temp = temp / Math.Pow(10, i);
                temp = Math.Round(temp, 0, MidpointRounding.AwayFromZero);
                temp = temp * Math.Pow(10, i);
            }

            return (int)temp;
        }


        public static bool increaseNumberRoundness(int n)
        {
            var ns = n.ToString();
            var nonzero = 0;
            for (var i = ns.Length - 1; i >= 0; i--)
            {
                if (ns.Substring(i, 1) != "0")
                {
                    nonzero = i;
                    break;
                }
            }
            return ns.Substring(0, nonzero + 1).Contains("0");
        }


        public static int appleBoxes(int k)
        {
            var redApples = 0;
            var yellowApples = 0;
            for (var i = 1; i <= k; i++)
            {
                if (i % 2 == 1)
                    yellowApples += i * i;
                else
                    redApples += i * i;
            }
            return redApples - yellowApples;
        }

        public static int additionWithoutCarrying(int param1, int param2)
        {
            var a = param1.ToString().PadLeft(param2.ToString().Length, '0');
            var b = param2.ToString().PadLeft(a.Length, '0');

            var output = new StringBuilder();
            var temp = 0;
            for (var i = a.Length-1; i >= 0; i--)
            {
                temp = int.Parse(a.Substring(i, 1)) + int.Parse(b.Substring(i, 1));
                if (temp >= 10)
                    output.Insert(0,(temp % 10).ToString());
                else
                    output.Insert(0, temp.ToString());
            }
            return int.Parse(output.ToString());
        }

        public static int lineUp(string commands)
        {
            //   0
            // 3   1
            //   2
            var righties = 0;
            var lefties = 0;
            var output = 0;
            foreach (var c in commands)
            {
                switch (c)
                {
                    case 'A':
                        righties += 2;
                        lefties += 2;
                        break;
                    case 'L':
                        righties += 1;
                        lefties += 3;
                        break;
                    case 'R':
                        righties += 3;
                        lefties += 1;
                        break;
                }
                if (righties > 3)
                    righties -= 4;
                if (lefties > 3)
                    lefties -= 4;
                if (righties == lefties)
                    output++;
            }

            return output;
        }


        public static int magicalWell(int a, int b, int n)
        {
            var output = 0;
            for (var i = 1; i <= n; i++)
            {
                output += a * b;
                a++;
                b++;
            }
            return output;
        }

        public static int countSumOfTwoRepresentations2(int n, int l, int r)
        {
            var output = 0;

            for (var i = l; i <= n / 2; i++)
            {
                
                if (n - i <= r & n - i >= l)
                    output++;
            }

            return output;
        }


        public static int leastFactorial(int n)
        {
            var currentFact =2;
            var output = 1;
            while (output < n)
            {
                    output = Enumerable.Range(1, currentFact).Aggregate((i, r) => r * i);
                currentFact++;
            }

            return output;
        }

    }
}
