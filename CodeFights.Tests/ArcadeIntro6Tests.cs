using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeFights.Tests
{
    [TestFixture]
    public class ArcadeIntro6Tests
    {
        [TestCase("A1", "C3", ExpectedResult = true, Description = "Test Case 1")]
        [TestCase("A1", "H3", ExpectedResult = false, Description = "Test Case 2")]
        [TestCase("A1", "A2", ExpectedResult = false, Description = "Test Case 3")]
        [TestCase("A1", "B2", ExpectedResult = true, Description = "Test Case 4")]
        public bool TestchessBoardCellColor(string cell1, string cell2)
        {
            return ArcadeIntro6.chessBoardCellColor(cell1, cell2);
        }


        [TestCase("crazy", ExpectedResult = "dsbaz", Description = "Test Case 1")]
        [TestCase("z", ExpectedResult = "a", Description = "Test Case 2")]
        public string TestalphabeticShift(string inputString)
        {
            return ArcadeIntro6.alphabeticShift(inputString);
        }

        [TestCase("var_1__Int", ExpectedResult = true, Description = "Test Case 1")]
        [TestCase("qq-q", ExpectedResult = false, Description = "Test Case 2")]
        [TestCase("2w2", ExpectedResult = false, Description = "Test Case 3")]
        [TestCase(" variable", ExpectedResult = false, Description = "Test Case 4")]
        [TestCase("va[riable0", ExpectedResult = false, Description = "Test Case 5")]
        [TestCase("variable0", ExpectedResult = true, Description = "Test Case 6")]
        [TestCase("a", ExpectedResult = true, Description = "Test Case 7")]
        public bool TestvariableName(string name)
        {
            return ArcadeIntro6.variableName(name);
        }

        [TestCase(248622, ExpectedResult = true, Description = "Test Case 1")]
        [TestCase(642386, ExpectedResult = false, Description = "Test Case 2")]
        [TestCase(248842, ExpectedResult = true, Description = "Test Case 3")]
        [TestCase(1, ExpectedResult = false, Description = "Test Case 4")]
        public bool TestevenDigitsOnly(int n)
        {
            return ArcadeIntro6.evenDigitsOnly(n);
        }

        [TestCase(new[] { 1, 2, 1 }, 1, 3, ExpectedResult = new[] { 3, 2, 3 }, Description = "Test Case 1")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 0, ExpectedResult = new[] { 1, 2, 0, 4, 5 }, Description = "Test Case 2")]
        [TestCase(new[] { 1, 1, 1 }, 1, 10, ExpectedResult = new[] { 10, 10, 10 }, Description = "Test Case 3")]
        public int[] TestarrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return ArcadeIntro6.arrayReplace(inputArray, elemToReplace, substitutionElem);
        }
    }
}
