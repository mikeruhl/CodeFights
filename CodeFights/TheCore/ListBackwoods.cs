using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class ListBackwoods
    {

        public static int[][] starRotation(int[][] matrix, int width, int[] center, int t)
        {
            t = t % 8;
            if (t == 0)
                return matrix;

            var arrayWidth = matrix[0].Length;
            var arrayHeight = matrix.Length;

            var pos = new[]
            {
                new[] {0, -1}, new[] {1, -1}, new[] {1, 0}, new[] {1, 1}, new[] {0, 1}, new[] {-1, 1}, new[] {-1, 0},
                new[] {-1, -1}
            };



            var newStar = new int[matrix.Length][];
            for (var x = 0; x < matrix.Length; x++)
            {
                newStar[x] = (int[])matrix[x].Clone();
            }

            for (var p = 0; p < pos.Length; p++)
            {
                for (var w = 0; w <= (width - 1) / 2; w++)
                {
                    var oldX = center[1] + (w * pos[p][0]);
                    var oldY = center[0] + (w * pos[p][1]);
                    var newX = center[1] + (w * pos[(p + t) % 8][0]);
                    var newY = center[0] + (w * pos[(p + t) % 8][1]);
                    if (oldX >= 0 && oldX < arrayWidth &&
                        oldY >= 0 && oldY < arrayHeight &&
                        newX >= 0 && newX < arrayWidth &&
                        newY >= 0 && newY < arrayHeight)
                        newStar[newY][newX] = matrix[oldY][oldX];
                }
            }
            
            return newStar;
        }

        public static string[][] volleyballPositions(string[][] formation, int k)
        {
            var boop = new string[formation.Length][];
            for (var p = 0; p < formation.Length; p++)
            {
                boop[p] = (string[])formation[p].Clone();
            }
            var positions = new[] { new[] { 3, 2 }, new[] { 1, 2 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 3, 0 }, new[] { 2, 1 } };
            k = k % 6;

            for (var p = 0; p < 6; p++)
            {
                if (p - k < 0)
                {
                    boop[positions[p][0]][positions[p][1]] = formation[positions[6 - k + p][0]][positions[6 - k + p][1]];
                }
                else
                {
                    boop[positions[p][0]][positions[p][1]] = formation[positions[p - k][0]][positions[p - k][1]];
                }
            }
            return boop;
        }

        public static char[][] drawRectangle(char[][] canvas, int[] rectangle)
        {
            for (var x = rectangle[0]; x <= rectangle[2]; x++)
            {
                for (var y = rectangle[1]; y <= rectangle[3]; y++)
                {
                    if (x == rectangle[0] | x == rectangle[2] && y == rectangle[1] | y == rectangle[3])
                    {
                        canvas[y][x] = '*';
                    }
                    else if (x == rectangle[0] | x == rectangle[2])
                    {
                        canvas[y][x] = '|';
                    }
                    else if (y == rectangle[1] | y == rectangle[3])
                    {
                        canvas[y][x] = '-';
                    }
                }
            }
            return canvas;
        }

        public static int crossingSum(int[][] matrix, int a, int b)
        {
            var s = 0;
            for (var x = 0; x < matrix.Length; x++)
            {
                if (x == a)
                    s += matrix[x].Sum();
                else
                    s += matrix[x][b];
            }
            return s;
        }


        public static int[][] swapDiagonals(int[][] matrix)
        {
            var boop = new int[matrix.Length][];

            for (var x = 0; x < matrix.Length; x++)
            {
                boop[x] = (int[])matrix[x].Clone();
                boop[x][x] = matrix[x][matrix.Length - 1 - x];
                boop[x][matrix.Length - 1 - x] = matrix[x][x];
            }
            return boop;
        }

        public static int[][] reverseOnDiagonals(int[][] matrix)
        {

            var boop = new int[matrix.Length][];

            for (var x = 0; x < matrix.Length; x++)
            {
                boop[x] = (int[])matrix[x].Clone();
                boop[x][x] = matrix[matrix.Length - 1 - x][matrix.Length - 1 - x];
                boop[x][matrix.Length - 1 - x] = matrix[matrix.Length - 1 - x][x];
            }
            return boop;
        }


        public static bool areIsomorphic(int[][] array1, int[][] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (var x = 0; x < array1.Length; x++)
            {
                if (array1[x].Length != array2[x].Length)
                    return false;
            }
            return true;
        }

        public static int[] extractMatrixColumn(int[][] matrix, int column)
        {
            return matrix.Select(i => i[column]).ToArray();

        }
    }
}
