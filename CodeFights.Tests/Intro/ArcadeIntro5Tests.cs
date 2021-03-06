﻿using System.Collections.Generic;
using CodeFights.Intro;
using CodeFights.Tests.Common;
using NUnit.Framework;

namespace CodeFights.Tests.Intro
{
    [Category("Level 5")]
    [TestFixture]
    public class ArcadeIntro5Tests
    {

        #region L56 Testcases
        private static List<ComplexTest<bool[][], int[][]>> L56 = new List<ComplexTest<bool[][], int[][]>>()
        {
            new ComplexTest<bool[][], int[][]>()
            {
                Input = new [] { new [] { true, false, false }, new [] { false, true, false }, new [] { false, false, false } },
                ExpectedResult = new[]{ new[] { 1, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 1, 1 } }
            },
            new ComplexTest<bool[][], int[][]>()
            {
                Input = new [] { new[] { false, false, false }, new[] { false, false, false } },
                ExpectedResult = new[]{ new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }
            },
            new ComplexTest<bool[][], int[][]>()
            {
                Input = new [] { new[] {true, false, false, true},
                new[] {false, false, true, false},
                new[] {true, true, false, true} },
                ExpectedResult = new[]{ new[] {0, 2, 2, 1},
                new[] {3, 4, 3, 3},
                new[] {1, 2, 3, 1} }
            }

        };
#endregion
        [TestCaseSource("L56")]
        [Description("L5.6")]
        public void Testminesweeper(ComplexTest<bool[][], int[][]> test)
        {
           
            Assert.AreEqual(test.ExpectedResult, ArcadeIntro5.minesweeper(test.Input));
        }

        #region L55 Testcases

        private static List<ComplexTest<int[][], int[][]>> L55 = new List<ComplexTest<int[][], int[][]>>()
        {
            new ComplexTest<int[][], int[][]>()
            {
                Input = new [] {new[] {1, 1, 1},
            new[] {1, 7, 1},
            new[] {1, 1, 1}},
                ExpectedResult =  new[] { new[]{1}}
            },
            new ComplexTest<int[][], int[][]>()
            {
                Input = new [] { new[] {0, 18, 9},
            new[] {27, 9, 0},
            new[] {81, 63, 45}},
                ExpectedResult =  new[] { new[] {28}}
            },
            new ComplexTest<int[][], int[][]>()
            {
                Input = new [] {  new[] {36, 0, 18, 9},
            new[] {27, 54, 9, 0},
            new[] {81, 63, 72, 45}},
                ExpectedResult =  new[] {  new[] {40, 30}}
            },
            new ComplexTest<int[][], int[][]>()
            {
                Input = new [] { new[] {7, 4, 0, 1},
            new[] {5, 6, 2, 2},
            new[] {6, 10, 7, 8},
            new[] {1, 4, 2, 0}},
                ExpectedResult =  new[] { new[] {5,4},
            new[] {4,4}}
            },
            new ComplexTest<int[][], int[][]>()
            {
                Input = new [] {new[] {36, 0, 18, 9, 9, 45, 27},
            new[] {27, 0, 54, 9, 0, 63, 90},
            new[] {81, 63, 72, 45, 18, 27, 0},
            new[] {0, 0, 9, 81, 27, 18, 45},
            new[] {45, 45, 27, 27, 90, 81, 72},
            new[] {45, 18, 9, 0, 9, 18, 45},
            new[] {27, 81, 36, 63, 63, 72, 81}},
                ExpectedResult =  new[] {  new[] {39, 30, 26, 25, 31},
            new[] {34, 37, 35, 32, 32},
            new[] {38, 41, 44, 46, 42},
            new[] {22, 24, 31, 39, 45},
            new[] {37, 34, 36, 47, 59}}
            }

        };
        #endregion
        [Description("L5.5")]
        [TestCaseSource("L55")]
        [Test]
        public void TestboxBlur(ComplexTest<int[][], int[][]> test)
        {
    Assert.AreEqual(test.ExpectedResult, ArcadeIntro5.boxBlur(test.Input));
        }

        [TestCase(new[] { 5, 3, 6, 7, 9 }, ExpectedResult = 4, Description = "L5.4.1")]
        [TestCase(new[] { 2, 3 }, ExpectedResult = 4, Description = "L5.4.2")]
        [TestCase(new[] { 1, 4, 10, 6, 2 }, ExpectedResult = 7, Description = "L5.4.3")]
        public int TestavoidObstacles(int[] inputArray)
        {
            return ArcadeIntro5.avoidObstacles(inputArray);
        }

        [TestCase("172.16.254.1", ExpectedResult = true, Description = "L5.3.1")]
        [TestCase("172.316.254.1", ExpectedResult = false, Description = "L5.3.2")]
        [TestCase(".254.255.0", ExpectedResult = false, Description = "L5.3.3")]
        [TestCase("1.1.1.1a", ExpectedResult = false, Description = "L5.3.4")]
        [TestCase("0.254.255.0", ExpectedResult = true, Description = "L5.3.5")]
        [TestCase("0..1.0", ExpectedResult = false, Description = "L5.3.6")]
        [TestCase("1.1.1.1.1", ExpectedResult = false, Description = "L5.3.7")]
        [TestCase("1.256.1.1", ExpectedResult = false, Description = "L5.3.8")]
        [TestCase("a0.1.1.1", ExpectedResult = false, Description = "L5.3.9")]
        [TestCase("0.1.1.256", ExpectedResult = false, Description = "L5.3.10")]
        public bool TestisIPv4Address(string inputString)
        {
            return ArcadeIntro5.isIPv4Address(inputString);
        }

        [Category("Level 5.2")]
        [TestCase(new [] {2,4,1,0}, ExpectedResult = 3, Description = "L5.2.1")]
        [TestCase(new[] { 1, 1, 1, 1 }, ExpectedResult = 0, Description = "L5.2.2")]
        [TestCase(new[] { -1, 4, 10, 3, -2 }, ExpectedResult = 7, Description = "L5.2.3")]
        public int TestarrayMaximalAdjacentDifference(int[] inputArray)
        {
            return ArcadeIntro5.arrayMaximalAdjacentDifference(inputArray);
        }

        [TestCase(10,15,15,10, ExpectedResult = true, Description = "L5.1.1")]
        [TestCase(15, 10, 15, 10, ExpectedResult = true, Description = "L5.1.2")]
        [TestCase(10, 15, 15, 9, ExpectedResult = false, Description = "L5.1.3")]
        [TestCase(10, 5, 5, 10, ExpectedResult = true, Description = "L5.1.4")]
        [TestCase(10, 15, 5, 20, ExpectedResult = false, Description = "L5.1.5")]
        [TestCase(5, 10, 5, 10, ExpectedResult = true, Description = "L5.1.6")]
        [TestCase(1, 10, 10, 0, ExpectedResult = false, Description = "L5.1.7")]
        [TestCase(5, 5, 10, 10, ExpectedResult = false, Description = "L5.1.8")]
        public bool TestareEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return ArcadeIntro5.areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight);
        }
    }
}
