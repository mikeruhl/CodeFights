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
    public class SpringOfIntegrationTests
    {

        #region SOI9TestCases

        private static List<ComplexTest<int[], string[]>> SOI9 = new List<ComplexTest<int[], string[]>>
        {
            new ComplexTest<int[], string[]>
            {
                Input = new[] {1, 3},
                ExpectedResult = new [] {"    *",
                    "    *",
                    "   ***",
                    "  *****",
                    " *******",
                    "*********",
                    "   ***"}
            },
            new ComplexTest<int[], string[]>
            {
                Input = new [] {2, 4},
                ExpectedResult = new [] {"      *",
                    "      *",
                    "     ***",
                    "    *****",
                    "   *******",
                    "  *********",
                    " ***********",
                    "   *******",
                    "  *********",
                    " ***********",
                    "*************",
                    "    *****",
                    "    *****"}
            },
            new ComplexTest<int[], string[]>
            {Input = new [] {4, 8},
                ExpectedResult = new [] {"            *",
                    "            *",
                    "           ***",
                    "          *****",
                    "         *******",
                    "        *********",
                    "       ***********",
                    "      *************",
                    "     ***************",
                    "    *****************",
                    "   *******************",
                    "         *******",
                    "        *********",
                    "       ***********",
                    "      *************",
                    "     ***************",
                    "    *****************",
                    "   *******************",
                    "  *********************",
                    "        *********",
                    "       ***********",
                    "      *************",
                    "     ***************",
                    "    *****************",
                    "   *******************",
                    "  *********************",
                    " ***********************",
                    "       ***********",
                    "      *************",
                    "     ***************",
                    "    *****************",
                    "   *******************",
                    "  *********************",
                    " ***********************",
                    "*************************",
                    "        *********",
                    "        *********",
                    "        *********",
                    "        *********"}
            }
        };
        #endregion
        [TestCaseSource("SOI9")]
        public void TestchristmasTree(ComplexTest<int[], string[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, SpringOfIntegration.christmasTree(test.Input[0], test.Input[1]));
        }


        [TestCase(new[] { 1, 4, 2 }, new[] { 27, 18, 24 }, ExpectedResult = 3, Description = "SpringOfIntegration.8.1")]
        [TestCase(new[] { 1, 4, 2 }, new[] { 5, 6, 2 }, ExpectedResult = 2, Description = "SpringOfIntegration.8.2")]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 1, 1 }, ExpectedResult = -1, Description = "SpringOfIntegration.8.3")]
        [TestCase(new[] { 1, 1000 }, new[] { 23, 22 }, ExpectedResult = 2, Description = "SpringOfIntegration.8.4")]
        public int TestrunnersMeetings(int[] startPosition, int[] speed)
        {
            return SpringOfIntegration.runnersMeetings(startPosition, speed);
        }

        [TestCase("Look at this example of a correct text", 5, 15, ExpectedResult = true, Description = "SpringOfIntegration.7.1")]
        [TestCase("abc def ghi", 4, 10, ExpectedResult = false, Description = "SpringOfIntegration.7.2")]
        [TestCase("a a a a a a a a", 1, 10, ExpectedResult = true, Description = "SpringOfIntegration.7.3")]
        [TestCase("ab cd fg xyz", 1, 5, ExpectedResult = false, Description = "SpringOfIntegration.7.4")]
        [TestCase("aa aa aaaaa aaaaa aaaaa", 6, 11, ExpectedResult = true, Description = "SpringOfIntegration.7.5")]
        public bool TestbeautifulText(string inputString, int l, int r)
        {
            return SpringOfIntegration.beautifulText(inputString, l, r);
        }


        [TestCase("cabca", ExpectedResult = 3, Description = "SpringOfIntegration.6.1")]
        [TestCase("aba", ExpectedResult = 2, Description = "SpringOfIntegration.6.2")]
        [TestCase("ccccccccccc", ExpectedResult = 1, Description = "SpringOfIntegration.6.3")]
        [TestCase("cabdcabdcabd", ExpectedResult = 4, Description = "SpringOfIntegration.6.C1")]
        [TestCase("abcdefghijklmnopqrstuvwxyzabc", ExpectedResult = 26, Description = "SpringOfIntegration.6.C2")]
        [TestCase("dogsfrankylikeshotdogsfrankylikes", ExpectedResult = 18, Description = "SpringOfIntegration.6.C3")]
        public int TestcyclicString(string s)
        {
            return SpringOfIntegration.cyclicString(s);
        }

        #region SOI5
        private static List<ComplexTest<object[], int>> SOI5 = new List<ComplexTest<object[], int>>
        {
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"abc",
                    "aaa",
                    "aba",
                    "bab"
                }, "bbb"},
                ExpectedResult = 2
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"aacccc",
                        "bbcccc"},
                    "abdddd" },
                ExpectedResult = 0
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"a",
                    "b",
                    "c",
                    "d",
                    "e"
                }, "c"},
                ExpectedResult = 4
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"aa",
                    "ab",
                    "ba"
                }, "bb"},
                ExpectedResult = 1
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"a",
                    "b",
                    "c",
                    "d",
                    "e"
                }, "f"},
                ExpectedResult = 0
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new[] {"aaa",
                    "aaa"
                }, "aaa"},
                ExpectedResult = 1
            }
        };
        #endregion
        [TestCaseSource("SOI5")]
        public void TeststringsCrossover(ComplexTest<object[], int> test)
        {
            var inputArray = (string[])test.Input[0];
            var result = (string)test.Input[1];
            Assert.AreEqual(test.ExpectedResult, SpringOfIntegration.stringsCrossover(inputArray, result));
        }

        [TestCase("*..*", "*.*", ExpectedResult = 5, Description = "SpringOfIntegration.4.1")]
        [TestCase("*...*", "*.*", ExpectedResult = 5, Description = "SpringOfIntegration.4.2")]
        [TestCase("*..*.*", "*.***", ExpectedResult = 9, Description = "SpringOfIntegration.4.3")]
        [TestCase("*.*", "*.*", ExpectedResult = 4, Description = "SpringOfIntegration.4.4")]
        [TestCase("*.**", "*.*", ExpectedResult = 5, Description = "SpringOfIntegration.4.5")]
        public int Testcombs(string comb1, string comb2)
        {
            return SpringOfIntegration.combs(comb1, comb2);
        }


        #region SOI3
        private static List<ComplexTest<int[][], bool>> SOI3 = new List<ComplexTest<int[][], bool>>
        {
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,21}, new[] {1, 23}, new[] {1, 21}, new[] {0, 23}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,21}, new[] {1, 23}, new[] {1, 21}, new[] {1, 23}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}, new[] {1, 21}, new[] {1, 23}, new[] {0, 21}, new[] {1, 22}, new[] {0, 22}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}, new[] {1, 21}, new[] {1, 23}, new[] {0, 21}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}, new[] {1, 21}, new[] {1, 23}, new[] {0, 21}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}},
                ExpectedResult = false
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}, new[] {1, 23}},
                ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new [] {new[] {0,23}, new[] {1, 22}},
                ExpectedResult = false
            }
        };
        #endregion

        [TestCaseSource("SOI3")]
        public void TestpairOfShoes(ComplexTest<int[][], bool> test)
        {
            Assert.AreEqual(test.ExpectedResult, SpringOfIntegration.pairOfShoes(test.Input));
        }


        [TestCase(new[] { 3, 5, 2, 4, 5 }, ExpectedResult = new[] { -1, 3, -1, 2, 4 }, Description = "SpringOfIntegration.2.1")]
        [TestCase(new[] { 2, 2, 1, 3, 4, 5, 5, 3 }, ExpectedResult = new[] { -1, -1, -1, 1, 3, 4, 4, 1 }, Description = "SpringOfIntegration.2.2")]
        [TestCase(new[] { 3, 2, 1 }, ExpectedResult = new[] { -1, -1, -1 }, Description = "SpringOfIntegration.2.3")]
        public int[] TestarrayPreviousLess(int[] items)
        {
            return SpringOfIntegration.arrayPreviousLess(items);
        }


        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, ExpectedResult = 186, Description = "SpringOfIntegration.1.1")]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = 64, Description = "SpringOfIntegration.1.2")]
        [TestCase(new[] { 3, 3, 5, 5 }, ExpectedResult = 60, Description = "SpringOfIntegration.1.3")]
        public int TestarrayConversion(int[] inputArray)
        {
            return SpringOfIntegration.arrayConversion(inputArray);
        }

    }
}
