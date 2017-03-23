using System.Collections.Generic;
using CodeFights.Intro;
using CodeFights.Tests.Common;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{


    [Category("Arcade Intro 12")]
    [TestFixture]
    public class ArcadeIntro12Tests
    {
        #region L12.9 TestCases
        static List<ComplexTest<int[][], bool>> L129 = new List<ComplexTest<int[][], bool>>
        {
            new ComplexTest<int[][], bool>()
            {
                Input = new[]{new[]{1,3,2,5,4,6,9,8,7}, 
 new[]{4,6,5,8,7,9,3,2,1}, 
 new[]{7,9,8,2,1,3,6,5,4}, 
 new[]{9,2,1,4,3,5,8,7,6}, 
 new[]{3,5,4,7,6,8,2,1,9}, 
 new[]{6,8,7,1,9,2,5,4,3}, 
 new[]{5,7,6,9,8,1,4,3,2}, 
 new[]{2,4,3,6,5,7,1,9,8}, 
 new[]{8,1,9,3,2,4,7,6,5}},
 ExpectedResult = true
            },
            new ComplexTest<int[][], bool>
            {
                Input = new[]{new[]{1,3,4,2,5,6,9,8,7}, 
 new[]{4,6,8,5,7,9,3,2,1}, 
 new[]{7,9,2,8,1,3,6,5,4}, 
 new[]{9,2,3,1,4,5,8,7,6}, 
 new[]{3,5,7,4,6,8,2,1,9}, 
 new[]{6,8,1,7,9,2,5,4,3}, 
 new[]{5,7,6,9,8,1,4,3,2}, 
 new[]{2,4,5,6,3,7,1,9,8}, 
 new[]{8,1,9,3,2,4,7,6,5}},
 ExpectedResult = false
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new[]{new[]{1,2,3,4,5,6,7,8,9}, 
 new[]{4,6,5,8,7,9,3,2,1}, 
 new[]{7,9,8,2,1,3,6,5,4}, 
 new[]{1,2,3,4,5,6,7,8,9}, 
 new[]{4,6,5,8,7,9,3,2,1}, 
 new[]{7,9,8,2,1,3,6,5,4}, 
 new[]{1,2,3,4,5,6,7,8,9}, 
 new[]{4,6,5,8,7,9,3,2,1}, 
 new[]{7,9,8,2,1,3,6,5,4}},
 ExpectedResult = false
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new[]{new[]{5,3,4,6,7,8,9,1,2}, 
 new[]{6,7,2,1,9,5,3,4,8}, 
 new[]{1,9,8,3,4,2,5,6,7}, 
 new[]{8,5,9,7,6,1,4,2,3}, 
 new[]{4,2,6,8,5,3,7,9,1}, 
 new[]{7,1,3,9,2,4,8,5,6}, 
 new[]{9,6,1,5,3,7,2,8,4}, 
 new[]{2,8,7,4,1,9,6,3,5}, 
 new[]{3,4,5,2,8,6,1,7,9}},
 ExpectedResult = true
            },
            new ComplexTest<int[][], bool>()
            {
                Input = new[]{new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}, 
 new[]{5,5,5,5,5,5,5,5,5}},
 ExpectedResult = false
            }
        };
        #endregion

        [TestCaseSource("L129")]
        public void Testsudoku(ComplexTest<int[][], bool> test)
        {
            Assert.AreEqual(test.ExpectedResult, ArcadeIntro12.sudoku(test.Input));
        }

        #region L12.8 TestCases
        static List<ComplexTest<int, int[][]>> L128 = new List<ComplexTest<int, int[][]>>
        {
            new ComplexTest<int, int[][]>{Input = 3, ExpectedResult = new[]{new[]{1,2,3}, new[]{8,9,4}, new []{7,6,5}}},
            new ComplexTest<int, int[][]>{Input = 5, ExpectedResult = new[]{new[]{1,2,3,4,5}, new[]{16,17,18,19,6}, new[]{15,24,25,20,7}, new[]{14,23,22,21,8}, new[]{13,12,11,10,9}}}
        };
        #endregion

        [TestCaseSource("L128")]
        public void TestspiralNumbers(ComplexTest<int, int[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ArcadeIntro12.spiralNumbers(test.Input));
        }


        [TestCase("010010000110010101101100011011000110111100100001", ExpectedResult = "Hello!", Description = "L12.7.1")]
        [TestCase("01001101011000010111100100100000011101000110100001100101001000000100011001101111011100100110001101100101001000000110001001100101001000000111011101101001011101000110100000100000011110010110111101110101", ExpectedResult = "May the Force be with you", Description = "L12.7.2")]
        [TestCase("010110010110111101110101001000000110100001100001011001000010000001101101011001010010000001100001011101000010000001100000011010000110010101101100011011000110111100101110", ExpectedResult = "You had me at `hello.", Description = "L12.7.3")]
        public string TestmessageFromBinaryCode(string code)
        {
            return ArcadeIntro12.messageFromBinaryCode(code);
        }

        #region L12.6 Tests

        private static List<ComplexTest<string[], string[]>> L126 = new List<ComplexTest<string[], string[]>>
        {
            new ComplexTest<string[], string[]>
            {
                Input = new []{"doc", 
 "doc", 
 "image", 
 "doc(1)", 
 "doc"},
 ExpectedResult = new[]{"doc", 
 "doc(1)", 
 "image", 
 "doc(1)(1)", 
 "doc(2)"}
            },
            new ComplexTest<string[], string[]>
            {
                Input = new []{"a(1)", 
 "a(6)", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a", 
 "a"},
 ExpectedResult = new[]{"a(1)", 
 "a(6)", 
 "a", 
 "a(2)", 
 "a(3)", 
 "a(4)", 
 "a(5)", 
 "a(7)", 
 "a(8)", 
 "a(9)", 
 "a(10)", 
 "a(11)"}
            },
            new ComplexTest<string[], string[]>
            {
                Input = new[]{"dd", 
 "dd(1)", 
 "dd(2)", 
 "dd", 
 "dd(1)", 
 "dd(1)(2)", 
 "dd(1)(1)", 
 "dd", 
 "dd(1)"},
 ExpectedResult = new[]{"dd", 
 "dd(1)", 
 "dd(2)", 
 "dd(3)", 
 "dd(1)(1)", 
 "dd(1)(2)", 
 "dd(1)(1)(1)", 
 "dd(4)", 
 "dd(1)(3)"}
            }
        };
        #endregion
        [TestCaseSource("L126")]
        public void TestfileNaming(ComplexTest<string[], string[]> names)
        {
            Assert.AreEqual(names.ExpectedResult, ArcadeIntro12.fileNaming(names.Input));
        }

        [TestCase(12, ExpectedResult = 26, Description = "L12.5.1")]
        [TestCase(19, ExpectedResult = -1, Description = "L12.5.2")]
        [TestCase(450, ExpectedResult = 2559, Description = "L12.5.3")]
        [TestCase(0, ExpectedResult = 10, Description = "L12.5.4")]
        [TestCase(13, ExpectedResult = -1, Description = "L12.5.5")]
        [TestCase(1, ExpectedResult = 1, Description = "L12.5.6")]
        public int TestdigitsProduct(int product)
        {
            return ArcadeIntro12.digitsProduct(product);
        }

        #region L124 TestCases

        private static List<ComplexTest<int[][], int>> L124 = new List<ComplexTest<int[][], int>>
        {
            new ComplexTest<int[][], int>
            {
                Input = new[]{new[]{1,2,1}, 
 new[]{2,2,2}, 
 new[]{2,2,2}, 
 new[]{1,2,3}, 
 new[]{2,2,1}},
                ExpectedResult = 6
            },
            new ComplexTest<int[][], int>
            {
                Input = new[]
                {
                    new[] {9, 9, 9, 9, 9},
                    new[] {9, 9, 9, 9, 9},
                    new[] {9, 9, 9, 9, 9},
                    new[] {9, 9, 9, 9, 9},
                    new[] {9, 9, 9, 9, 9},
                    new[] {9, 9, 9, 9, 9}
                },
                ExpectedResult = 1
            },
            new ComplexTest<int[][], int> {Input = new[] {new[] {3}}, ExpectedResult = 0},
            new ComplexTest<int[][], int> {Input = new[] {new[] {3, 4, 5, 6, 7, 8, 9}}, ExpectedResult = 0},
                new ComplexTest<int[][], int>
            {
                Input = new[]
                {
                    new[] {3},
                    new[] {4},
                    new[] {5},
                    new[] {6},
                    new[] {7}
                },
                ExpectedResult = 0
            },new ComplexTest<int[][], int>
            {
                Input = new[]
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
                }


                ,
                ExpectedResult = 54
            },
                new ComplexTest<int[][], int>
                {
                    Input = new[] {new[] {1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 2, 3, 9}},
                    ExpectedResult = 0
                }
        };
        #endregion
        [TestCaseSource("L124")]
        public void TestdifferentSquares(ComplexTest<int[][], int> matrix)
        {
            Assert.AreEqual(matrix.ExpectedResult, ArcadeIntro12.differentSquares(matrix.Input));
        }


        [TestCase("2 apples, 12 oranges", ExpectedResult = 14, Description = "L12.3.1")]
        [TestCase("123450", ExpectedResult = 123450, Description = "L12.3.2")]
        [TestCase("Your payment method is invalid", ExpectedResult = 0, Description = "L12.3.3")]
        public int TestsumUpNumbers(string inputString)
        {
            return ArcadeIntro12.sumUpNumbers(inputString);
        }


        [TestCase("13:58", ExpectedResult = true, Description = "L12.2.1")]
        [TestCase("25:51", ExpectedResult = false, Description = "L12.2.2")]
        [TestCase("02:76", ExpectedResult = false, Description = "L12.2.3")]
        [TestCase("24:00", ExpectedResult = false, Description = "L12.2.4")]
        public bool TestvalidTime(string time)
        {
            return ArcadeIntro12.validTime(time);
        }

        [TestCase("Ready, steady, go!", ExpectedResult = "steady", Description = "L12.1.1")]
        [TestCase("Ready[[[, steady, go!", ExpectedResult = "steady", Description = "L12.1.2")]
        [TestCase("ABCd", ExpectedResult = "ABCd", Description = "L12.1.3")]
        public string TestlongestWord(string text)
        {
            return ArcadeIntro12.longestWord(text);
        }

    }
}
