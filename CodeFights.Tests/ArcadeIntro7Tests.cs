using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeFights.Tests
{
    [TestFixture]
    public class ArcadeIntro7Tests
    {
        [Description("L7.2")]
        [Test]
        public void TeststringsRearrangement()
        {
            var t1 = new[] {"aba", "bbb", "bab"};
            var e1 = false;
            var t2 = new[] {"ab", "bb", "aa"};
            var e2 = true;
            var t3 = new[] {"q", "q"};
            var e3 = false;
            var t4 = new[] {"zzzzab", "zzzzbb", "zzzzaa"};
            var e4 = true;
            var t5 = new[] {"ab", "ad", "ef", "eg"};
            var e5 = false;
            var t6 = new[] {"abc", "abx", "axx", "abc"};
            var e6 = false;
            var t7 = new[]{"abc","abx","axx","abx","abc"};
            var e7 = true;
            var t8 = new[]{"f","g","a","h"};
            var e8 = true;
            var t9 = new[] {"abc", "abd", "xxx", "xyx", "abe"};
            var e9 = false;
            var t10 = new[] {"abc", "bac", "bbc", "bbe", "bbd"};
            var e10 = false;
            var t11 = new[] {"abbabbba", "abbabbca", "abbasbba", "abbsbbba", "acbabbba"};
            var e11 = false;
            var t12 = new[] {"abc", "xbc", "xxc", "xbc", "aby", "ayy", "aby"};
            var e12 = true;

            Assert.AreEqual(e1, ArcadeIntro7.stringsRearrangement(t1));
            Assert.AreEqual(e2, ArcadeIntro7.stringsRearrangement(t2));
            Assert.AreEqual(e3, ArcadeIntro7.stringsRearrangement(t3));
            Assert.AreEqual(e4, ArcadeIntro7.stringsRearrangement(t4));
            Assert.AreEqual(e5, ArcadeIntro7.stringsRearrangement(t5));
            Assert.AreEqual(e6, ArcadeIntro7.stringsRearrangement(t6));
            Assert.AreEqual(e7, ArcadeIntro7.stringsRearrangement(t7));
            Assert.AreEqual(e8, ArcadeIntro7.stringsRearrangement(t8));
            Assert.AreEqual(e9, ArcadeIntro7.stringsRearrangement(t9));
            Assert.AreEqual(e10, ArcadeIntro7.stringsRearrangement(t10));
            Assert.AreEqual(e11, ArcadeIntro7.stringsRearrangement(t11));
            Assert.AreEqual(e12, ArcadeIntro7.stringsRearrangement(t12));
        }

        [TestCase(new[] { 2, 4, 7 }, ExpectedResult = 4, Description = "Test Case 1")]
        [TestCase(new[] { 1, 1, 3, 4 }, ExpectedResult = 1, Description = "Test Case 2")]
        [TestCase(new[] { 23 }, ExpectedResult = 23, Description = "Test Case 3")]
        [TestCase(new[] { -10, -10, -10, -10, -10, -9, -9, -9, -8, -8, -7, -6, -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}, ExpectedResult = 15, Description = "Test Case 4")]
        [TestCase(new[] { -4, -1 }, ExpectedResult = -4, Description = "Test Case 5")]
        [TestCase(new[] { 0,7,9 }, ExpectedResult = 7, Description = "Test Case 6")]
        [TestCase(new[] { -1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000 }, ExpectedResult = 0, Description = "Test Case 7")]
        public int TestabsoluteValuesSumMinimization(int[] a)
        {
            return ArcadeIntro7.absoluteValuesSumMinimization(a);
        }

        [TestCase(100, 20, 170, ExpectedResult = 3, Description = "Test Case 1")]
        [TestCase(100, 1, 101, ExpectedResult = 1, Description = "Test Case 2")]
        [TestCase(1, 100, 64, ExpectedResult = 6, Description = "Test Case 3")]
        public int TestdepositProfit(int deposit, int rate, int threshold)
        {
            return ArcadeIntro7.depositProfit(deposit, rate, threshold);
        }

        [TestCase(10, 2, ExpectedResult = 7, Description = "Test Case 1")]
        [TestCase(10, 7, ExpectedResult = 2, Description = "Test Case 2")]
        [TestCase(4, 1, ExpectedResult = 3, Description = "Test Case 3")]
        [TestCase(6, 3, ExpectedResult = 0, Description = "Test Case 4")]
        public int TestcircleOfNumbers(int n, int firstNumber)
        {
            return ArcadeIntro7.circleOfNumbers(n, firstNumber);
        }
    }
}
