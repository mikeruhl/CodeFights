using System.Collections.Generic;
using System.Linq;

namespace CodeFights.Intro
{
    public static class ArcadeIntro4
    {
        /// <summary>
        /// L4.6
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool palindromeRearranging(string inputString)
        {
            var counted = inputString.GroupBy(c => c)
                              .Select(g => g.Count() );

            return counted.Count(a => a % 2 == 1) < 2;


        }

        /// <summary>
        /// L4.5
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int arrayChange(int[] inputArray)
        {
            var counter = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                while (inputArray[i] <= inputArray[i - 1])
                {
                    inputArray[i]++;
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// L4.4
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static bool areSimilar(int[] A, int[] B)
        {
            if (A.ToList().SequenceEqual(B.ToList()))
                return true;

            var firstNumber = -1;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    if (firstNumber > -1)
                    {
                        var toSwap = B[i];
                        B[i] = B[firstNumber];
                        B[firstNumber] = toSwap;

                        break;
                    }
                    firstNumber = i;
                }
            }

            return A.ToList().SequenceEqual(B.ToList());
        }

        public static string[] addBorder(string[] picture)
        {
            var outList = new List<string>();
            var width = picture[0].Length;
            outList.Add(new string('*', width + 2));
            for (var i = 0; i < picture.Length; i++)
            {
                outList.Add("*" + picture[i] + "*");
            }
            outList.Add(new string('*', width + 2));
            return outList.ToArray();
        }

        /// <summary>
        /// Level 4 - 1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] alternatingSums(int[] a)
        {
            var teamWeights = new int[] { 0, 0 };

            for (var i = 0; i < a.Length; i++)
            {
                teamWeights[i % 2] += a[i];
            }

            return teamWeights;

        }
    }
}
