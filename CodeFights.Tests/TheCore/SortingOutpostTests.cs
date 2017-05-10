using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.Tests.Common;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class SortingOutpostTests
    {
        [TestCase(new[] { 2, 8, 121, 42, 222, 23 }, ExpectedResult =3, Description ="SOT.07.01")]
        [TestCase(new[] { 239 }, ExpectedResult = 1, Description = "SOT.07.02")]
        [TestCase(new[] { 100, 101, 111 }, ExpectedResult = 2, Description = "SOT.07.03")]
        [TestCase(new[] { 100, 23, 42, 239, 22339, 9999999, 456, 78, 228, 1488 }, ExpectedResult = 10, Description = "SOT.07.04")]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, ExpectedResult = 10, Description = "SOT.07.05")]
        public int TestuniqueDigitProducts(int[] a)
        {
            return SortingOutpost.uniqueDigitProducts(a);
        }

        [TestCase(new[] { 152, 23, 7, 887, 243 }, ExpectedResult = new[] { 7, 887, 23, 243, 152 }, Description = "SOT.06.01")]
        [TestCase(new int[] { }, ExpectedResult = new int[] { }, Description = "SOT.06.02")]
        [TestCase(new[] { 13098, 1308, 12398, 52433, 213, 424, 213, 243, 12213, 54234, 99487, 81892, 11111, 97897 }, ExpectedResult = new[] { 11111, 97897, 12213, 243, 213, 424, 213, 54234, 52433, 99487, 81892, 12398, 1308, 13098 }, Description = "SOT.06.03")]
        public int[] TestdigitDifferenceSort(int[] a)
        {
            return SortingOutpost.digitDifferenceSort(a);
        }

        #region SOT06
        static List<ComplexTest<int[][], bool>> SOT06 = new List<ComplexTest<int[][], bool>>
        {
            new ComplexTest<int[][], bool> //1
            {
                Input = new[] {new[]{2,7,1},
new[]{0,2,0},
new[]{1,3,1}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool> //2
            {
                Input = new[] {new[]{6,4},
new[]{2,2},
new[]{4,3}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool> //3
            {
                Input = new[] {new[]{0,1},
new[]{1,2},
new[]{2,3},
new[]{-1,4}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool> //4
            {
                Input = new[] {new[]{2,2,2},
new[]{1,1,1}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool> //5
            {
                Input = new[] {new[]{1,3,1},
new[]{0,2,0},
new[]{1,7,2}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool> //6
            {
                Input = new[] {new[]{3,34,2,5,2},
new[]{2,34,5,2,1}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool> //7
            {
                Input = new[] {new[]{0},
new[]{1},
new[]{2},
                new[]{-1}},
                ExpectedResult = true
            }
        };
        #endregion
        [TestCaseSource("SOT06")]
        public void TestrowsRearranging(ComplexTest<int[][], bool> test)
        {
            Assert.AreEqual(test.ExpectedResult, SortingOutpost.rowsRearranging(test.Input));
        }



        #region SOT05
        static List<ComplexTest<object[], int>> SOT05 = new List<ComplexTest<object[], int>>
        {
            new ComplexTest<object[], int>
            {
                Input = new object[] { new[] { 2, 1, 2 }, new[] { new[] { 0, 1 } } },
                ExpectedResult = 4
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] { new[] { 4, 2, 1, 6, 5, 7, 2, 4 }, new[] {new[]{1,6},
new[]{2,4},
new[]{3,6},
new[]{0,7},
new[]{3,6},
new[]{4,4},
new[]{5,6},
new[]{5,6},
new[]{0,1},
new[]{3,4} } },
                ExpectedResult = 162
            }
        };
        #endregion
        [TestCaseSource("SOT05")]
        public void TestmaximumSum(ComplexTest<object[], int> test)
        {
            Assert.AreEqual(test.ExpectedResult, SortingOutpost.maximumSum((int[])test.Input[0], (int[][])test.Input[1]));
        }

        [TestCase(new[] { 1, 3, 2 }, new[] { 1, 3, 2 }, new[] { 1, 3, 2 }, ExpectedResult = true, Description = "SO.4.1")]
        [TestCase(new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, ExpectedResult = false, Description = "SO.4.2")]
        [TestCase(new[] { 3, 1, 2 }, new[] { 3, 1, 2 }, new[] { 3, 2, 1 }, ExpectedResult = false, Description = "SO.4.3")]
        [TestCase(new[] { 2 }, new[] { 3 }, new[] { 4 }, ExpectedResult = true, Description = "SO.4.4")]
        [TestCase(new[] { 5, 7, 4, 1, 2 }, new[] { 4, 10, 3, 1, 4 }, new[] { 6, 5, 5, 1, 2 }, ExpectedResult = true, Description = "SO.4.5")]
        [TestCase(new[] { 6, 4 }, new[] { 5, 3 }, new[] { 4, 5 }, ExpectedResult = true, Description = "SO.4.6")]
        [TestCase(new[] { 6, 3 }, new[] { 5, 4 }, new[] { 4, 5 }, ExpectedResult = true, Description = "SO.4.7")]
        [TestCase(new[] { 6, 3 }, new[] { 5, 5 }, new[] { 4, 4 }, ExpectedResult = true, Description = "SO.4.8")]
        [TestCase(new[] { 883, 807 }, new[] { 772, 887 }, new[] { 950, 957 }, ExpectedResult = true, Description = "SO.4.9")]
        [TestCase(new[] { 6, 5 }, new[] { 5, 3 }, new[] { 4, 4 }, ExpectedResult = true, Description = "SO.4.10")]
        [TestCase(new[] { 4, 10, 3, 1, 4 }, new[] { 5, 7, 4, 1, 2 }, new[] { 6, 5, 5, 1, 2 }, ExpectedResult = true, Description = "SO.4.11")]
        [TestCase(new[] { 10, 8, 6, 4, 1 }, new[] { 7, 7, 6, 3, 2 }, new[] { 9, 6, 3, 2, 1 }, ExpectedResult = true, Description = "SO.4.12")]
        [TestCase(new[] { 9980, 9984, 9981 }, new[] { 9980, 9984, 9983 }, new[] { 9981, 9984, 9982 }, ExpectedResult = true, Description = "SO.4.13")]
        public bool TestboxesPacking(int[] length, int[] width, int[] height)
        {
            return SortingOutpost.boxesPacking(length, width, height);
        }




        #region SOT03
        static List<ComplexTest<string[], string[]>> SOT03 = new List<ComplexTest<string[], string[]>>
        {
            new ComplexTest<string[], string[]>
            {
                Input = new[] {"abc",
 "",
 "aaa",
 "a",
 "zz"},
                ExpectedResult = new[] {"", "a", "zz", "abc", "aaa"}
            },
            new ComplexTest<string[], string[]>
            {
                Input = new[] {"zz",
 "",
 "bb",
 "ccc",
 "cc"},
                ExpectedResult = new[] {"", "zz", "bb", "cc", "ccc"}
            }
        };
        #endregion
        [TestCaseSource("SOT03")]
        public void TestsortByLength(ComplexTest<string[], string[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, SortingOutpost.sortByLength(test.Input));
        }


        [TestCase(new[] { 1, 12, 3, 6, 2 }, ExpectedResult = new[] { 1, 2, 3, 6 }, Description = "SortingOutpost.1.1")]
        [TestCase(new[] { 1, -3, -5, 7, 2 }, ExpectedResult = new[] { -5, -3, 2, 7 }, Description = "SortingOutpost.1.2")]
        [TestCase(new[] { 2, -1, 2, 2, -1 }, ExpectedResult = new[] { -1, -1, 2, 2 }, Description = "SortingOutpost.1.3")]
        [TestCase(new[] { -3, -3 }, ExpectedResult = new[] { -3 }, Description = "SortingOutpost.1.4")]
        public int[] TestshuffledArray(int[] shuffled)
        {
            return SortingOutpost.shuffledArray(shuffled);
        }

    }
}
