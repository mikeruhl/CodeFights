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
    public class ChessTavernTests
    {
        [TestCase("e2", "e7", 'w', ExpectedResult = "draw", Description = "CTT08.01")]
        [TestCase("e3", "d7", 'b', ExpectedResult = "black", Description = "CTT08.02")]
        [TestCase("a7", "h2", 'w', ExpectedResult = "white", Description = "CTT08.03")]
        [TestCase("c5", "b7", 'w', ExpectedResult = "black", Description = "CTT08.04")]
        [TestCase("g2", "a3", 'b', ExpectedResult = "black", Description = "CTT08.05")]
        [TestCase("h4", "g7", 'w', ExpectedResult = "white", Description = "CTT08.06")]
        [TestCase("f2", "h6", 'w', ExpectedResult = "white", Description = "CTT08.07")]
        [TestCase("d3", "h2", 'b', ExpectedResult = "black", Description = "CTT08.08")]
        [TestCase("a3", "d5", 'w', ExpectedResult = "black", Description = "CTT08.09")]
        [TestCase("c3", "e7", 'b', ExpectedResult = "black", Description = "CTT08.10")]
        [TestCase("g4", "e4", 'w', ExpectedResult = "black", Description = "CTT08.11")]
        [TestCase("f4", "h6", 'b', ExpectedResult = "white", Description = "CTT08.12")]
        [TestCase("b5", "f3", 'w', ExpectedResult = "black", Description = "CTT08.13")]
        [TestCase("c5", "e5", 'b', ExpectedResult = "white", Description = "CTT08.14")]
        [TestCase("c6", "e2", 'w', ExpectedResult = "black", Description = "CTT08.15")]
        [TestCase("f6", "h4", 'b', ExpectedResult = "white", Description = "CTT08.16")]
        [TestCase("e3", "f4", 'w', ExpectedResult = "white", Description = "CTT08.17")]
        [TestCase("a6", "f7", 'w', ExpectedResult = "white", Description = "CTT08.18")]
        [TestCase("e7", "h3", 'b', ExpectedResult = "white", Description = "CTT08.19")]
        [TestCase("c7", "e6", 'w', ExpectedResult = "white", Description = "CTT08.20")]
        [TestCase("g2", "f2", 'b', ExpectedResult = "black", Description = "CTT08.21")]
        [TestCase("f2", "e5", 'w', ExpectedResult = "white", Description = "CTT08.22")]
        [TestCase("c2", "d7", 'b', ExpectedResult = "white", Description = "CTT08.23")]
        [TestCase("d4", "e3", 'w', ExpectedResult = "black", Description = "CTT08.24")]
        [TestCase("h3", "g6", 'b', ExpectedResult = "black", Description = "CTT08.25")]
        public string TestpawnRace(string white, string black, char toMove)
        {
            return ChessTavern.pawnRace(white, black, toMove);
        }

        [TestCase("d3", "e4", ExpectedResult = new[] {5, 21, 0, 29}, Description = "CTT07.01")]
        [TestCase("a1", "g5", ExpectedResult = new[] { 0, 29, 1, 29 }, Description = "CTT07.02")]
        [TestCase("a3", "e4", ExpectedResult = new[] { 1, 32, 1, 23 }, Description = "CTT07.03")]
        [TestCase("f3", "f2", ExpectedResult = new[] { 6, 11, 0, 38 }, Description = "CTT07.04")]
        [TestCase("b7", "a8", ExpectedResult = new[] { 0, 10, 0, 45 }, Description = "CTT07.05")]
        [TestCase("f7", "d3", ExpectedResult = new[] { 4, 28, 1, 21 }, Description = "CTT07.06")]
        [TestCase("g2", "c3", ExpectedResult = new[] { 9, 21, 0, 24 }, Description = "CTT07.07")]
        [TestCase("f3", "c1", ExpectedResult = new[] { 4, 18, 0, 32 }, Description = "CTT07.08")]
        [TestCase("d4", "h8", ExpectedResult = new[] { 0, 18, 0, 36 }, Description = "CTT07.09")]
        public int[] TestamazonCheckmate(string king, string amazon)
        {
            return ChessTavern.amazonCheckmate(king, amazon);
        }


        [TestCase(2, 3, ExpectedResult = 8, Description = "CTT06.01")]
        [TestCase(1, 30, ExpectedResult = 0, Description = "CTT06.02")]
        [TestCase(3, 3, ExpectedResult = 48, Description = "CTT06.03")]
        [TestCase(2, 2, ExpectedResult = 0, Description = "CTT06.04")]
        [TestCase(5, 2, ExpectedResult = 40, Description = "CTT06.05")]
        public int TestchessTriangle(int n, int m)
        {
            return ChessTavern.chessTriangle(n, m);
        }


        [TestCase(new[] {3,7}, new [] {1, 2}, new[] {-1,1}, 13, ExpectedResult = new[] {0,1}, Description = "CT05.01")]
        [TestCase(new[] { 1, 2 }, new[] { 0,0 }, new[] { 1,1 }, 6, ExpectedResult = new[] { 0, 1 }, Description = "CT05.02")]
        [TestCase(new[] { 2, 2 }, new[] { 1, 0 }, new[] { 1,1 }, 12, ExpectedResult = new[] { 1, 0 }, Description = "CT05.03")]
        [TestCase(new[] { 1, 1 }, new[] { 0, 0 }, new[] { 1,-1 }, 1000000000, ExpectedResult = new[] { 0, 0 }, Description = "CT05.04")]
        [TestCase(new[] { 2, 3 }, new[] { 1, 2 }, new[] { -1,-1 }, 41, ExpectedResult = new[] { 0, 2 }, Description = "CT05.05")]
        [TestCase(new[] { 17, 19 }, new[] { 14, 8 }, new[] { 1,-1 }, 239239, ExpectedResult = new[] { 4, 17 }, Description = "CT05.06")]
        [TestCase(new[] { 17, 19 }, new[] { 16, 18 }, new[] { 1,1 }, 239239239, ExpectedResult = new[] { 10, 2 }, Description = "CT05.07")]
        public int[] TestchessBishopDream(int[] boardSize, int[] initPosition, int[] initDirection, int k)
        {
            return ChessTavern.chessBishopDream(boardSize, initPosition, initDirection, k);
        }

        [TestCase("b1;g1;b8;g8", ExpectedResult = true, Description = "CTT04.01")]
        [TestCase("c3;g1;b8;g8", ExpectedResult = false, Description = "CTT04.01")]
        [TestCase("g1;g2;g3;g4", ExpectedResult = true, Description = "CTT04.01")]
        [TestCase("f8;h1;f3;c2", ExpectedResult = false, Description = "CTT04.01")]
        public bool TestwhoseTurn(string p)
        {
            return ChessTavern.whoseTurn(p);
        }


        #region CTT03
        static List<ComplexTest<string[], string[]>> CTT03 = new List<ComplexTest<string[], string[]>>
        {
            new ComplexTest<string[], string[]> //1
            {
                Input = new [] {"d7", "f5"},
                ExpectedResult =  new [] {"c8", "h3"}
            },
             new ComplexTest<string[], string[]> //2
            {
                Input = new [] {"d8", "b5"},
                ExpectedResult =  new [] {"b5", "d8"}
            },
              new ComplexTest<string[], string[]> //3
            {
                Input = new [] {"a1", "h8"},
                ExpectedResult =  new [] {"a1", "h8"}
            },
               new ComplexTest<string[], string[]> //4
            {
                Input = new [] {"g3", "e1"},
                ExpectedResult =  new [] {"e1", "h4"}
            },
                new ComplexTest<string[], string[]> //5
            {
                Input = new [] {"b4", "e7"},
                ExpectedResult =  new [] {"a3", "f8"}
            }
        };
#endregion
        [TestCaseSource("CTT03")]
        public void TestbishopDiagonal(ComplexTest<string[],string[]> test )
        {
            Assert.AreEqual(test.ExpectedResult, ChessTavern.bishopDiagonal(test.Input[0], test.Input[1]));
        }
    }
}
