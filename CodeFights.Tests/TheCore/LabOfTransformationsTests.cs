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
   public class LabOfTransformationsTests
    {
        [TestCase("a", "a1", ExpectedResult = true, Description = "LabOfTransformation.8.1")]
        [TestCase("ab", "a1", ExpectedResult = false, Description = "LabOfTransformation.8.2")]
        [TestCase("x11y012", "x011y13", ExpectedResult = true, Description = "LabOfTransformation.8.3")]
        [TestCase("ab000144", "ab144", ExpectedResult = true, Description = "LabOfTransformation.8.4")]
        [TestCase("000", "0000", ExpectedResult = false, Description = "LabOfTransformation.8.5")]
        [TestCase("a01a001", "a1a0001", ExpectedResult = true, Description = "LabOfTransformations.8.C1")]
        [TestCase("eatthis", "eatthis", ExpectedResult = false, Description = "LabOfTransformations.8.C2")]
        public bool TestalphanumericLess(string s1, string s2)
        {
            return LabOfTransformations.alphanumericLess(s1, s2);
        }


        [TestCase("10197115121", ExpectedResult = "easy", Description = "LabOfTransformations.7.1")]
        [TestCase("98", ExpectedResult = "b", Description = "LabOfTransformations.7.2")]
        [TestCase("122", ExpectedResult = "z", Description = "LabOfTransformations.7.3")]
        public string Testdecipher(string cipher)
        {
            return LabOfTransformations.decipher(cipher);
        }

        [TestCase("1.2.2", "1.2.0", ExpectedResult = true, Description = "LabOfTransformations.6.1")]
        [TestCase("1.0.5", "1.1.0", ExpectedResult = false, Description = "LabOfTransformations.6.2")]
        [TestCase("1.1.0", "1.1.5", ExpectedResult = false, Description = "LabOfTransformations.6.3")]
        [TestCase("10", "9", ExpectedResult = true, Description = "LabOfTransformations.6.4")]
        [TestCase("1.0.10", "1.1.5", ExpectedResult = false, Description = "LabOfTransformations.6.5")]
        [TestCase("1.1.10", "1.2.0", ExpectedResult = false, Description = "LabOfTransformations.6.6")]
        [TestCase("1.2.2", "1.2.10", ExpectedResult = false, Description = "LabOfTransformations.6.7")]
        [TestCase("1.10.2", "1.2.10", ExpectedResult = true, Description = "LabOfTransformations.6.8")]
        [TestCase("4.3.22.1", "4.3.22.1", ExpectedResult = false, Description = "LabOfTransformations.6.9")]
        public bool TesthigherVersion(string ver1, string ver2)
        {
            return LabOfTransformations.higherVersion(ver1, ver2);
        }

        [TestCase("you'll n4v4r 6u4ss 8t: cdja", ExpectedResult = "you'll never guess it: 2390", Description = "LabOfTransformations.5.1")]
        [TestCase("", ExpectedResult = "", Description = "LabOfTransformations.5.2")]
        [TestCase("0123456789", ExpectedResult = "abcdefghij", Description = "LabOfTransformations.5.3")]
        [TestCase("jihgfedcba", ExpectedResult="9876543210", Description = "LabOfTransformations.5.4")]
        [TestCase("you won't know!!", ExpectedResult = "you won't know!!", Description = "LabOfTransformations.5.5")]
        [TestCase("just 63jd73 some random note jkhdf83 ds823 that you, dfj238 dsf38 little one?, will abjk38 s83    skdu3 29never get!", ExpectedResult = "9ust gd93hd som4 r0n3om not4 9k735id 3sicd t70t you, 359cdi 3s5di l8ttl4 on4?, w8ll 019kdi sid    sk3ud cjn4v4r 64t!", Description = "LabOfTransformations.5.6")]
        public string TeststolenLunch(string note)
        {
            return LabOfTransformations.stolenLunch(note);
        }

        [TestCase("taiaiaertkixquxjnfxxdh", ExpectedResult = "thisisencryptedmessage", Description = "LabOfTransformations.4.1")]
        [TestCase("ibttlprimfymqlpgeftwu", ExpectedResult = "itsasecrettoeverybody", Description = "LabOfTransformations.4.2")]
        [TestCase("ftnexvoky", ExpectedResult = "fourtytwo", Description = "LabOfTransformations.4.3")]
        [TestCase("taevzhzmashvjw", ExpectedResult = "thereisnospoon", Description = "LabOfTransformations.4.4")]
        [TestCase("abdgkpvcktdoanbqgxpicxtqon", ExpectedResult = "abcdefghijklmnopqrstuvwxyz", Description = "LabOfTransformations.4.5")]
        [TestCase("z", ExpectedResult ="z", Description = "LabOfTransformations.4.6")]
        public string Testcipher26(string message)
        {
            return LabOfTransformations.cipher26(message);
        }


        #region LabOfTransformationsT3

        private static List<ComplexTest<char, string[]>> LoT3 = new List<ComplexTest<char, string[]>>()
        {new ComplexTest<char, string[]>()
            {
                Input = 'G',
                ExpectedResult = new[] {"A + G",
 "B + F",
 "C + E",
 "D + D"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'A',
                ExpectedResult = new[] { "A + A" }
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'D',
                ExpectedResult = new[] {"A + D",
 "B + C"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'E',
                ExpectedResult = new[] {"A + E",
 "B + D",
 "C + C"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'F',
                ExpectedResult = new[] {"A + F",
 "B + E",
 "C + D"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'I',
                ExpectedResult = new[] {"A + I",
 "B + H",
 "C + G",
 "D + F",
 "E + E"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'K',
                ExpectedResult = new[] {"A + K",
 "B + J",
 "C + I",
 "D + H",
 "E + G",
 "F + F"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'L',
                ExpectedResult = new[] {"A + L",
 "B + K",
 "C + J",
 "D + I",
 "E + H",
 "F + G"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'O',
                ExpectedResult = new[] {"A + O",
 "B + N",
 "C + M",
 "D + L",
 "E + K",
 "F + J",
 "G + I",
 "H + H"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'P',
                ExpectedResult = new[] {"A + P",
 "B + O",
 "C + N",
 "D + M",
 "E + L",
 "F + K",
 "G + J",
 "H + I"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'S',
                ExpectedResult = new[] {"A + S",
 "B + R",
 "C + Q",
 "D + P",
 "E + O",
 "F + N",
 "G + M",
 "H + L",
 "I + K",
 "J + J"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'T',
                ExpectedResult = new[] {"A + T",
 "B + S",
 "C + R",
 "D + Q",
 "E + P",
 "F + O",
 "G + N",
 "H + M",
 "I + L",
 "J + K"}
            },
            new ComplexTest<char, string[]>()
            {
                Input = 'W',
                ExpectedResult = new[] {"A + W",
 "B + V",
 "C + U",
 "D + T",
 "E + S",
 "F + R",
 "G + Q",
 "H + P",
 "I + O",
 "J + N",
 "K + M",
 "L + L"}
            }
        };
        #endregion
        [TestCaseSource("LoT3")]
        public void TestnewNumeralSystem(ComplexTest<char, string[]> test)
        {
            Assert.AreEqual(test.ExpectedResult, LabOfTransformations.newNumeralSystem(test.Input));
        }

        [TestCase("name", ExpectedResult = "mznv", Description = "LabOfTransformations.2.1")]
        [TestCase("abyz", ExpectedResult= "zyba", Description= "LabOfTransformations.2.2")]
        public string TestreflectString(string inputString)
        {
            return LabOfTransformations.reflectString(inputString);
        }

        [TestCase('5', ExpectedResult="odd", Description="LabOfTransformations.1.1")]
        [TestCase('8', ExpectedResult = "even", Description = "LabOfTransformations.1.2")]
        [TestCase('q', ExpectedResult = "not a digit", Description = "LabOfTransformations.1.3")]
        [TestCase('1', ExpectedResult = "odd", Description = "LabOfTransformations.1.4")]
        [TestCase('2', ExpectedResult = "even", Description = "LabOfTransformations.1.5")]
        [TestCase('7', ExpectedResult = "odd", Description = "LabOfTransformations.1.6")]
        [TestCase('9', ExpectedResult = "odd", Description = "LabOfTransformations.1.7")]
        [TestCase('4', ExpectedResult = "even", Description = "LabOfTransformations.1.8")]
        public string TestcharacterParity(char symbol)
        {
            return LabOfTransformations.characterParity(symbol);
        }
    }
}
