using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class SortingOutpost
    {

        public static int uniqueDigitProducts(int[] a)
        {
            var bingo = new HashSet<int>();
            foreach(var i in a)
            {
                var arr = i.ToString().ToCharArray().Select(b => int.Parse(b.ToString())).Aggregate(1, (f, e) => f * e);
                bingo.Add(arr);
            }
            return bingo.Count;
        }

        public static int[] digitDifferenceSort(int[] a)
        {
            var d = new Dictionary<int, int>();
            var sorted = a.Reverse().OrderBy(b =>
            {
                var i = b.ToString().ToCharArray().Select(c => int.Parse(c.ToString()));
                return i.Max() - i.Min();
            });
            return sorted.ToArray();
        }


        public static bool rowsRearranging(int[][] matrix)
        {
            var sortedOnOne = matrix.OrderBy(b => b[0]).ToArray();
            for (var x = 1; x < matrix[0].Length; x++)
            {
                sortedOnOne = matrix.OrderBy(b => b[x]).ToArray();
            }
            
            for(var y = 0; y < matrix.Length-1; y++)
            {
                for(var x = 0; x < matrix[y].Length; x++)
                {
                    if (sortedOnOne[y][x] >= sortedOnOne[y + 1][x])
                        return false;
                }
            }
            return true;
        }

        public static int maximumSum(int[] arr, int[][] queries)
        {
            var places = new Dictionary<int, int>();
            foreach (var range in queries)
            {
                for (var x = range[0]; x <= range[1]; x++)
                {
                    if (places.ContainsKey(x))
                        places[x]++;
                    else
                        places.Add(x, 1);
                }
            }

            var sorted = arr.OrderByDescending(b=>b).ToArray();
            var sum = 0;
            var y = 0;
            foreach(var kvp in places.OrderByDescending(kvp=>kvp.Value))
            {
                sum += sorted[y] * kvp.Value;
                y++;
            }

            return sum;
        }


        public static bool boxesPacking(int[] length, int[] width, int[] height)
        {
            var areas = new List<double>();
            for (var i = 0; i < length.Length; i++)
            {
                areas.Add((double)length[i] * width[i] * height[i]);
            }
            var aS = areas.Select((s, i) => new { s, i }).OrderBy(b => b.s).ToArray();

            for (var i = 0; i < length.Length - 1; i++)
            {
                var sidesBigger = new List<int> { length[aS[i + 1].i], width[aS[i + 1].i], height[aS[i + 1].i] };
                var sides = new List<int> { length[aS[i].i], width[aS[i].i], height[aS[i].i] };

                foreach(var s in sides.OrderByDescending(b=>b))
                {
                    var getIt = sidesBigger.Where(b => b > s).ToArray();
                    if (getIt.Length == 0)
                        return false;
                    var side = getIt.Max();

                    for (var l1 = 0; l1 < sidesBigger.Count; l1++)
                    {
                        if (sidesBigger[l1] == side)
                        {
                            sidesBigger.RemoveAt(l1);
                            break;
                        }
                    }
                }

                if (sidesBigger.Count > 0)
                    return false;
            }

            return true;
        }


        public static string[] sortByLength(string[] inputArray)
        {
            return inputArray.OrderBy(i => i.Length).ToArray();
        }


        //sortByHeight in Intro Level 3


        public static int[] shuffledArray(int[] shuffled)
        {
            var remover = -1;
            for (var i = 0; i < shuffled.Length; i++)
            {
                if (shuffled[i] == shuffled.Where((s, i2) => i2 != i).Sum())
                    remover = i;
            }

            return shuffled.Where((s, i) => i != remover).OrderBy(b => b).ToArray();
        }

    }
}
