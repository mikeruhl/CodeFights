using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class ListForestEdgeTests
    {
        [TestCase(new[] { 6, 2, 3, 8 }, ExpectedResult = 3, Description = "Forest.8.1")]
        [TestCase(new[] { 0, 3 }, ExpectedResult = 2, Description = "Forest.8.2")]
        [TestCase(new[] { 5, 4, 6 }, ExpectedResult = 0, Description = "Forest.8.3")]
        [TestCase(new[] { 6, 3 }, ExpectedResult = 2, Description = "Forest.8.4")]
        [TestCase(new[] { 1 }, ExpectedResult = 0, Description = "Forest.8.5")]
        public int TestmakeArrayConsecutive2(int[] statues)
        {
            return ListForestEdge.makeArrayConsecutive2(statues);
        }


        [TestCase(new [] {7,2,2,5,10,7}, ExpectedResult = new[] { 7, 2, 7, 10, 7 }, Description = "Forest.7.1")]
        [TestCase(new[] { -5, -5, 10 }, ExpectedResult = new[] { -5, -5, 10 }, Description = "Forest.7.2")]
        [TestCase(new[] { 45, 23, 12, 33, 12, 453, -234, -45 }, ExpectedResult = new[] { 45, 23, 12, 45, 453, -234, -45 }, Description = "Forest.7.3")]
        [TestCase(new[] { 2, 8 }, ExpectedResult = new[] { 10 }, Description = "Forest.7.4")]
        [TestCase(new[] { -12, 34, 40, -5, -12, 4, 0, 0, -12 }, ExpectedResult = new[] { -12, 34, 40, -5, -12, 4, 0, 0, -12 }, Description = "Forest.7.5")]
        [TestCase(new[] { 9, 0, 15, 9 }, ExpectedResult = new[] { 9, 15, 9 }, Description = "Forest.7.6")]
        [TestCase(new[] { -6, 6, -6 }, ExpectedResult = new[] { -6, 6, -6 }, Description = "Forest.7.7")]
        [TestCase(new[] { 26, 26, -17 }, ExpectedResult = new[] { 26, 26, -17 }, Description = "Forest.7.8")]
        [TestCase(new[] { -7, 5, 5, 10 }, ExpectedResult = new[] { -7, 10, 10 }, Description = "Forest.7.9")]
        public int[] TestreplaceMiddle(int[] arr)
        {
            return ListForestEdge.replaceMiddle(arr);
        }


        [TestCase(new[] { 7, 2, 2, 5, 10, 7 }, ExpectedResult = true, Description = "Forest.6.1")]
        [TestCase(new[] { -5, -5, 10 }, ExpectedResult = false, Description = "Forest.6.2")]
        [TestCase(new[] {4, 2 }, ExpectedResult = false, Description = "Forest.6.3")]
        [TestCase(new[] { 45, 23, 12, 33, 12, 453, -234, -45 }, ExpectedResult = false, Description = "Forest.6.4")]
        [TestCase(new[] { -12, 34, 40, -5, -12, 4, 0, 0, -12 }, ExpectedResult = true, Description = "Forest.6.5")]
        [TestCase(new[] { 9, 0, 15, 9 }, ExpectedResult = false, Description = "Forest.6.6")]
        [TestCase(new[] { -6, 6, -6 }, ExpectedResult = false, Description = "Forest.6.7")]
        [TestCase(new[] { 26, 26, -17 }, ExpectedResult = false, Description = "Forest.6.8")]
        [TestCase(new[] { -7, 5, 5, 10 }, ExpectedResult = false, Description = "Forest.6.9")]
        [TestCase(new[] { 3, 4, 5 }, ExpectedResult = false, Description = "Forest.6.10")]
        [TestCase(new[] { -5, 3, -1, 9 }, ExpectedResult = false, Description = "Forest.6.11")]
        public bool TestisSmooth(int[] arr)
        {
            return ListForestEdge.isSmooth(arr);
        }

        [TestCase(new[] { 2, 3, 2, 3, 4, 5 }, 2, 4, ExpectedResult = new[] {2, 3, 5}, Description = "Forest.5.1")]
        [TestCase(new[] { 2, 4, 10, 1 }, 0, 2, ExpectedResult = new[] { 1 }, Description = "Forest.5.1")]
        [TestCase(new[] { 5, 3, 2, 3, 4 }, 1, 1, ExpectedResult = new[] { 5, 2, 3, 4 }, Description = "Forest.5.1")]
        public int[] TestremoveArrayPart(int[] inputArray, int l, int r)
        {
            return ListForestEdge.removeArrayPart(inputArray, l, r);
        }


        [TestCase(new[] { 2, 2, 1 }, new[] {10, 11 }, ExpectedResult = new[] { 2,2,1,10,11 }, Description = "Forest.4.1")]
        [TestCase(new[] {1, 2}, new[] {3,1,2}, ExpectedResult = new[] {1,2,3,1,2}, Description = "Forest.4.2")]
        public int[] TestconcatenateArrays(int[] a, int[] b)
        {
            return ListForestEdge.concatenateArrays(a, b);
        }


        [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = new[] {5,2,3,4,1}, Description = "Forest.3.1")]
        [TestCase(new int[] {}, ExpectedResult = new int[0] , Description = "Forest.3.2")]
        [TestCase(new[] { 239 }, ExpectedResult = new[] { 239 }, Description = "Forest.3.3")]
        [TestCase(new[] { 23, 54, 12, 3, 4, 56, 23, 12, 5, 324 }, ExpectedResult = new[] { 324, 54, 12, 3, 4, 56, 23, 12, 5, 23 }, Description = "Forest.3.4")]
        [TestCase(new[] { -1, 1 }, ExpectedResult = new[] { 1, -1 }, Description = "Forest.3.5")]
        public int[] TestfirstReverseTry(int[] arr)
        {
            return ListForestEdge.firstReverseTry(arr);
        }

        [TestCase(new [] {1, 2,1}, 1,3, ExpectedResult = new[] {3,2,3}, Description = "Forest.2.1")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 0, ExpectedResult = new[] { 1, 2, 0, 4, 5 }, Description = "Forest.2.2")]
        [TestCase(new[] { 1, 1, 1 }, 1, 10, ExpectedResult = new[] { 10, 10, 10 }, Description = "Forest.2.3")]
        public int[] TestarrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return ListForestEdge.arrayReplace(inputArray, elemToReplace, substitutionElem);
        }

        [TestCase(4, ExpectedResult = new[] {1,1,1,1}, Description = "Forest.1.1")]
        [TestCase(2, ExpectedResult = new[] { 1, 1}, Description = "Forest.1.2")]
        public int[] TestcreateArray(int size)
        {
            return ListForestEdge.createArray(size);
        }

    }
}
