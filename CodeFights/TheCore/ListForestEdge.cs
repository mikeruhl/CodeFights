using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
   public static class ListForestEdge
    {

        public static int makeArrayConsecutive2(int[] statues)
        {
            var more = 0;
            for (var i = statues.Min() + 1; i < statues.Max(); i++)
            {
                if (!statues.Any(n => n == i))
                    more++;
            }
            return more;
        }


        public static int[] replaceMiddle(int[] arr)
        {
            return arr.Where((n, i) => i < Math.Floor(((decimal) arr.Length - 1) / 2))
                .Concat(new[]
                {
                    arr.Where(
                            (n, i) =>
                                i == Math.Floor(((decimal) arr.Length - 1) / 2) |
                                i == Math.Ceiling(((decimal) arr.Length - 1) / 2))
                        .Sum(f => f)
                })
                .Concat(arr.Where((n, i) => i > Math.Ceiling(((decimal) arr.Length - 1) / 2))).ToArray();
        }


        public static bool isSmooth(int[] arr)
        {

            return (arr[0] == arr[arr.Length - 1]) &&
                arr.Where((n, i) => i == Math.Floor(((decimal)arr.Length - 1) / 2) | i == Math.Ceiling(((decimal)arr.Length - 1) / 2))
                    .Sum(f => f) == arr[0];

        }

        public static int[] removeArrayPart(int[] inputArray, int l, int r)
        {
            return inputArray.Where((n,i)=>i <l | i > r ).ToArray();
        }


        public static int[] concatenateArrays(int[] a, int[] b)
       {
           return a.Concat(b).ToArray();
       }


        public static int[] firstReverseTry(int[] arr)
        {
            return arr.Select((n,i)=>i == 0? arr[arr.Length-1] : i == arr.Length -1 ? arr[0] : n).ToArray();
        }
        public static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select((n)=>n==elemToReplace? substitutionElem : n).ToArray();
        }

        public static int[] createArray(int size)
        {
            return new int[size].Select(n=>n=1).ToArray();
        }


    }
}
