using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    /// <summary>
    /// Arcade -> IntroGates
    /// </summary>
    public static class IntroGates
    {
        public static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }

        public static int candies(int n, int m)
        {
            return m - m % n;
        }

        public static int largestNumber(int n)
        {
            return int.Parse(new string('9', n));
        }

        public static int addTwoDigits(int n)
        {
            return n.ToString().ToCharArray().Select(f => int.Parse(f.ToString())).Sum();
        }
    }
}
