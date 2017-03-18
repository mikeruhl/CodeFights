using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeFights.Tests
{
    [Category("Level 4")]
    [TestFixture]
    public class CodeFightsLevel4Tests
    {
        [TestCase("aabb", ExpectedResult = true, TestName="L4.6.1")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc", ExpectedResult = false, TestName = "L4.6.2")]
        [TestCase("abbcabb", ExpectedResult = true, TestName = "L4.6.3")]
        [TestCase("zyyzzzzz", ExpectedResult = true, TestName = "L4.6.4")]
        public bool TestpalindromeRearranging(string inputString)
        {
            return CodeFightsLevel4.palindromeRearranging(inputString);
        }

        [TestCase(new[] { 1, 1, 1 }, ExpectedResult = 3, TestName = "L4.5.1")]
        [TestCase(new[] { -1000, 0, -2, 0 }, ExpectedResult = 5, TestName = "L4.5.2")]
        [TestCase(new[] { 2, 1, 10, 1 }, ExpectedResult = 12, TestName = "L4.5.3")]
        [TestCase(new[] { 2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15 }, ExpectedResult = 13, TestName = "L4.5.4")]
        public int TestarrayChange(int[] inputArray)
        {
            return CodeFightsLevel4.arrayChange(inputArray);
        }

        [TestCase(new [] {1,2,3}, new[] {1,2,3}, ExpectedResult = true, TestName = "L4.4.1")]
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 1, 3 }, ExpectedResult = true, TestName = "L4.4.2")]
        [TestCase(new[] { 1, 2, 2 }, new[] { 2, 1, 1 }, ExpectedResult = false, TestName = "L4.4.3")]
        [TestCase(new[] { 1, 1, 4 }, new[] { 1, 2, 3 }, ExpectedResult = false, TestName = "L4.4.4")]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 10, 2 }, ExpectedResult = false, TestName = "L4.4.5")]
        [TestCase(new[] { 2, 3, 1 }, new[] { 1, 3, 2 }, ExpectedResult = true, TestName = "L4.4.6")]
        public bool TestareSimilar(int[] A, int[] B)
        {
            return CodeFightsLevel4.areSimilar(A, B);
        }

        [TestCase("abc,def", ExpectedResult = new [] {"*****", "*abc*", "*def*", "*****"})]
        [TestCase("a", ExpectedResult = new [] {"***", "*a*", "***"})]
        public string[] TestaddBorder(string picture)
        {
            var pictureArray = picture.Split(',');
            return CodeFightsLevel4.addBorder(pictureArray);
        }



        [TestCase(new [] { 50, 60, 60, 45, 70 }, ExpectedResult = new[] { 180, 105 })]
        [TestCase(new[] { 100, 50 }, ExpectedResult = new[] { 100, 50 })]
        [TestCase(new[] { 80 }, ExpectedResult = new[] { 80, 0 })]
        public int[] TestAlertnatingSums(int[] a)
        {
            return CodeFightsLevel4.alternatingSums(a);
        }

    }
}
