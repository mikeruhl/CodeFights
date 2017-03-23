using System.Collections.Generic;
using CodeFights.Intro;
using CodeFights.Tests.Common;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{
    [TestFixture]
    public class ArcadeIntro7Tests
    {

        #region L72 Testcases
        private static List<ComplexTest<string[], bool>> L72 = new List<ComplexTest<string[], bool>>()
        {
            new ComplexTest<string[], bool>()
            {
                Input =  new[] {"aba", "bbb", "bab"},
                ExpectedResult = false
            },
    new ComplexTest<string[], bool>()
            {
                Input =  new[] {"ab", "bb", "aa"},
                ExpectedResult = true
            },
     new ComplexTest<string[], bool>()
            {
                Input =  new[] {"q", "q"},
                ExpectedResult = false
            },
      new ComplexTest<string[], bool>()
            {
                Input =  new[] {"zzzzab", "zzzzbb", "zzzzaa"},
                ExpectedResult = true
            },
       new ComplexTest<string[], bool>()
            {
                Input =  new[] {"ab", "ad", "ef", "eg"},
                ExpectedResult = false
            },
        new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abc", "abx", "axx", "abc"},
                ExpectedResult = false
            },
         new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abc","abx","axx","abx","abc"},
                ExpectedResult = true
            },
          new ComplexTest<string[], bool>()
            {
                Input =  new[] {"f","g","a","h"},
                ExpectedResult = true
            },
           new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abc", "abd", "xxx", "xyx", "abe"},
                ExpectedResult = false
            },
            new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abc", "bac", "bbc", "bbe", "bbd"},
                ExpectedResult = false
            },
             new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abbabbba", "abbabbca", "abbasbba", "abbsbbba", "acbabbba"},
                ExpectedResult = false
            },
              new ComplexTest<string[], bool>()
            {
                Input =  new[] {"abc", "xbc", "xxc", "xbc", "aby", "ayy", "aby"},
                ExpectedResult = true
            }
              }; 
#endregion

        [Description("L7.2")]
        [TestCaseSource("L72")]
        public void TeststringsRearrangement(ComplexTest<string[], bool> test)
        {
            Assert.AreEqual(test.ExpectedResult, ArcadeIntro7.stringsRearrangement(test.Input));
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
