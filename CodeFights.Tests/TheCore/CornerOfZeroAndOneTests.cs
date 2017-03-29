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
    public class CornerOfZeroAndOneTests
    {
        [TestCase(10, 11, ExpectedResult = 2, Description = "CornerOfZero.8.5")]
        [TestCase(0, 0, ExpectedResult = 1, Description = "CornerOfZero.8.5")]
        [TestCase(28, 27, ExpectedResult = 8, Description = "CornerOfZero.8.5")]
        [TestCase(895, 928, ExpectedResult = 32, Description = "CornerOfZero.8.5")]
        [TestCase(1073741824, 1006895103, ExpectedResult = 262144, Description = "CornerOfZero.8.5")]
        public int TestequalPairOfBits(int n, int m)
        {
            return CornerOfZeroAndOne.equalPairOfBits(n, m);
        }

        [TestCase(11, 13, ExpectedResult = 2, Description = "CornerOfZero.7.1")]
        [TestCase(7, 23, ExpectedResult = 16, Description = "CornerOfZero.7.2")]
        [TestCase(1, 0, ExpectedResult = 1, Description = "CornerOfZero.7.3")]
        [TestCase(64, 65, ExpectedResult = 1, Description = "CornerOfZero.7.4")]
        [TestCase(1073741823, 1071513599, ExpectedResult = 131072, Description = "CornerOfZero.7.5")]
        [TestCase(42, 22, ExpectedResult = 4, Description = "CornerOfZero.7.6")]
        public int TestdifferentRightmostBit(int n, int m)
        {
            return CornerOfZeroAndOne.differentRightmostBit(n, m);
        }

        [TestCase(13, ExpectedResult = 14, Description = "CornerOfZero.6.1")]
        [TestCase(74, ExpectedResult = 133, Description = "CornerOfZero.6.2")]
        [TestCase(1073741823, ExpectedResult = 1073741823, Description = "CornerOfZero.6.3")]
        [TestCase(0, ExpectedResult = 0, Description = "CornerOfZero.6.4")]
        [TestCase(1, ExpectedResult = 2, Description = "CornerOfZero.6.5")]
        [TestCase(83748, ExpectedResult = 166680, Description = "CornerOfZero.6.6")]
        public int TestswapAdjacentBits(int n)
        {
            return CornerOfZeroAndOne.swapAdjacentBits(n);
        }

        [TestCase(37, ExpectedResult = 8, Description = "CornerOfZero.5.1")]
        [TestCase(1073741824, ExpectedResult = 2, Description = "CornerOfZero.5.2")]
        [TestCase(83748, ExpectedResult = 2, Description = "CornerOfZero.5.3")]
        [TestCase(4, ExpectedResult = 2, Description = "CornerOfZero.5.4")]
        [TestCase(728782938, ExpectedResult = 4, Description = "CornerOfZero.5.5")]
        public int TestsecondRightmostZeroBit(int n)
        {
            return CornerOfZeroAndOne.secondRightmostZeroBit(n);
        }

        [TestCase(97, ExpectedResult = 67, Description = "CornerOfZero.4.1")]
        [TestCase(8, ExpectedResult = 1, Description = "CornerOfZero.4.2")]
        public int TestmirrorBits(int a)
        {
            return CornerOfZeroAndOne.mirrorBits(a);
        }

        [TestCase(2, 7, ExpectedResult = 11, Description = "CornerOfZero.3.1")]
        [TestCase(0, 1, ExpectedResult = 1, Description = "CornerOfZero.3.2")]
        public int TestrangeBitCount(int a, int b)
        {
            return CornerOfZeroAndOne.rangeBitCount(a, b);
        }

        [TestCase(new[] { 24, 85, 0 }, ExpectedResult = 21784, Description = "CornerOfZero.2.1")]
        [TestCase(new[] { 23, 45, 39 }, ExpectedResult = 2567447, Description = "CornerOfZero.2.2")]
        public int TestarrayPacking(int[] a)
        {
            return CornerOfZeroAndOne.arrayPacking(a);
        }

        [TestCase(37, 3, ExpectedResult = 33, Description = "CornerOfZero.1.1")]
        [TestCase(37, 4, ExpectedResult = 37, Description = "CornerOfZero.1.2")]
        [TestCase(0, 4, ExpectedResult = 0, Description = "CornerOfZero.1.3")]
        [TestCase(2147483647, 16, ExpectedResult = 2147450879, Description = "CornerOfZero.1.4")]
        [TestCase(374823748, 13, ExpectedResult = 374819652, Description = "CornerOfZero.1.5")]
        [TestCase(2734827, 4, ExpectedResult = 2734819, Description = "CornerOfZero.1.6")]
        [TestCase(1084197039, 15, ExpectedResult = 1084197039, Description = "CornerOfZero.1.7")]
        [TestCase(1160825071, 3, ExpectedResult = 1160825067, Description = "CornerOfZero.1.8")]
        [TestCase(2039063284, 4, ExpectedResult = 2039063284, Description = "CornerOfZero.1.9")]
        public int TestkillKthBit(int n, int k)
        {
            return CornerOfZeroAndOne.killKthBit(n, k);
        }

    }
}
