using System.Linq;

namespace CodeFights.Intro
{
    public static class ArcadeIntro8
    {

        public static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            var output = int.MinValue;
            var temp = int.MinValue;
            for (var i = 0; i < inputArray.Length - k+1; i++)
            {
                temp = inputArray[i];
                for (var b = 1; b < k; b++)
                    temp += inputArray[b+ i];

                //temp = inputArray.Where((s, e) => e >= i && e < i + k).Sum();
                if (temp > output)
                    output = temp;
            }

            return output;
        }


        public static int differentSymbolsNaive(string s)
        {
            return s.ToCharArray().GroupBy(c => c).Count();
        }

        public static char firstDigit(string inputString)
        {
            return inputString.ToCharArray().First(c => "1234567890".Contains(c));
        }

        public static int[] extractEachKth(int[] inputArray, int k)
        {
            return inputArray.Where((t, i) => (i + 1) % k != 0).ToArray();
        }
    }
}
