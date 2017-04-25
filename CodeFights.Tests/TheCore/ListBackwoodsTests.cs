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
    public class ListBackwoodsTests
    {
        #region LB08T
        private static List<ComplexTest<object[], int[][]>> LB08T = new List<ComplexTest<object[], int[][]>>
        {
            new ComplexTest<object[], int[][]>
            {
                Input = new object[]
                {
                    new[] {new[] { 1,0,0,2,0,0,3},
                        new[] {0,1,0,2,0,3,0},
                        new[] {0,0,1,2,3,0,0},
                        new[] {8,8,8,9,4,4,4},
                        new[] {0,0,7,6,5,0,0},
                        new[] {0,7,0,6,0,5,0},
                            new[] {7,0,0,6,0,0,5}},
                    7,
                    new[] {3, 3}, 1
                },
                ExpectedResult = new [] {new[] { 8,0,0,1,0,0,2},
                    new[] {0,8,0,1,0,2,0},
                    new[] {0,0,8,1,2,0,0},
                    new[] {7,7,7,9,3,3,3},
                    new[] {0,0,6,5,4,0,0},
                    new[] {0,6,0,5,0,4,0},
                    new[] {6,0,0,5,0,0,4}}
            },
            new ComplexTest<object[], int[][]> //2
            {
                Input = new object[]
                {
                    new[] {new[] { 1,0,0,2,0,0,3},
                            new[] {0,1,0,2,0,3,0},
                                new[] {0,0,1,2,3,0,0},
                                    new[] {8,8,8,9,4,4,4},
                                        new[] {0,0,7,6,5,0,0}
                    },
                    3,
                    new[] {1, 5}, 81
                },
                ExpectedResult = new [] {new[] { 1,0,0,2,0,0,0},
                    new[] {0,1,0,2,3,3,3},
                    new[] {0,0,1,2,0,0,0},
                    new[] {8,8,8,9,4,4,4},
                    new[] {0,0,7,6,5,0,0}}
            },
            new ComplexTest<object[], int[][]> //3
            {
                Input = new object[]
                {
                    new[] {new[] { 1,0,0,2,0,0,3},
                        new[] {0,1,0,2,0,3,0},
                        new[] {0,0,1,2,3,0,0},
                        new[] {8,8,8,9,4,4,4},
                        new[] {0,0,7,6,5,0,0},
                        new[] {0,7,0,6,0,5,0},
                        new[] {7,0,0,6,0,0,5}},
                    3,
                    new[] {3, 3}, 15
                },
                ExpectedResult = new [] {new [] {1,0,0,2,0,0,3},
                    new [] {0,1,0,2,0,3,0},
                    new [] {0,0,2,3,4,0,0},
                    new [] {8,8,1,9,5,4,4},
                    new [] {0,0,8,7,6,0,0},
                    new [] {0,7,0,6,0,5,0},
                    new [] {7,0,0,6,0,0,5}}
            },
            new ComplexTest<object[], int[][]> //4
            {
                Input = new object[]
                {
                    new[] {new int[] { 1,0,3},
                        new[] { 3,4,5},
                        new[] { 8,99,0}},
                    3,
                    new[] {1, 1}, 4
                },
                ExpectedResult = new[] {new[] { 0,99,8},
                    new[] {5,4,3},
                    new[] {3,0,1}}
            },
            new ComplexTest<object[], int[][]> //5
            {
                Input = new object[]
                {
                    new[] {new[] { 8,16,32},
                          new[] { 1,0,3},
                          new[] { 3,4,5},
                          new[] { 8,99,0},
                          new[] { 42,56,64}},
                    3,
                    new[] {2, 1}, 12
                },
                ExpectedResult = new [] {new[] {8,16,32},
                    new[] {0,99,8},
                    new[] {5,4,3},
                    new[] {3,0,1},
                    new[] {42,56,64}}
            },
            new ComplexTest<object[], int[][]> //6
            {
                Input = new object[]
                {
                    new[] { new[]{ 1,0,0,2,0,7,3,1,24,0,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,7,3,1,25,0,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,99,3,1,0,0,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,8,3,1,0,54,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,7,3,1,0,88,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,88,3,1,0,0,2,0,0,3,4},
                        new[]{ 1,0,0,2,0,99,3,1,0,0,2,0,0,3,4}
                    },
                    5,
                    new[] {3, 4}, 1
                },
                ExpectedResult = new [] {new[]{1,0,0,2,0,7,3,1,24,0,2,0,0,3,4 },
                    new[]{1,0,0,2,0,7,0,1,25,0,2,0,0,3,4 },
                    new[]{1,0,0,2,2,0,3,1,0,0,2,0,0,3,4  },
                    new[]{1,0,0,2,0,99,3,1,0,54,2,0,0,3,4},
                    new[]{1,0,0,0,7,8,3,1,0,88,2,0,0,3,4 },
                    new[]{1,0,0,2,3,88,3,1,0,0,2,0,0,3,4 },
                    new[]{1,0,0,2,0,99,3,1,0,0,2,0,0,3,4 }
            }

        }};
        #endregion
        [TestCaseSource("LB08T")]
        public void TeststarRotation(ComplexTest<object[], int[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.starRotation((int[][])test.Input[0], (int)test.Input[1], (int[])test.Input[2], (int)test.Input[3]));
        }

        #region LB07T

        private static List<ComplexTest<object[], string[][]>> LB07T = new List<ComplexTest<object[], string[][]>>
        {
            new ComplexTest<object[], string[][]>
            {
                Input = new object[]
                {
                    new[]
                    {
                        new[] {"empty", "Player5", "empty"},
                        new[] {"Player4", "empty", "Player2"},
                        new[] {"empty", "Player3", "empty"},
                        new[] {"Player6", "empty", "Player1"}
                    },
                    2
                },
                ExpectedResult = new string[][]
                {
                    new[] {"empty", "Player1", "empty"},
                    new[] {"Player2", "empty", "Player3"},
                    new[] {"empty", "Player4", "empty"},
                    new[] {"Player5", "empty", "Player6"}
                }
            },
            new ComplexTest<object[], string[][]>
            {
                Input = new object[]
                {
                    new[]
                    {
                        new[] {"empty", "Alice", "empty"},
                        new[] {"Bob", "empty", "Charlie"},
                        new[] {"empty", "Dave", "empty"},
                        new[] {"Eve", "empty", "Frank"}

                    },
                    6
                },
                ExpectedResult = new string[][] {new[] {"empty", "Alice", "empty"},
                    new[] {"Bob", "empty", "Charlie"},
                    new[] {"empty","Dave","empty"},
                    new[] {"Eve", "empty", "Frank"}
    }
},
            new ComplexTest<object[], string[][]>
            {
                Input = new object[]
                {
                    new[] {new[] { "empty","player 3","empty"},
                            new[] {"player 3","empty","player"},
                                new[] {"empty","4","empty"},
                                    new[] {"5","empty","42"}
                    },
                    1000000
                },
                ExpectedResult = new string[][] {new[] { "empty","5","empty"},
                        new[] {"4","empty","player 3"},
                            new[] {"empty","player","empty"},
                                new[] {"42","empty","player 3"}
            }
            },
            new ComplexTest<object[], string[][]>
            {
                Input = new object[]
                {
                    new[] {new[] { "empty","player 3","empty"},
                        new[] {"player 8","empty","player"},
                        new[] {"empty","4","empty"},
                        new[] {"5","empty","42"}
                    },
                    0
                },
                ExpectedResult   = new string[][] {new[] {"empty","player 3","empty"},
                    new[] {"player 8","empty","player"},
                    new[] {"empty","4","empty"},
                    new[] {"5","empty","42"}}
            },
            new ComplexTest<object[], string[][]>
            {
                Input = new object[]
                {
                    new[] {new[] { "empty","player 3","empty"},
                        new[] {"player 8","empty","player"},
                        new[] {"empty","4","empty"},
                        new[] {"5","empty","42"}
                    },
                    1000000000
                },
                ExpectedResult   = new string[][] {new[] { "empty","5","empty"},
                    new[] {"4","empty","player 8"},
                    new[] {"empty","player","empty"},
                    new[] {"42","empty","player 3"}}
            }
        };
        #endregion
        [TestCaseSource("LB07T")]
        public void TestvolleyballPositions(ComplexTest<object[], string[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.volleyballPositions((string[][])test.Input[0], (int)test.Input[1]));
        }

        #region LB06T

        private static List<ComplexTest<object[], char[][]>> LB06T = new List<ComplexTest<object[], char[][]>>
        {
            new ComplexTest<object[], char[][]>
            {
                Input = new object[]
                {
                    new[] {new []{ 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
                        new[] { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
                        new[] { 'a','a','a','a','a','a','a','a'},
                    new[] {'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'},
                    new[] {'b','b','b','b','b','b','b','b'}
                }, new []{1, 1, 4, 3}},
                ExpectedResult = new [] {new[] { 'a','a','a','a','a','a','a','a'},
                    new[] { 'a','*','-','-','*','a','a','a'},
                    new [] { 'a','|','a','a','|','a','a','a'},
                   new [] { 'b','*','-','-','*','b','b','b'},
                    new[] { 'b','b','b','b','b','b','b','b'}}
            },
            new ComplexTest<object[], char[][]>
            {
                Input = new object[]
                {
                    new[] {new []{ 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
                        new[] { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
                        new[] { 'a','a','a','a','a','a','a','a'},
                        new[] {'b','b','b','b','b','b','b','b'}
                    }, new []{0, 0, 1, 1}},
                ExpectedResult = new [] {new[] { '*','*','a','a','a','a','a','a'},
                    new[] { '*','*','a','a','a','a','a','a'},
                    new [] {'a','a','a','a','a','a','a','a'},
                    new []{'b','b','b','b','b','b','b','b'}
            }},
            new ComplexTest<object[], char[][]>
            {
                Input = new object[]
                {new[] {
                    new[] {'a','a','a','a','a','a','a','a'},
                    new[] {'a','a','a','a','a','a','a','a'},
                    new[] { 'a','a','a','a','a','a','a','a'},
                    new[] { 'b','b','b','b','b','b','b','b'}

                    }, new []{0, 2, 7, 3}},
                ExpectedResult = new [] {new[] { 'a','a','a','a','a','a','a','a'},
                    new[] { 'a','a','a','a','a','a','a','a'},
                    new [] { '*','-','-','-','-','-','-','*'},
                    new[] { '*','-','-','-','-','-','-','*'}
                }},
            new ComplexTest<object[], char[][]>
            {
                Input = new object[]
                {new[] {
                    new[] {'a','a','a'},
                    new [] { 'a','a','a'},
                    new [] { 'a','a','a'},
                    new [] {'b','b','b'}


                }, new []{0, 0, 2, 3}},
                ExpectedResult = new [] {new[] { '*','-','*'},
                    new [] { '|','a','|'},
                    new [] { '|','a','|'},
                    new [] { '*','-','*'}
                }}

        };
        #endregion

        [TestCaseSource("LB06T")]
        public void TestdrawRectangle(ComplexTest<object[], char[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.drawRectangle((char[][])test.Input[0], (int[])test.Input[1]));
        }

        #region LB05T
        private static List<ComplexTest<object[], int>> LB05T = new List<ComplexTest<object[], int>>
        {
            new ComplexTest<object[], int>
            {
                Input = new object[] {new [] { new[] {1,1,1,1}, new[] {2, 2, 2, 2}, new[] {3, 3, 3, 3}}, 1, 3},
                ExpectedResult = 12
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new [] { new[] {1,1}, new[] {1,1}}, 0, 0},
                ExpectedResult = 3
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new [] { new[] {1,1}, new[] {3,3}, new[] {1,1}, new[] { 2, 2 } }, 3, 0},
                ExpectedResult = 9
            },
            new ComplexTest<object[], int>
            {
                Input = new object[] {new [] { new[] {100}}, 0, 0},
                ExpectedResult = 100
            }
        };
        #endregion
        [TestCaseSource("LB05T")]
        public void TestcrossingSum(ComplexTest<object[], int> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.crossingSum((int[][])test.Input[0], (int)test.Input[1], (int)test.Input[2]));
        }


        #region LB04T
        private static List<ComplexTest<int[][], int[][]>> LB04T = new List<ComplexTest<int[][], int[][]>>
        {
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {1, 2, 3}, new[] { 4, 5, 6 }, new [] {7, 8, 9}},
                ExpectedResult = new [] {new[] {3, 2, 1}, new[] {4, 5, 6}, new[] {9, 8, 7}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {239}},
                ExpectedResult = new [] {new[] {239}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {1, 10}, new[] { 100, 1000 }},
                ExpectedResult = new [] {new[] {10, 1}, new[] {1000, 100}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {43, 455, 32, 103}, new[] {102, 988, 298, 981 }, new [] {309, 21, 53, 64}, new [] {2, 22, 35, 291}},
                ExpectedResult = new [] {new[] { 103, 455, 32, 43},new[] {102,298,988,981},new[] {309,53,21,64},new [] {291,22,35,2}}
            }
        };
        #endregion
        [TestCaseSource("LB04T")]
        public void TestswapDiagonals(ComplexTest<int[][], int[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.swapDiagonals(test.Input));
        }

        #region LB03T
        private static List<ComplexTest<int[][], int[][]>> LB03T = new List<ComplexTest<int[][], int[][]>>
        {
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {1, 2, 3}, new[] { 4, 5, 6 }, new [] {7, 8, 9}},
                ExpectedResult = new [] {new[] {9,2,7}, new[] {4, 5, 6}, new[] {3,8,1}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {239}},
                ExpectedResult = new [] {new[] {239}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {1, 10}, new[] { 100, 1000 }},
                ExpectedResult = new [] {new[] {1000, 100}, new[] {10, 1}}
            },
            new ComplexTest<int[][], int[][]>
            {
                Input = new[] {new[] {43, 455, 32, 103}, new[] {102, 988, 298, 981 }, new [] {309, 21, 53, 64}, new [] {2, 22, 35, 291}},
                ExpectedResult = new [] {new[] { 291,455,32,2},new[] {102,53,21,981},new[] {309,298,988,64},new [] {103,22,35,43}}
            }
        };
        #endregion
        [TestCaseSource("LB03T")]
        public void TestreverseOnDiagonals(ComplexTest<int[][], int[][]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.reverseOnDiagonals(test.Input));
        }


        #region LB02T

        private static List<ComplexTest<object[], bool>> LB02T = new List<ComplexTest<object[], bool>>
        {
            new ComplexTest<object[], bool>
            {
                Input = new object[] {new [] {new [] {1, 1, 1}, new [] {0, 0}}, new [] {new [] {2, 1, 1}, new [] {2, 1}}},
                ExpectedResult = true
            },
            new ComplexTest<object[], bool>
            {
                Input = new object[] {new [] {new [] {2}, new int[] {}}, new [] {new [] {2}}},
                ExpectedResult = false
            },
            new ComplexTest<object[], bool>
            {
                Input = new object[] {new [] {new [] {2}, new [] {1}, new[] { 3, 5 } }, new [] {new int[] {}, new [] {1}, new[] { 1,6} } },
                ExpectedResult = false
            },
            new ComplexTest<object[], bool>
            {
                Input = new object[] {new [] {new [] {1, 1, 1}, new [] {0, 0}}, new [] {new [] {2, 1, 3}, new [] {2, 1}, new int[] {}}},
                ExpectedResult = false
            },
            new ComplexTest<object[], bool>
            {
                Input = new object[] {new [] {new int[] {}, new [] {1}}, new [] {new int[] {}, new [] {6, 2, 5}}},
                ExpectedResult = false
            }
        };
        #endregion
        [TestCaseSource("LB02T")]
        public void TestareIsomorphic(ComplexTest<object[], bool> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.areIsomorphic((int[][])test.Input[0], (int[][])test.Input[1]));
        }

        #region LB01T

        private static List<ComplexTest<object[], int[]>> LB01T = new List<ComplexTest<object[], int[]>>
        {
            new ComplexTest<object[], int[]>
            {
                Input = new object[] {new[] { new[] {1, 1, 1, 2}, new[] {0, 5, 0, 4}, new[] {2, 1,3, 6}}, 2},
                ExpectedResult = new [] {1, 0, 3}
            },
            new ComplexTest<object[], int[]>
            {
            Input = new object[] {new[] { new[] {1, 1, 1}, new[] {0, 5, 0}, new[] {2, 1, 3}}, 2},
ExpectedResult = new [] {1, 0, 3}
},
            new ComplexTest<object[], int[]>
            {
                Input = new object[] {new[] { new[] {1, 1}, new[] {5, 0}, new[] {2,3}}, 0},
                ExpectedResult = new [] {1, 5, 2}
            }
        };
        #endregion
        [TestCaseSource("LB01T")]
        public void TestextractMatrixColumn(ComplexTest<object[], int[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, ListBackwoods.extractMatrixColumn((int[][])test.Input[0], (int)test.Input[1]));
        }
    }
}
