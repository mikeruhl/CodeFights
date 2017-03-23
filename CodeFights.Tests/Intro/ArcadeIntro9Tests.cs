using CodeFights.Intro;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{
    [Category("Arcade Introl Level 9")]
    [TestFixture]
    public class ArcadeIntro9Tests
    {
        [TestCase("a1", "c3", ExpectedResult = true, Description="L9.5.1")]
        [TestCase("h1", "h3", ExpectedResult = false, Description = "L9.5.2")]
        [TestCase("a5", "c3", ExpectedResult = true, Description = "L9.5.3")]
        [TestCase("g1", "f3", ExpectedResult = false, Description = "L9.5.4")]
        public bool TestbishopAndPawn(string bishop, string pawn)
        {
            return ArcadeIntro9.bishopAndPawn(bishop, pawn);
        }

        [TestCase(5, ExpectedResult = 0, Description = "L9.4.1")]
        [TestCase(100, ExpectedResult = 1, Description = "L9.4.2")]
        [TestCase(91, ExpectedResult = 2, Description = "L9.4.3")]
        [TestCase(99, ExpectedResult = 2, Description = "L9.4.4")]
        public int TestdigitDegree(int n)
        {
            return ArcadeIntro9.digitDegree(n);
        }

        [TestCase("123aa1", ExpectedResult = "123", Description = "L9.3.1")]
        [TestCase("0123456789", ExpectedResult = "0123456789", Description = "L9.3.2")]
        [TestCase("  3) always check for whitespaces", ExpectedResult = "", Description = "L9.3.3")]
        [TestCase("12abc34", ExpectedResult = "12", Description = "L9.3.4")]
        [TestCase("the output is 42", ExpectedResult = "", Description = "L9.3.5")]
        public string TestlongestDigitsPrefix(string inputString)
        {
            return ArcadeIntro9.longestDigitsPrefix(inputString);
        }

        [TestCase(10, 5, 6,4,8, ExpectedResult = 10, Description = "L9.2.1")]
        [TestCase(10,5,6,4,9, ExpectedResult = 16, Description = "L9.2.2")]
        [TestCase(10,2,11,3,1, ExpectedResult = 0, Description = "L9.2.3")]
        [TestCase(15, 2, 20,3,2, ExpectedResult = 15, Description = "L9.2.4")]
        [TestCase(2,5,3,4,5, ExpectedResult = 3, Description = "L9.2.5")]
        [TestCase(4,3,3,4,4, ExpectedResult = 4, Description = "L9.2.6")]
        [TestCase(3,5,3,8,10, ExpectedResult = 3, Description = "L9.2.7")]
        public int TestknapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            return ArcadeIntro9.knapsackLight(value1, weight1, value2, weight2, maxW);
        }

        [TestCase(100,10,910, ExpectedResult = 10, Description = "L9.1.1")]
        [TestCase(10, 9, 4, ExpectedResult = 1, Description = "L9.1.2")]
        public int TestgrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            return ArcadeIntro9.growingPlant(upSpeed, downSpeed, desiredHeight);
        }
    }
}
