using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class CornerOfZeroAndOne
    {

        public static int equalPairOfBits(int n, int m)
        {
            var nStr = Convert.ToString(n, 2);
            var mStr = Convert.ToString(m, 2);
            nStr = nStr.PadLeft(mStr.Length, '0');
            mStr = mStr.PadLeft(nStr.Length, '0');

            var index = -1;
            for (var i = nStr.Length - 1; i >= 0; i--)
            {
                if (nStr.Substring(i, 1) == mStr.Substring(i, 1))
                {
                    index = i;
                    break;
                }
            }

            return (int)Math.Pow(2, mStr.Length - index -1);
        }

        public static int differentRightmostBit(int n, int m)
        {
            var bit1Str = Convert.ToString(n, 2);
            var bit2Str = Convert.ToString(m, 2);

            bit1Str = bit1Str.PadLeft(bit2Str.Length, '0');
            bit2Str = bit2Str.PadLeft(bit1Str.Length, '0');
            var bit1 = bit1Str.ToCharArray();
            var bit2 = bit2Str.ToCharArray();
            var index = 0;
            for (var i = bit1.Length-1; i >= 0; i--)
            {
                if (bit1[i] != bit2[i])
                {
                    index = i;
                    break;
                }
            }
            return (int)Math.Pow(2, bit1.Length - index - 1);
        }

        public static int swapAdjacentBits(int n)
        {
            var bitStr = Convert.ToString(n, 2);
            var bits = new char[bitStr.Length];
            if (bitStr.Length % 2 == 1)
                bits = ("0" + bitStr).ToCharArray();
            else
                bits = bitStr.ToCharArray();

            var sb = new StringBuilder();
            for (var i = 0; i < bits.Length - 1; i += 2)
            {
                var firstSpot = bits[i + 1];
                var secondSpot = bits[i];
                sb.Append(firstSpot);
                sb.Append(secondSpot);
            }
            return Convert.ToInt32(sb.ToString(), 2);
        }

        public static int secondRightmostZeroBit(int n)
        {
            var forward = Convert.ToString(n, 2);
            var firstZero = forward.LastIndexOf("0");
            var secondZero = forward.LastIndexOf("0", firstZero - 1);
            var powered = Math.Pow(2, forward.Length - secondZero - 1);
            return (int)powered;
        }

        public static int mirrorBits(int a)
        {
            var forward = Convert.ToString(a, 2);
            var backward = new string(forward.Reverse().Select(b => b).ToArray());
            var converted = Convert.ToInt32(backward, 2);
            return converted;
        }

        public static int rangeBitCount(int a, int b)
        {
            var byteArray = new byte[b - a + 1][];
            for (var i = a; i <= b; i++)
            {
                var index = i - a;
                var byter = BitConverter.GetBytes(i);
                byteArray[index] = byter;
            }
            var bitArrays = byteArray.Select(by => new BitArray(by));

            return bitArrays.SelectMany(bitA => bitA.Cast<bool>()).Count(bit => bit);
        }

        public static int arrayPacking(int[] a)
        {
            var outputByte = new byte[4];
            for (var i = 0; i < a.Length; i++)
            {
                outputByte[i] = BitConverter.GetBytes(a[i])[0];
            }
            return BitConverter.ToInt32(outputByte, 0);
        }

        public static int killKthBit(int n, int k)
        {
            var bytes = BitConverter.GetBytes(n);
            var bits = new BitArray(bytes);
            bits[k - 1] = false;
            var newBytes = new byte[bytes.Length];
            bits.CopyTo(newBytes, 0);
            return BitConverter.ToInt32(newBytes, 0);
        }
    }
}
