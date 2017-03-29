using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.TheCore;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class LoopTunnelTests
    {
        [TestCase(3, 4, ExpectedResult = 6, Description = "LoopTunnel.10.1")]
        [TestCase(3, 3, ExpectedResult = 7, Description = "LoopTunnel.10.2")]
        [TestCase(2, 5, ExpectedResult = 6, Description = "LoopTunnel.10.3")]
        [TestCase(1, 1, ExpectedResult = 1, Description = "LoopTunnel.10.4")]
        [TestCase(1, 2, ExpectedResult = 2, Description = "LoopTunnel.10.5")]
        [TestCase(1, 3, ExpectedResult = 3, Description = "LoopTunnel.10.6")]
        [TestCase(1, 239, ExpectedResult = 239, Description = "LoopTunnel.10.7")]
        [TestCase(33, 44, ExpectedResult = 86, Description = "LoopTunnel.10.8")]
        [TestCase(16, 8, ExpectedResult = 30, Description = "LoopTunnel.10.9")]
        [TestCase(66666,88888, ExpectedResult = 177774, Description = "LoopTunnel.10.10")]
        public int TestcountBlackCells(int n, int m)
        {
            return LoopTunnel.countBlackCells(n, m);
        }

        [TestCase(5, 2, ExpectedResult = 9, Description = "LoopTunnel.9.1")]
        [TestCase(1, 2, ExpectedResult = 1, Description = "LoopTunnel.9.2")]
        [TestCase(3,3, ExpectedResult = 4, Description = "LoopTunnel.9.3")]
        [TestCase(11, 3, ExpectedResult = 16, Description = "LoopTunnel.9.4")]
        public int Testcandles(int candlesNumber, int makeNew)
        {
            return LoopTunnel.candles(candlesNumber, makeNew);
        }


        [TestCase(15, ExpectedResult = 20, Description = "LoopTunnel.8.1")]
        [TestCase(1234, ExpectedResult = 1000, Description = "LoopTunnel.8.2")]
        [TestCase(1445, ExpectedResult = 2000, Description = "LoopTunnel.8.3")]
        [TestCase(14, ExpectedResult = 10, Description = "LoopTunnel.8.4")]
        [TestCase(10, ExpectedResult = 10, Description = "LoopTunnel.8.5")]
        [TestCase(99, ExpectedResult = 100, Description = "LoopTunnel.8.6")]
        public int Testrounders(int value)
        {
            return LoopTunnel.rounders(value);
        }


        [TestCase(902200100, ExpectedResult = true, Description = "LoopTunnel.7.1")]
        [TestCase(11000, ExpectedResult = false, Description = "LoopTunnel.7.2")]
        [TestCase(99080, ExpectedResult = true, Description = "LoopTunnel.7.3")]
        [TestCase(1022220, ExpectedResult = true, Description = "LoopTunnel.7.4")]
        [TestCase(106611, ExpectedResult = true, Description = "LoopTunnel.7.5")]
        [TestCase(234230, ExpectedResult = false, Description = "LoopTunnel.7.6")]
        [TestCase(888, ExpectedResult = false, Description = "LoopTunnel.7.7")]
        public bool TestincreaseNumberRoundness(int n)
        {
            return LoopTunnel.increaseNumberRoundness(n);
        }


        [TestCase(5, ExpectedResult = -15, Description = "LoopTunnel.6.1")]
        [TestCase(15, ExpectedResult = -120, Description = "LoopTunnel.6.2")]
        [TestCase(36, ExpectedResult = 666, Description = "LoopTunnel.6.3")]
        [TestCase(1, ExpectedResult = -1, Description = "LoopTunnel.6.4")]
        public int TestappleBoxes(int k)
        {
            return LoopTunnel.appleBoxes(k);
        }

        [TestCase(456, 1734, ExpectedResult = 1180, Description = "LoopTunnel.5.1")]
        [TestCase(99999, 0, ExpectedResult = 99999, Description = "LoopTunnel.5.2")]
        [TestCase(999, 999, ExpectedResult = 888, Description = "LoopTunnel.5.3")]
        [TestCase(0,0, ExpectedResult = 0, Description = "LoopTunnel.5.4")]
        public int TestadditionWithoutCarrying(int param1, int param2)
        {
            return LoopTunnel.additionWithoutCarrying(param1, param2);
        }

        [TestCase("LLARL", ExpectedResult = 3, Description = "LoopTunnel.4.1")]
        [TestCase("RLR", ExpectedResult = 1, Description = "LoopTunnel.4.2")]
        [TestCase("", ExpectedResult = 0, Description = "LoopTunnel.4.3")]
        [TestCase("L", ExpectedResult = 0, Description = "LoopTunnel.4.4")]
        [TestCase("A", ExpectedResult = 1, Description = "LoopTunnel.4.5")]
        [TestCase("AAAAAAAAAAAAAAA", ExpectedResult = 15, Description = "LoopTunnel.4.6")]
        [TestCase("RRRRRRRRRRLLLLLLLLLRRRRLLLLLLLLLL", ExpectedResult = 16, Description = "LoopTunnel.4.7")]
        [TestCase("AALAAALARAR", ExpectedResult = 5, Description = "LoopTunnel.4.8")]
        public int TestlineUp(string commands)
        {
            return LoopTunnel.lineUp(commands);
        }


        [TestCase(1, 2, 2, ExpectedResult = 8, Description = "LoopTunnel.3.1")]
        [TestCase(1, 1, 1, ExpectedResult = 1, Description = "LoopTunnel.3.2")]
        [TestCase(6,5,3, ExpectedResult = 128, Description = "LoopTunnel.3.3")]
        public int TestmagicalWell(int a, int b, int n)
        {
            return LoopTunnel.magicalWell(a, b, n);
        }

        [TestCase(6,2,4, ExpectedResult = 2, Description = "LoopTunnel.2.1")]
        [TestCase(6,3,3, ExpectedResult = 1, Description = "LoopTunnel.2.2")]
        [TestCase(10,9,11, ExpectedResult = 0, Description = "LoopTunnel.2.3")]
        [TestCase(24,8,16, ExpectedResult = 5, Description = "LoopTunnel.2.4")]
        [TestCase(24, 12, 12, ExpectedResult = 1, Description = "LoopTunnel.2.5")]
        [TestCase(93,24,58, ExpectedResult = 12, Description = "LoopTunnel.2.6")]
        public int TestcountSumOfTwoRepresentations2(int n, int l, int r)
        {
            return LoopTunnel.countSumOfTwoRepresentations2(n, l, r);
        }


        [TestCase(17, ExpectedResult = 24, Description = "LoopTunnel.1.1")]
        [TestCase(1, ExpectedResult = 1, Description = "LoopTunnel.1.2")]
        [TestCase(5, ExpectedResult = 6, Description = "LoopTunnel.1.3")]
        public int TestleastFactorial(int n)
        {
            return LoopTunnel.leastFactorial(n);
        }


    }
}
