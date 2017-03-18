using System;

using NUnit.Framework;

namespace CodeFights.Tests
{
    [TestFixture]
    public class CodeFightsTests
    {

        [TestCase(new[] { -1, 150, 190, 170, -1, -1, 160, 180 }, ExpectedResult = new[] {-1, 150, 160, 170, -1, -1, 180, 190 })]
        [TestCase(new[] { -1, -1, -1, -1, -1 }, ExpectedResult = new[] { -1, -1, -1, -1, -1 })]
        [TestCase(new[] { 4, 2, 9, 11, 2, 16 }, ExpectedResult = new[] { 2, 2, 4, 9, 11, 16 })]
        public int[] TestsortByHeight(int[] a)
        {
            var cfr = new CodeFights();
            return cfr.sortByHeight(a);
        }

        [TestCase(1230, ExpectedResult = true)]
        [TestCase(239017, ExpectedResult = false)]
        [TestCase(134008, ExpectedResult = true)]
        public bool TestisLucky(int n)
        {
            var cfr = new CodeFights();
            return cfr.isLucky(n);
        }

        [Test]
        public void TestcommonCharacterCount()
        {
            var s1 = "aabcc";
            var s2 = "adcaa";

            var cfr = new CodeFights();

            Assert.AreEqual(3, cfr.commonCharacterCount(s1, s2));
        }
        [Test]
        public void TestmatrixElementsSum()
        {
            int[][] testone = new int[][] {new[] {0, 1, 1, 2}, new[] {0, 5, 0, 0}, new[] {2, 0, 3, 3}};
            var testtwo = new int[][] { new[] { 1, 1, 1, 0 }, new[] { 0, 5, 0, 1 }, new[] { 2, 1, 3, 10 } };
            var testthree = new int[][] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } };
            var testfour = new int[][] {new[] {0}};

            var cfr = new CodeFights();

            Assert.AreEqual(9, cfr.matrixElementsSum(testone));
            Assert.AreEqual(9, cfr.matrixElementsSum(testtwo));
            Assert.AreEqual(18, cfr.matrixElementsSum(testthree));
            Assert.AreEqual(0, cfr.matrixElementsSum(testfour));
        }
    }
}
