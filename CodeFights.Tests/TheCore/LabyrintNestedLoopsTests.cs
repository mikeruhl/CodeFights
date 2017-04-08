using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.Tests.Common;
using CodeFights.TheCore;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class LabyrintNestedLoopsTests
    {
        #region Labyrinth8 Test Cases

        private static List<ComplexTest<string[], int>> Labyrinth8 = new List<ComplexTest<string[], int>>
        {
            new ComplexTest<string[], int>(new [] {"onomatopoeia",
 "philosophical",
 "provocatively",
 "thesaurus"}, 20),
            new ComplexTest<string[], int>(new [] {"phenomenon",
 "remuneration",
 "particularly",
 "pronunciation"}, 62),
            new ComplexTest<string[], int>(new [] {"africa",
 "america",
 "australia",
 "antarctica"}, 62),
            new ComplexTest<string[], int>(new [] {"eternal",
 "texas",
 "chainsaw",
 "massacre"}, 4),
            new ComplexTest<string[], int>(new [] {"anaesthetist",
 "thatch",
 "ethnics",
 "sabulous"}, 0),
            new ComplexTest<string[], int>(new [] {"crossword",
 "square",
 "formation",
 "something"}, 6)
        };
        #endregion
        [Description("Labyrinth8")]
        [TestCaseSource("Labyrinth8")]
        public void TestcrosswordFormation2(ComplexTest<string[], int> test)
        {
            Assert.AreEqual(test.ExpectedResult, LabyrintNestedLoops.crosswordFormation(test.Input));
        }

        [TestCase(6, 4, ExpectedResult = 23, Description = "Labyrinth.7.1")]
        [TestCase(30, 2, ExpectedResult = 65, Description = "Labyrinth.7.2")]
        [TestCase(8, 6, ExpectedResult = 49, Description = "Labyrinth.7.3")]
        [TestCase(16, 20, ExpectedResult = 333, Description = "Labyrinth.7.4")]
        public int TestrectangleRotation(int a, int b)
        {
            return LabyrintNestedLoops.rectangleRotation(a, b);
        }


        [TestCase(9, ExpectedResult = new[] { 2, 2 }, Description = "Labyrinth.6.1")]
        [TestCase(1, ExpectedResult = new[] { 0, 1 }, Description = "Labyrinth.6.2")]
        [TestCase(2, ExpectedResult = new[] { 0, 2 }, Description = "Labyrinth.6.3")]
        [TestCase(7, ExpectedResult = new[] { 2, 1 }, Description = "Labyrinth.6.4")]
        [TestCase(500, ExpectedResult = new[] { 403, 1 }, Description = "Labyrinth.6.5")]
        [TestCase(4, ExpectedResult = new[] { 0, 4 }, Description = "Labyrinth.6.6")]
        public int[] TestweakNumbers(int n)
        {
            return LabyrintNestedLoops.weakNumbers(n);
        }

        [TestCase(10, 12, ExpectedResult = 2, Description = "Labyrinth.5.1")]
        [TestCase(1, 9, ExpectedResult = 20, Description = "Labyrinth.5.2")]
        [TestCase(13, 13, ExpectedResult = 0, Description = "Labyrinth.5.3")]
        [TestCase(12, 108, ExpectedResult = 707, Description = "Labyrinth.5.4")]
        [TestCase(239, 777, ExpectedResult = 6166, Description = "Labyrinth.5.5")]
        [TestCase(1, 1000, ExpectedResult = 11435, Description = "Labyrinth.5.6")]
        public int TestcomfortableNumbers(int L, int R)
        {
            return LabyrintNestedLoops.comfortableNumbers(L, R);
        }

        [TestCase(1, 5, ExpectedResult = 5, Description = "Labyrinth.4.1")]
        [TestCase(21, 5, ExpectedResult = 22, Description = "Labyrinth.4.2")]
        [TestCase(8, 4, ExpectedResult = 10, Description = "Labyrinth.4.3")]
        [TestCase(21, 6, ExpectedResult = 23, Description = "Labyrinth.4.4")]
        [TestCase(76, 250, ExpectedResult = 166, Description = "Labyrinth.4.5")]
        [TestCase(80, 1000, ExpectedResult = 419, Description = "Labyrinth.4.6")]
        public int TestpagesNumberingWithInk(int current, int numberOfDigits)
        {
            return LabyrintNestedLoops.pagesNumberingWithInk(current, numberOfDigits);
        }


        [TestCase(16, ExpectedResult = 9, Description = "Labyrinth.3.1")]
        [TestCase(103, ExpectedResult = 4, Description = "Labyrinth.3.2")]
        [TestCase(1, ExpectedResult = 2, Description = "Labyrinth.3.3")]
        public int TestsquareDigitsSequence(int a0)
        {
            return LabyrintNestedLoops.squareDigitsSequence(a0);
        }


        [TestCase(9, ExpectedResult = 2, Description = "Labyrinth.2.1")]
        [TestCase(8, ExpectedResult = 0, Description = "Labyrinth.2.2")]
        [TestCase(15, ExpectedResult = 3, Description = "Labyrinth.2.3")]
        public int TestisSumOfConsecutive2(int n)
        {
            return LabyrintNestedLoops.isSumOfConsecutive2(n);
        }


        [TestCase(125, ExpectedResult = true, Description = "Labyrinth.1.1")]
        [TestCase(72, ExpectedResult = false, Description = "Labyrinth.1.2")]
        [TestCase(100, ExpectedResult = true, Description = "Labyrinth.1.3")]
        [TestCase(11, ExpectedResult = false, Description = "Labyrinth.1.4")]
        [TestCase(324, ExpectedResult = true, Description = "Labyrinth.1.5")]
        [TestCase(256, ExpectedResult = true, Description = "Labyrinth.1.6")]
        [TestCase(119, ExpectedResult = false, Description = "Labyrinth.1.7")]
        [TestCase(12, ExpectedResult = false, Description = "Labyrinth.1.8")]
        [TestCase(1, ExpectedResult = true, Description = "Labyrinth.1.9")]
        [TestCase(2, ExpectedResult = false, Description = "Labyrinth.1.10")]
        [TestCase(343, ExpectedResult = true, Description = "Labyrinth.1.11")]
        [TestCase(144, ExpectedResult = true, Description = "Labyrinth.1.12")]
        [TestCase(289, ExpectedResult = true, Description = "Labyrinth.1.13")]
        [TestCase(225, ExpectedResult = true, Description = "Labyrinth.1.14")]
        [TestCase(35, ExpectedResult = false, Description = "Labyrinth.1.15")]
        [TestCase(3, ExpectedResult = false, Description = "Labyrinth.1.16")]
        public bool TetsisPower(int n)
        {
            return LabyrintNestedLoops.isPower(n);
        }
    }
}
