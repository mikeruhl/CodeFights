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
    public class MirrorLakeTests
    {
        [TestCase(new[] { 2, 3 }, 6, ExpectedResult = 4, Description = "MirrorLake.8.1")]
        [TestCase(new[] { 2, 3, 4 }, 6, ExpectedResult = 5, Description = "MirrorLake.8.2")]
        [TestCase(new[] { 1, 3 }, 10, ExpectedResult = 2, Description = "MirrorLake.8.3")]
        [TestCase(new[] { 6, 2, 2, 8, 9, 2, 2, 2, 2 }, 10, ExpectedResult = 5, Description = "MirrorLake.8.4")]
        public int TestnumberOfClans(int[] divisors, int k)
        {
            return MirrorLake.numberOfClans(divisors, k);
        }

        [TestCase(88, ExpectedResult = 9, Description = "MirrorLake.7.7")]
        [TestCase(8, ExpectedResult = 8, Description = "MirrorLake.7.7")]
        [TestCase(1, ExpectedResult = 1, Description = "MirrorLake.7.7")]
        [TestCase(17, ExpectedResult = 9, Description = "MirrorLake.7.7")]
        [TestCase(239, ExpectedResult = 9, Description = "MirrorLake.7.7")]
        [TestCase(994, ExpectedResult = 9, Description = "MirrorLake.7.7")]
        [TestCase(9999, ExpectedResult = 18, Description="MirrorLake.7.7")]
        public int TestmostFrequentDigitSum(int n)
        {
            return MirrorLake.mostFrequentDigitSum(n);
        }


        #region MirrorLake.5 TestCases

        private static List<ComplexTest<int[][], int>> M5 = new List<ComplexTest<int[][], int>>
        {
            new ComplexTest<int[][], int>(new[]{new[]{1,2,1},
 new[]{2,2,2},
 new[]{2,2,2},
 new[]{1,2,3},
 new[]{2,2,1}}, 6),
            new ComplexTest<int[][], int>(new[]{new[]{9,9,9,9,9},
 new[]{9,9,9,9,9},
 new[]{9,9,9,9,9},
 new[]{9,9,9,9,9},
 new[]{9,9,9,9,9},
 new[]{9,9,9,9,9}}, 1),
            new ComplexTest<int[][], int>(new[] {new[] {3}}, 0),
            new ComplexTest<int[][], int>(new[] {new[] {3,4,5,6,7,8,9}}, 0),
            new ComplexTest<int[][], int>(new[]
            {
                new[] {3},
                new[] {4},
                new[] {5},
                new[] {6},
                new[] {7}
            }, 0),
            new ComplexTest<int[][], int>(new[]
            {
                new[] {2, 5, 3, 4, 3, 1, 3, 2},
                new[] {4, 5, 4, 1, 2, 4, 1, 3},
                new[] {1, 1, 2, 1, 4, 1, 1, 5},
                new[] {1, 3, 4, 2, 3, 4, 2, 4},
                new[] {1, 5, 5, 2, 1, 3, 1, 1},
                new[] {1, 2, 3, 3, 5, 1, 2, 4},
                new[] {3, 1, 4, 4, 4, 1, 5, 5},
                new[] {5, 1, 3, 3, 1, 5, 3, 5},
                new[] {5, 4, 4, 3, 5, 4, 4, 4}
            }, 54),
            new ComplexTest<int[][], int>(new[] {new[] {1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 2, 3, 9}}, 0)
        };
        #endregion
        [TestCaseSource("M5")]
        public void TestdifferentSquares(ComplexTest<int[][], int> test)
        {
            Assert.AreEqual(test.ExpectedResult, MirrorLake.differentSquares(test.Input));
        }


        [TestCase(new[] { 20000, 239, 10001, 999999, 10000, 20566, 29999 }, ExpectedResult = 11, Description = "MirrorLake.4.1")]
        [TestCase(new[] { 10000, 20000, 30000, 40000, 50000, 60000, 10000, 120000, 150000, 200000, 300000, 1000000, 10000000, 100000000, 10000000 }, ExpectedResult = 28, Description = "MirrorLake.4.2")]
        [TestCase(new[] { 10000 }, ExpectedResult = 2, Description = "MirrorLake.4.3")]
        [TestCase(new[] { 10000, 1 }, ExpectedResult = 3, Description = "MirrorLake.4.4")]
        [TestCase(new[] { 685400881, 696804468, 696804942, 803902442, 976412678, 976414920, 47763597, 803900633, 233144924, 47764349, 233149077, 214990733, 214994039, 280528089, 280524347, 685401797 }, ExpectedResult = 24, Description = "MirrorLake.4.5")]
        [TestCase(new[] { 598589004, 92986320, 520103781, 808743817, 635098665, 95244159, 808747008, 867017063, 635092226, 867013865, 92989995, 520100093, 95245838, 84897101, 598583113, 84893918 }, ExpectedResult = 24, Description = "MirrorLake.4.6")]
        [TestCase(new[] { 1000000000, 999990000, 999980000, 999970000, 999960000, 999950000, 999940000, 999930000, 999920000, 999910000 }, ExpectedResult = 20, Description = "MirrorLake.4.7")]
        [TestCase(new [] { 102382103, 21039898, 39823, 433, 30928398, 40283209, 23234, 342534, 98473483, 498398424, 9384984, 9839239 }, ExpectedResult = 24, Description = "MirrorLake.4.8")]
        public int TestnumbersGrouping(int[] a)
        {
            return MirrorLake.numbersGrouping(a);
        }

        [TestCase("ab", ExpectedResult = 81, Description = "MirrorLake.4.1")]
        [TestCase("zzz", ExpectedResult = -1, Description = "MirrorLake.4.2")]
        [TestCase("aba", ExpectedResult = 900, Description = "MirrorLake.4.3")]
        [TestCase("abcbbb", ExpectedResult = 810000, Description = "MirrorLake.4.4")]
        [TestCase("abc", ExpectedResult = 961, Description = "MirrorLake.4.5")]
        [TestCase("aaaabbcde", ExpectedResult= 999950884, Description="MirrorLake.4.6" )]
        [TestCase("a", ExpectedResult = 9, Description = "MirrorLake.4.C1")]
        [TestCase("aabcdefghi", ExpectedResult = 2147395600, Description = "MirrorLake.4.C2")]
        public int TestconstructSquare(string s)
        {
            return MirrorLake.constructSquare(s);
        }

        [TestCase("AABAA", "BBAAA", ExpectedResult = 1, Description = "MirrorLake.3.1")]
        [TestCase("OVGHK", "RPGUC", ExpectedResult = 4, Description = "MirrorLake.3.2")]
        [TestCase("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC", ExpectedResult=1, Description="MirrorLake.3.3")]
        public int TestcreateAnagram(string s, string t)
        {
            return MirrorLake.createAnagram(s, t);
        }


        [TestCase("aacb", "aabc", ExpectedResult = true, Description = "MirrorLake.2.1")]
        [TestCase("aa", "bc", ExpectedResult = false, Description = "MirrorLake.2.2")]
        [TestCase("aaxxaaz", "aazzaay", ExpectedResult = true, Description = "MirrorLake.2.3")]
        [TestCase("aaxyaa", "aazzaa", ExpectedResult = false, Description = "MirrorLake.2.4")]
        [TestCase("aabc", "aacb", ExpectedResult = true, Description = "MirrorLake.2.5")]
        [TestCase("dccd", "zzxx", ExpectedResult=false, Description="MirrorLake.2.6")]
        public bool TestisSubstitutionCipher(string string1, string string2)
        {
            return MirrorLake.isSubstitutionCipher(string1, string2);
        }

        [TestCase("abc", "abccba", ExpectedResult = 2, Description = "MirrorLake.1.1")]
        [TestCase("hnccv", "hncvohcjhdfnhonxddcocjncchnvohchnjohcvnhjdhihsn", ExpectedResult = 3, Description = "MirrorLake.1.2")]
        [TestCase("abc", "def", ExpectedResult = 0, Description = "MirrorLake.1.3")]
        [TestCase("zzz", "zzzzzzzzzzz", ExpectedResult=3, Description="MirrorLake.1.4")]
        public int TeststringsConstruction(string A, string B)
        {
            return MirrorLake.stringsConstruction(A, B);
        }

    }
}
