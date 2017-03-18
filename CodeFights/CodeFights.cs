using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class CodeFights
    {
        public string reverseParentheses(string s)
        {
            var startReversed = false;
            var splits = s.Split('(', ')');
            if (s.StartsWith("("))
                startReversed = true;

            var assembled = new List<string>();

            for (var i = 0; i < splits.Length/2; i++)
            {
                assembled.Add(splits[i] + splits[i + splits.Length / 2]);
            }

            foreach (var word in assembled)
            {
                if()
            }
        }
        public int[] sortByHeight(int[] a)
        {
            var output = new List<int>();
            var lastSmall = int.MinValue;
            foreach (var i in a)
            {
                if (i == -1)
                {
                    output.Add(i);
                }
                else
                {
                    if (a.Where(c => c == lastSmall).Count() > output.Count(d => d == lastSmall))
                        lastSmall = a.Where(b => b != -1 && b >= lastSmall).Min();
                    else
                        lastSmall = a.Where(b => b != -1 && b > lastSmall).Min();
                    output.Add(lastSmall);
                }
            }
            return output.ToArray();
        }

        public bool isLucky(int n)
        {
            var a = n.ToString().ToCharArray();
            var suma = 0;
            var sumb = 0;

            for (var i = 0; i < a.Length / 2; i++)
            {
                suma += int.Parse(a[i].ToString());
                sumb += int.Parse(a[i + a.Length / 2].ToString());
            }

            return suma == sumb;
        }

        public int commonCharacterCount(string s1, string s2)
        {
            var a1 = s1.ToCharArray();
            var a2 = s2.ToCharArray();

            var count = 0;

            foreach (var i in a1.Distinct())
            {
                count += Math.Min(a1.Where(b => b == i).Count(), a2.Where(b => b == i).Count());
            }

            return count;
        }

        string[] allLongestStrings(string[] inputArray)
        {
            var maxLen = int.MinValue;
            foreach (var i in inputArray)
            {
                if (i.Length > maxLen)
                    maxLen = i.Length;
            }
            return Array.FindAll(inputArray, x => x.Length == maxLen);

        }

        public int matrixElementsSum(int[][] matrix)
        {
            var ignoreInd = new List<int>();
            var price = 0;

            for (var x = 0; x < matrix.Length; x++)
            {
                for (var y = 0; y < matrix[x].Length; y++)
                {
                    if (ignoreInd.Any(a=>a==y))
                        continue;

                    if (matrix[x][y] == 0)
                    {
                        ignoreInd.Add(y);
                    }
                    price += matrix[x][y];
                }
            }

            return price;
        }
    }
}
