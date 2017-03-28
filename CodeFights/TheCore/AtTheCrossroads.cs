using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class AtTheCrossroads
    {


        public static int[] metroCard(int lastNumberOfDays)
        {
            if (lastNumberOfDays == 31)
                return new[] { 28, 30, 31 };
            return new[] { 31 };


        }

        public static bool willYou(bool young, bool beautiful, bool loved)
        {
            return loved != (young & beautiful);

        }


        public static bool tennisSet(int score1, int score2)
        {
            var scores = new[] { score1, score2 };
            return (scores.Max() == 6 & scores.Min() < 5) || (scores.Min() >= 5 & scores.Min() < 7 & scores.Max() == 7);

        }

        public static bool arithmeticExpression(int A, int B, int C)
        {
            return A + B == C | A - B == C | A * B == C | (double)A / (double)B == (double)C;
        }

        public static bool isInfiniteProcess(int a, int b)
        {
            return !(a % 2 == b % 2 & a <= b);
        }

        public static int extraNumber(int a, int b, int c)
        {
            var array = new int[] { a, b, c };
            return
                array.GroupBy(x => x)
                    .Select(x => new KeyValuePair<int, int>(x.Key, x.Count()))
                    .FirstOrDefault(kvp => kvp.Value == 1).Key;
        }

        //knapsacklight is in ArcadeIntro9

        public static bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }
    }
}
