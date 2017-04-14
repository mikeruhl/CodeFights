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
    public class WellOfIntegrationTests
    {
        [TestCase(new[] { 0, -1, 0, -1, 0, -1 }, ExpectedResult = 4, Description = "WellOfIntegration.12.1")]
        [TestCase(new[] { -1, 0, -1, 0, -1, 0 }, ExpectedResult = 4, Description = "WellOfIntegration.12.2")]
        [TestCase(new[] { -1, 1, -1, 1, -1, 1, -1, 1 }, ExpectedResult = 3, Description = "WellOfIntegration.12.3")]
        [TestCase(new[] { 184138, -37745, 82759, 14851, 79647, -91351, -9413, 84612, -101031, -181203, -162841, -14357, -122060, -56837, -59344, 95670, 19230, -197053, -151794, -12451, 1512, 108952, -155189, -8121, 43054, -25951, 125440, 28768, -42373, 188365, 150867, -38140, 61777, 186009, 93565, -76218, -133893, -103795, -187274, -175627, -170204, -30250, 151764, 92036, 9080, 41271, -34582, 75906, -176277, 179547, 152773, 27776, -70639, -186460, 134040, 135416, 196278, 15198, -167083, 190726, 175444, -25970, -37584, 130247, 163481, -78746, 123875, -127859, 63643, 131400, 177022, -51120, -33714, -64067, -153262, -152369, -51938, 173432, -101008, 124992, -151945, -170175, 182191, 144348, -43276, -29398, 143683, 4763, 164814, 195818, 28225, 180864, -127334, 37600, 184790, 4152, 199588, 133654, -18816, -121196, -67769, 112234, 57594, 90858, 199031, 184334, 112916, 130951, -181948, -61114, 74154, -44010, 164849, 163083, -165563, 34566, -103124, 185075, 28700, -196978, -192354, -17883, -142522, -83792, 43765, -183610, 44134, -22779, 192282, 115221, 12296, 20731, 98280, -89394, 72800, -110352, -6289, 54054, 151191, 53169, 12397, -77496, 76249, 40497, 8377, -134898, 1345, -49669, 72688, 181648, 113789, -91593, -85917, 85401, 76632, -71710, 106722, -128521, -119048, 37976, -72773, 34432, 40118, -153781, 163824, 149927, -83901, 58599, 114268, -195468, 101292, 37934, 163551, -51514, 93980, -178182, -152702, -76796, -114697, 31344, -51611, -4632, -85532, -188408, 163967, 83255, 34003, -175284, -60057, 15142, 175259, 194554, -115806, 47879, 6083, -181421, 31385, -154069, -280, 187971 }, ExpectedResult = 0, Description = "WellOfIntegration.12.4")]
        public int TestthreeSplit(int[] a)
        {
            return WellOfIntegration.threeSplit(a);
        }

        [TestCase("123_456_789", ExpectedResult = true, Description = "WellOfIntegration.12.1")]
        [TestCase("16#123abc#", ExpectedResult = true, Description = "WellOfIntegration.12.2")]
        [TestCase("10#123abc#", ExpectedResult = false, Description = "WellOfIntegration.12.3")]
        [TestCase("10#10#123ABC#", ExpectedResult = false, Description = "WellOfIntegration.12.4")]
        [TestCase("10#0#", ExpectedResult = true, Description = "WellOfIntegration.12.5")]
        [TestCase("10##", ExpectedResult = false, Description = "WellOfIntegration.12.6")]
        [TestCase("16#1234567890ABCDEFabcdef#", ExpectedResult = true, Description = "WellOfIntegration.12.7")]
        [TestCase("1600#", ExpectedResult = false, Description = "WellOfIntegration.12.8")]
        [TestCase("7#???#", ExpectedResult = false, Description = "WellOfIntegration.12.9")]
        [TestCase("4#4#", ExpectedResult = false, Description = "WellOfIntegration.12.10")]
        [TestCase("3454235ab534", ExpectedResult = false, Description = "WellOfIntegration.12.11")]
        [TestCase("1#0#", ExpectedResult = false, Description = "WellOfIntegration.12.12")]
        [TestCase("17#ac#", ExpectedResult = false, Description = "WellOfIntegration.12.13")]
        [TestCase("2#10110#", ExpectedResult = true, Description = "WellOfIntegration.12.14")]
        [TestCase("2#10110", ExpectedResult = false, Description = "WellOfIntegration.12.15")]
        [TestCase("#2#10110", ExpectedResult = false, Description = "WellOfIntegration.12.16")]
        [TestCase("#2#10110#", ExpectedResult = false, Description = "WellOfIntegration.12.17")]
        public bool TestadaNumber(string line)
        {
            return WellOfIntegration.adaNumber(line);
        }


        [TestCase(1234, 2, ExpectedResult = "34", Description = "WellOfIntegration.10.1")]
        [TestCase(1234, 4, ExpectedResult = "1234", Description = "WellOfIntegration.10.2")]
        [TestCase(1234, 5, ExpectedResult = "01234", Description = "WellOfIntegration.10.3")]
        [TestCase(0, 1, ExpectedResult = "0", Description = "WellOfIntegration.10.4")]
        public string TestintegerToStringOfFixedWidth(int number, int width)
        {
            return WellOfIntegration.integerToStringOfFixedWidth(number, width);
        }

        [TestCase(4, "The Fox asked the stork, 'How is the soup?'", ExpectedResult = 7, Description = "WellOfIntegration.8.1")]
        [TestCase(1, "...", ExpectedResult = 0, Description = "WellOfIntegration.8.2")]
        [TestCase(3, "This play was good for us.", ExpectedResult = 3, Description = "WellOfIntegration.8.3")]
        [TestCase(3, "Suddenly he stopped, and glanced up at the houses", ExpectedResult = 5, Description = "WellOfIntegration.8.4")]
        [TestCase(6, "Zebras evolved among the Old World horses within the last four million years.", ExpectedResult = 11, Description = "WellOfIntegration.8.5")]
        [TestCase(5, "Although zebra species may have overlapping ranges, they do not interbreed.", ExpectedResult = 6, Description = "WellOfIntegration.8.6")]
        [TestCase(1, "Oh!", ExpectedResult = 0, Description = "WellOfIntegration.8.7")]
        [TestCase(5, "Now and then, however, he is horribly thoughtless, and seems to take a real delight in giving me pain.", ExpectedResult = 14, Description = "WellOfIntegration.8.8")]
        public int TesttimedReading(int maxLength, string text)
        {
            return WellOfIntegration.timedReading(maxLength, text);
        }

        [TestCase(new[] { 1, 1, 1, 1, 1 }, ExpectedResult = new[] { 0, 1, 0, 1, 0 }, Description = "WellOfIntegration.7.1")]
        [TestCase(new[] { 0, 0 }, ExpectedResult = new[] { 0, 0 }, Description = "WellOfIntegration.7.2")]
        [TestCase(new[] { 1, 0, 0, 1, 0, 1, 0, 1 }, ExpectedResult = new[] { 1, 1, 1, 0, 0, 1, 1, 0 }, Description = "WellOfIntegration.7.3")]
        [TestCase(new[] { 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1 }, ExpectedResult = new[] { 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 }, Description = "WellOfIntegration.7.4")]
        public int[] TestswitchLights(int[] a)
        {
            return WellOfIntegration.switchLights(a);
        }

        [TestCase(new[] { 1, 2, 10 }, 28, ExpectedResult = 6, Description = "WellOfIntegration.5.1")]
        [TestCase(new[] { 1, 5, 10, 100 }, 239, ExpectedResult = 10, Description = "WellOfIntegration.5.2")]
        public int TestminimalNumberOfCoins(int[] coins, int price)
        {
            return WellOfIntegration.minimalNumberOfCoins(coins, price);
        }

        [TestCase("effg", ExpectedResult = false, Description = "WellOfIntegration.4.1")]
        [TestCase("cdce", ExpectedResult = false, Description = "WellOfIntegration.4.2")]
        [TestCase("ace", ExpectedResult = true, Description = "WellOfIntegration.4.3")]
        public bool TestalphabetSubsequence(string s)
        {
            return WellOfIntegration.alphabetSubsequence(s);
        }

        [TestCase(6, ExpectedResult = new[] { 1, 3 }, Description = "WellOfIntegration.3.1")]
        [TestCase(2, ExpectedResult = new[] { 1 }, Description = "WellOfIntegration.3.2")]
        [TestCase(8, ExpectedResult = new[] { 0, 2, 4 }, Description = "WellOfIntegration.3.3")]
        [TestCase(4, ExpectedResult = new[] { 0, 2 }, Description = "WellOfIntegration.3.4")]
        [TestCase(44, ExpectedResult = new[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 }, Description = "WellOfIntegration.3.5")]
        public int[] TesthouseOfCats(int legs)
        {
            return WellOfIntegration.houseOfCats(legs);
        }


        #region WellOfIntegration2Tests
        static List<ComplexTest<string[], string[]>> WoI2 = new List<ComplexTest<string[], string[]>>()
        {
            new ComplexTest<string[], string[]>()
            {
              Input  = new[]{"aba","aa","ad","vcd","aba"},
              ExpectedResult = new[]{"aba","vcd","aba"}
            },
            new ComplexTest<string[], string[]>()
            {
              Input  = new[]{"aa"},
              ExpectedResult = new[]{"aa"}
            },
            new ComplexTest<string[], string[]>()
            {
              Input  = new[]{"abc","eeee","abcd","dcd"},
              ExpectedResult = new[]{"eeee","abcd"}
            }
        };
        #endregion
        [TestCaseSource("WoI2")]
        public void TestallLongestStrings(ComplexTest<string[], string[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, WellOfIntegration.allLongestStrings(test.Input));
        }

        [TestCase(new[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }, ExpectedResult = 11, Description = "WellOfIntegration.1.1")]
        [TestCase(new[] { 4, 2, 1, 6, 0 }, ExpectedResult = 13, Description = "WellOfIntegration.1.2")]
        [TestCase(new[] { 4, 1, 2, 3, 0, 10, 2 }, ExpectedResult = 10, Description = "WellOfIntegration.1.3")]
        public int TesthouseNumbersSum(int[] inputArray)
        {
            return WellOfIntegration.houseNumbersSum(inputArray);
        }


    }
}
