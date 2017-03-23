using CodeFights.Intro;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{
    [Category("ArcadeLevel8")]
    [TestFixture]
    public class ArcadeIntro8Tests
    {
        [TestCase(new[] { 2, 3, 5, 1, 6 }, 2, ExpectedResult = 8, Description = "L8.4.1")]
        [TestCase(new[] { 2, 4, 10, 1 }, 2, ExpectedResult = 14, Description = "L8.4.2")]
        [TestCase(new[] { 1, 3, 2, 4 }, 3, ExpectedResult = 9, Description = "L8.4.3")]
        [TestCase(new[] { 3, 2, 1, 1 }, 1, ExpectedResult = 3, Description = "L8.4.4")]
        public int TestarrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            return ArcadeIntro8.arrayMaxConsecutiveSum(inputArray, k);
        }


        [TestCase("cabca", ExpectedResult = 3, Description = "L8.3.1")]
        [TestCase("aba", ExpectedResult = 2, Description = "L8.3.2")]
        public int TestdifferentSymbolsNaive(string s)
        {
            return ArcadeIntro8.differentSymbolsNaive(s);
        }

        [TestCase("var_1__Int", ExpectedResult = '1', Description = "L8.2.1")]
        [TestCase("q2q-q", ExpectedResult = '2', Description = "L8.2.2")]
        [TestCase("0ss", ExpectedResult = '0', Description = "L8.2.3")]
        public char TestfirstDigit(string inputString)
        {
            return ArcadeIntro8.firstDigit(inputString);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, ExpectedResult = new []{ 1, 2, 4, 5, 7, 8, 10}, Description = "L8.1.1")]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, 1, ExpectedResult = new int[] {}, Description = "L8.1.2")]
        [TestCase(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 2, ExpectedResult = new[] { 1, 1, 1, 1 }, Description = "L8.1.3")]
        public int[] TestextractEachKth(int[] inputArray, int k)
        {
            return ArcadeIntro8.extractEachKth(inputArray, k);
        }
    }
}
