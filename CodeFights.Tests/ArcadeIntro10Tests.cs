using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeFights.Tests
{
    [TestFixture]
    public class ArcadeIntro10Tests
    {
        [TestCase("00-1B-63-84-45-E6", ExpectedResult = true, Description = "L10.5.1")]
        [TestCase("Z1-1B-63-84-45-E6", ExpectedResult = false, Description = "L10.5.2")]
        [TestCase("not a MAC-48 address", ExpectedResult = false, Description = "L10.5.3")]
        [TestCase("FF-FF-FF-FF-FF-FF", ExpectedResult = true, Description = "L10.5.4")]
        [TestCase("00-00-00-00-00-00", ExpectedResult = true, Description = "L10.5.5")]
        [TestCase("G0-00-00-00-00-00", ExpectedResult = false, Description = "L10.5.6")]
        [TestCase("02-03-04-05-06-07-", ExpectedResult = false, Description = "L10.5.7")]
        [TestCase("12-34-56-78-9A-BC", ExpectedResult = true, Description = "L10.5.8")]
        public bool TestisMAC48Address(string inputString)
        {
            return ArcadeIntro10.isMAC48Address(inputString);
        }

        [TestCase(new[]{2,3,5,2},3, ExpectedResult = 2, Description = "L10.4.1")]
        [TestCase(new[] { 1, 3, 3, 1, 1 }, 0, ExpectedResult = 0, Description = "L10.4.2")]
        [TestCase(new[] { 5,1,3,4,1 }, 0, ExpectedResult = 1, Description = "L10.4.3")]
        [TestCase(new[] { 1,1,1,1 }, 1, ExpectedResult = 4, Description = "L10.4.3")]
        [TestCase(new[] { 1,1,1,1}, 0, ExpectedResult = 0, Description = "L10.4.5")]
        [TestCase(new[] { 3,1,1,3,1 }, 2, ExpectedResult = 2, Description = "L10.4.6")]
        public int TestelectionsWinners(int[] votes, int k)
        {
            return ArcadeIntro10.electionsWinners(votes, k);
        }


        [TestCase("abcdc", ExpectedResult = "abcdcba", Description = "L10.3.1")]
        [TestCase("ababab", ExpectedResult = "abababa", Description = "L10.3.2")]
        [TestCase("abcc", ExpectedResult = "abccba", Description = "Custom Test 1")]
        [TestCase("abccd", ExpectedResult = "abccdccba", Description = "Custom Test 2")]
        public string TestbuildPalindrome(string st)
        {
            return ArcadeIntro10.buildPalindrome(st);
        }

        [TestCase("prettyandsimple@example.com", ExpectedResult = "example.com", Description = "L10.2.1")]
        [TestCase("<>[]:,;@\"!#$%&*+-/=?^_{}| ~.a\"@example.org", ExpectedResult = "example.org", Description = "L10.2.2")]
        [TestCase("someaddress@yandex.ru", ExpectedResult = "yandex.ru", Description = "L10.2.3")]
        [TestCase("\" \"@xample.org", ExpectedResult = "xample.org", Description = "L10.2.4")]
        public string TestfindEmailDomain(string address)
        {
            return ArcadeIntro10.findEmailDomain(address);
        }

        [TestCase("bbbaacdafe", ExpectedResult = true, Description="L10.1.1")]
        [TestCase("aabbb", ExpectedResult = false, Description = "L10.1.2")]
        [TestCase("bbc", ExpectedResult = false, Description = "L10.1.3")]
        [TestCase("bbbaa", ExpectedResult = false, Description = "L10.1.4")]
        public bool TestisBeautifulString(string inputString)
        {
            return ArcadeIntro10.isBeautifulString(inputString);
        }
    }
}
