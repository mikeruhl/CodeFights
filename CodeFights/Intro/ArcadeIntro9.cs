using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeFights.Intro
{
    public static class ArcadeIntro9
    {

        public static bool bishopAndPawn(string bishop, string pawn)
        {
            var bc = bishop.Substring(0, 1).ToCharArray()[0] - 64;
            var br = int.Parse(bishop.Substring(1, 1));
            var pc = pawn.Substring(0, 1).ToCharArray()[0] - 64;
            var pr = int.Parse(pawn.Substring(1, 1));

            return Math.Abs(bc - pc) == Math.Abs(br - pr);

        }

        public static int digitDegree(int n)
        {
            var i = 0;
            while (n > 9)
            {
                n = n.ToString().ToCharArray().Select(f => int.Parse(f.ToString())).Sum();
                i++;
            }
            return i;
        }

        public static string longestDigitsPrefix(string inputString)
        {
            var re = new Regex("^[0-9]*");
            return re.IsMatch(inputString) ? re.Match(inputString).Value : string.Empty;
        }

        public static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {

            if (weight1 + weight2 <= maxW)
            {
                return value1 + value2;
            }
            if (value1 > value2)
            {
                if (weight1 <= maxW)
                    return value1;
                if (weight2 <= maxW)
                    return value2;
            }
            if (weight2 <= maxW)
                return value2;
            return weight1 > maxW ? 0 : value1;
        }

        public static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            var days = 0;
            var height = 0;
            while (height < desiredHeight)
            {
                height = Math.Max(0, height - downSpeed);
                height += upSpeed;
                days++;
            }
            return days;
        }
    }
}
