using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights
{
    public static class ArcadeIntro12
    {

        public static bool sudoku(int[][] grid)
        {
            for (var y = 0; y < grid.Length; y++)
            {
                if (grid[y].GroupBy(a => a).Select(b => b.Count()).Max() > 1)
                    return false;

                if (grid.Select(e => e[y]).GroupBy(c => c).Select(d => d.Count()).Max() > 1)
                    return false;
            }

            for (var y = 0; y < grid.Length; y += 3)
            {
                var slice = grid.Where((a, b) => b >= y & b < y + 3).ToArray();
                for (var x = 0; x < grid[0].Length; x += 3)
                {

                    var sliceX = slice.Select(c=>c.Where((d,e)=>e >= x & e < x+3).ToArray()).ToArray();

                    var allNine = sliceX[0].Concat(sliceX[1]).Concat(sliceX[2]).ToArray();

                    if (allNine.GroupBy(e => e)
                            .Select(f => f.Count())
                            .Max() > 1)
                        return false;
                }
            }

            return true;
        }

        public static int[][] spiralNumbers(int n)
        {
            var direction = "right";

            var output = new int[n][];
            for(int a = 0; a < output.Length; a++)
            {
                output[a] = new int[n];
            }

            var counter = 1;
            var nextX = 0;
            var nextY = 0;
            while (counter <= n * n)
            {
                output[nextY][nextX] = counter;
                switch (direction)
                {
                    case "right":
                        if (nextX == n - 1 || output[nextY][nextX+1] != 0)
                        {
                            direction = "down";
                            nextY++;
                        }    
                        else
                            nextX++;
                        break;
                    case "down":
                        if (nextY == n - 1 || output[nextY + 1][nextX] != 0)
                        {
                            direction = "left";
                            nextX--;
                        }
                        else
                        {
                            nextY++;
                        }
                        break;
                    case "left":
                        if (nextX == 0 || output[nextY][nextX - 1] != 0)
                        {
                            direction = "up";
                            nextY--;
                        }
                        else
                        {
                            nextX--;
                        }
                        break;
                    case "up":
                        if (nextY == 0 || output[nextY - 1][nextX] != 0)
                        {
                            direction = "right";
                            nextX++;
                        }
                        else
                        {
                            nextY--;
                        }
                        break;
                }
                counter++;
            }
            return output;
        }


        public static string messageFromBinaryCode(string code)
        {
           
            var listOfBytes = new List<byte>();
            //gather bytes
            for (var i = 0; i < code.Length; i += 8)
            {
                var bit = new BitArray(code.Where((s, i1) => i1 >= i && i1 < i + 8).Select(i2 => i2 != '0').Reverse().ToArray());

                var byter = new byte[1];
                bit.CopyTo(byter, 0);
                listOfBytes.Add(byter[0]);
            }
            return ASCIIEncoding.ASCII.GetString(listOfBytes.ToArray());

        }

        public static string[] fileNaming(string[] names)
        {
            var fileOutput = new List<string>();
            foreach (var name in names)
            {
                if (!fileOutput.Contains(name))
                {
                    fileOutput.Add(name);
                }
                else
                {
                    var index = 1;
                    while (fileOutput.Contains(string.Format("{0}({1})", name, index)))
                    {
                        index++;
                    }
                    fileOutput.Add(string.Format("{0}({1})", name, index));
                }
            }

            return fileOutput.ToArray();
        }

        public static int digitsProduct(int product)
        {
            if (product == 0)
                return 10;
            if (product < 10)
                return product;

            var p = new List<int>();
            var i = product;
            for (var div = 2; div <= i; div++)
            {
                while (i % div == 0)
                {
                    p.Add(div);
                    i = i / div;
                }
            }
            var primes = p.Where(v => v != product).ToArray();

            if (primes.Length == 0)
                return -1;

            var output = 1;
            var result = 0;
            while (result != product)
            {
                output++;
                var members = output.ToString().ToCharArray().Select(b=>int.Parse(b.ToString())).ToArray();
                result = members.Aggregate(1, (a, b) => a * b);
                if (result == product)
                {
                    return output;
                }
            }
            
            return -1;
        }

        public static int differentSquares(int[][] matrix)
        {
            var squares = new List<int[]>();
            int[] temp;
            for (var y = 0; y < matrix.Length - 1; y++)
            {
                for (var x = 0; x < matrix[0].Length - 1; x++)
                {
                    temp = new[] {matrix[y][x], matrix[y][x + 1], matrix[y + 1][x], matrix[y + 1][x + 1]};
                    if (squares.All(b => b[0] != temp[0] | b[1] != temp[1] | b[2] != temp[2] | b[3] != temp[3]))
                        squares.Add(temp);
                }
            }

            return squares.Count;
        }


        public static int sumUpNumbers(string inputString)
        {
            var re = new Regex(@"\d+");
            return re.Matches(inputString).Cast<object>().Sum(s => int.Parse(s.ToString()));
        }


        public static bool validTime(string time)
        {
            var splits = time.Split(':');
            if (splits.Length != 2)
                return false;

            try
            {
                var hour = int.Parse(splits[0]);
                var minute = int.Parse(splits[1]);
                if (hour < 0 | hour > 23)
                    return false;
                if (minute < 0 | minute > 59)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string longestWord(string text)
        {
            var re = new Regex(@"\w+");
            var longest = string.Empty;
            foreach (var r in re.Matches(text))
            {
                if (r.ToString().Length > longest.Length)
                    longest = r.ToString();

            }
            return longest;
        }

    }
}
