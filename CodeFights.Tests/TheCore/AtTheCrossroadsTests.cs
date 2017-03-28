using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class AtTheCrossroadsTests
    {
        [TestCase(30, ExpectedResult = new[] { 31 }, Description = "Crossroads.8.1")]
        [TestCase(31, ExpectedResult = new[]{28, 30, 31}, Description = "Crossroads.8.2")]
        public int[] TestmetroCard(int lastNumberOfDays)
        {
            return AtTheCrossroads.metroCard(lastNumberOfDays);
        }

        [TestCase(true, true, true, ExpectedResult = false, Description = "Crossroads.7.1")]
        [TestCase(true, false, true, ExpectedResult = true, Description = "Crossroads.7.2")]
        [TestCase(false, false, false, ExpectedResult = false, Description = "Crossroads.7.3")]
        [TestCase(false, false, true, ExpectedResult = true, Description = "Crossroads.7.4")]
        public bool TestwillYou(bool young, bool beautiful, bool loved)
        {
            return AtTheCrossroads.willYou(young, beautiful, loved);
        }


        [TestCase(3, 6, ExpectedResult = true, Description = "Crossroads.6.1")]
        [TestCase(8, 5, ExpectedResult = false, Description = "Crossroads.6.2")]
        [TestCase(6, 5, ExpectedResult = false, Description = "Crossroads.6.3")]
        [TestCase(7, 7, ExpectedResult = false, Description = "Crossroads.6.4")]
        [TestCase(6, 4, ExpectedResult = true, Description = "Crossroads.6.5")]
        [TestCase(7, 5, ExpectedResult = true, Description = "Crossroads.6.6")]
        [TestCase(7, 2, ExpectedResult = false, Description = "Crossroads.6.7")]
        [TestCase(7, 6, ExpectedResult = true, Description = "Crossroads.6.8")]
        public bool TesttennisSet(int score1, int score2)
        {
            return AtTheCrossroads.tennisSet(score1, score2);
        }

        [TestCase(2, 3, 5, ExpectedResult = true, Description = "Crossroads.5.1")]
        [TestCase(8, 2, 4, ExpectedResult = true, Description = "Crossroads.5.2")]
        [TestCase(8, 3, 2, ExpectedResult = false, Description = "Crossroads.5.3")]
        [TestCase(6, 3, 3, ExpectedResult = true, Description = "Crossroads.5.4")]
        [TestCase(8, 2, 4, ExpectedResult = true, Description = "Crossroads.5.5")]
        [TestCase(2, 3, 6, ExpectedResult = true, Description = "Crossroads.5.6")]
        [TestCase(5, 2, 0, ExpectedResult = false, Description = "Crossroads.5.7")]
        [TestCase(10, 2, 2, ExpectedResult = false, Description = "Crossroads.5.8")]
        public bool TestarithmeticExpression(int A, int B, int C)
        {
            return AtTheCrossroads.arithmeticExpression(A, B, C);
        }

        [TestCase(2, 6, ExpectedResult = false, Description = "Crossroads.4.1")]
        [TestCase(2, 3, ExpectedResult = true, Description = "Crossroads.4.2")]
        [TestCase(2, 10, ExpectedResult = false, Description = "Crossroads.4.3")]
        [TestCase(0, 1, ExpectedResult = true, Description = "Crossroads.4.4")]
        [TestCase(3, 1, ExpectedResult = true, Description = "Crossroads.4.5")]
        [TestCase(10, 10, ExpectedResult = false, Description = "Crossroads.4.6")]
        [TestCase(5, 10, ExpectedResult = true, Description = "Crossroads.4.7")]
        public bool TestisInfiniteProcess(int a, int b)
        {
            return AtTheCrossroads.isInfiniteProcess(a, b);
        }

        [TestCase(2, 7, 2, ExpectedResult = 7, Description = "Crossroads.3.1")]
        [TestCase(3, 2, 2, ExpectedResult = 3, Description = "Crossroads.3.2")]
        [TestCase(5, 5, 1, ExpectedResult = 1, Description = "Crossroads.3.3")]
        [TestCase(500000000, 3, 500000000, ExpectedResult = 3, Description = "Crossroads.3.4")]
        public int TestextraNumber(int a, int b, int c)
        {
            return AtTheCrossroads.extraNumber(a, b, c);
        }

        //knapsackLight is in ArcadeIntro9

        [TestCase(10,15,5, ExpectedResult = true, Description="Crossroads.1.1")]
        [TestCase(10, 15, 4, ExpectedResult = false, Description = "Crossroads.1.2")]
        [TestCase(3, 6, 4, ExpectedResult = true, Description = "Crossroads.1.3")]
        public bool TestreachNextLevel(int experience, int threshold, int reward)
        {
            return AtTheCrossroads.reachNextLevel(experience, threshold, reward);
        }

    }
}
