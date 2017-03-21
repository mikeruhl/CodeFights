using NUnit.Framework;

namespace CodeFights.Tests
{
    [Category("Level3")]
    [TestFixture]
    public class ArcadeIntroOneToThreeTests
    {

        [Test]
        public void TestallLongestStrings()
        {
            var t1 = new[] {"aba", "aa", "ad", "vcd", "aba"};
            var e1 = new[]{"aba","vcd","aba"};

            var t2 = new[] {"aa"};
            var e2 = new[] {"aa"};

            var t3 = new[] {"abc", "eeee", "abcd", "dcd"};
            var e3 = new[] {"eeee", "abcd"};
            Assert.AreEqual(e1, ArcadeIntroOneToThree.allLongestStrings(t1));
            Assert.AreEqual(e2, ArcadeIntroOneToThree.allLongestStrings(t2));
            Assert.AreEqual(e3, ArcadeIntroOneToThree.allLongestStrings(t3));


        }

        [TestCase("a(bc)de", ExpectedResult ="acbde")]
        [TestCase("a(bcdefghijkl(mno)p)q", ExpectedResult = "apmnolkjihgfedcbq")]
        [TestCase("co(de(fight)s)", ExpectedResult = "cosfighted")]
        [TestCase("Code(Cha(lle)nge)", ExpectedResult = "CodeegnlleahC")]
        [TestCase("Where are the parentheses?", ExpectedResult = "Where are the parentheses?")]
        [TestCase("abc(cba)ab(bac)c", ExpectedResult = "abcabcabcabc")]
        public string TestreverseParentheses(string s)
        {
            var cfr = new ArcadeIntroOneToThree();
            return cfr.reverseParentheses(s);
        }

        [TestCase(new[] { -1, 150, 190, 170, -1, -1, 160, 180 }, ExpectedResult = new[] {-1, 150, 160, 170, -1, -1, 180, 190 })]
        [TestCase(new[] { -1, -1, -1, -1, -1 }, ExpectedResult = new[] { -1, -1, -1, -1, -1 })]
        [TestCase(new[] { 4, 2, 9, 11, 2, 16 }, ExpectedResult = new[] { 2, 2, 4, 9, 11, 16 })]
        public int[] TestsortByHeight(int[] a)
        {
            var cfr = new ArcadeIntroOneToThree();
            return cfr.sortByHeight(a);
        }

        [TestCase(1230, ExpectedResult = true)]
        [TestCase(239017, ExpectedResult = false)]
        [TestCase(134008, ExpectedResult = true)]
        public bool TestisLucky(int n)
        {
            var cfr = new ArcadeIntroOneToThree();
            return cfr.isLucky(n);
        }

        [Test]
        public void TestcommonCharacterCount()
        {
            var s1 = "aabcc";
            var s2 = "adcaa";

            var cfr = new ArcadeIntroOneToThree();

            Assert.AreEqual(3, cfr.commonCharacterCount(s1, s2));
        }
        [Test]
        public void TestmatrixElementsSum()
        {
            int[][] testone = {new[] {0, 1, 1, 2}, new[] {0, 5, 0, 0}, new[] {2, 0, 3, 3}};
            var testtwo = new[] { new[] { 1, 1, 1, 0 }, new[] { 0, 5, 0, 1 }, new[] { 2, 1, 3, 10 } };
            var testthree = new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } };
            var testfour = new[] {new[] {0}};

            var cfr = new ArcadeIntroOneToThree();

            Assert.AreEqual(9, cfr.matrixElementsSum(testone));
            Assert.AreEqual(9, cfr.matrixElementsSum(testtwo));
            Assert.AreEqual(18, cfr.matrixElementsSum(testthree));
            Assert.AreEqual(0, cfr.matrixElementsSum(testfour));
        }
    }
}
