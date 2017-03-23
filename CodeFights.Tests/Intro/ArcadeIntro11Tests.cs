using CodeFights.Intro;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{
    [TestFixture]
    public class ArcadeIntro11Tests
    {
        [TestCase(152, ExpectedResult = 52, Description = "L11.4.1")]
        [TestCase(1001, ExpectedResult = 101, Description = "L11.4.2")]
        [TestCase(10, ExpectedResult = 1, Description = "L11.4.3")]
        public int TestdeleteDigit(int n)
        {
            return ArcadeIntro11.deleteDigit(n);
        }

        [TestCase("a1", ExpectedResult = 2, Description = "L11.3.1")]
        [TestCase("c2", ExpectedResult = 6, Description = "L11.3.2")]
        [TestCase("d4", ExpectedResult = 8, Description = "L11.3.3")]
        [TestCase("g6", ExpectedResult = 6, Description = "L11.3.4")]
        public int TestchessKnight(string cell)
        {
            return ArcadeIntro11.chessKnight(cell);
        }

        [TestCase("aabbbc", ExpectedResult = "2a3bc", Description = "L11.2.1")]
        [TestCase("abbcabb", ExpectedResult = "a2bca2b", Description = "L11.2.2")]
        [TestCase("abcd", ExpectedResult = "abcd", Description = "L11.2.3")]
        public string TestlineEncoding(string s)
        {
            return ArcadeIntro11.lineEncoding(s);
        }

        [TestCase('9', ExpectedResult = true, Description = "L11.1.1")]
        [TestCase('-', ExpectedResult = false, Description = "L11.1.2")]
        [TestCase('0', ExpectedResult = true, Description = "L11.1.3")]
        public bool TestisDigit(char symbol)
        {
            return ArcadeIntro11.isDigit(symbol);
        }

    }
}
