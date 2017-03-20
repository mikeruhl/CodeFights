using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights
{
    public static class ArcadeIntro5
    {
        public static int[][] minesweeper(bool[][] matrix)
        {
            var outList = new List<List<int>>();

            for (var x = 0; x < matrix.Length; x++)
            {
                outList.Add(new List<int>());
                for (var y = 0; y < matrix[0].Length; y++)
                {
                    outList[x].Add(0);
                }
            }

            for (var y = 0; y < matrix.Length; y++)
            {

                for (var x = 0; x < matrix[0].Length; x++)
                {
                    if (matrix[y][x])
                    {

                        if (y > 0)
                        {
                            outList[y - 1][x]++;
                            if (x > 0)
                            {
                                outList[y - 1][x - 1]++;
                            }
                            if (x < matrix[0].Length - 1)
                                outList[y - 1][x + 1]++;
                        }
                        if (x > 0)
                        {
                            outList[y][x - 1]++;
                        }
                        if (x < matrix[0].Length - 1)
                            outList[y][x + 1]++;

                        if (y < matrix.Length - 1)
                        {
                            outList[y + 1][x]++;
                            if (x > 0)
                                outList[y + 1][x - 1]++;
                            if (x < matrix[0].Length - 1)
                                outList[y + 1][x + 1]++;
                        }

                    }
                }
            }

            return outList.Select(a => a.ToArray()).ToArray();
        }

        public static int[][] boxBlur(int[][] image)
        {
            var output = new int[image.Length - 2][];
            var width = image[0].Length;
            for (var y = 1; y < image.Length - 1; y++)
            {
                output[y-1] = new int[width-2];
                for (var x = 1; x < image[0].Length - 1; x++)
                {
                    output[y-1][x-1] = (image[y - 1][x - 1] + image[y - 1][x] + image[y - 1][x + 1] +
                                    image[y][x - 1] + image[y][x] + image[y][x + 1] +
                                    image[y + 1][x - 1] + image[y + 1][x] + image[y + 1][x + 1]) / 9;
                }
            }
            return output;
        }

        public static int avoidObstacles(int[] inputArray)
        {
            var found = false;
            var hop = 1;
            while (!found)
            {
                for (var i = 0; i <= inputArray.Max(); i += hop)
                {
                    if (inputArray.Contains(i))
                    {
                        found = false;
                        hop++;
                        break;
                    }
                    found = true;
                }
            }
            return hop;
        }
        public static bool isIPv4Address(string inputString)
        {
            var ip = new Regex("^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
            return ip.IsMatch(inputString);

        }

        public static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            var output = Int32.MinValue;
            var diffa = Int32.MinValue;
            var diffb = Int32.MinValue;

            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                diffa = inputArray[i] - inputArray[i + 1];
                diffb = inputArray[i + 1] - inputArray[i];
                if (diffa > output)
                    output = diffa;
                if (diffb > output)
                    output = diffb;
            }
            return output;
        }
        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return new[] { yourLeft, yourRight }.Min() == new[] { friendsLeft, friendsRight }.Min()
                   && new[] { yourLeft, yourRight }.Max() == new[] { friendsLeft, friendsRight }.Max();
        }
    }
}
