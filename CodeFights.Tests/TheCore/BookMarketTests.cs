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
    public class BookMarketTests
    {
        [TestCase("aa", "AAB", ExpectedResult = true, Description = "BookMarket.8.1")]
        [TestCase("A", "z", ExpectedResult = false, Description = "BookMarket.8.2")]
        [TestCase("yyyyyy", "Azzzzzzzzz", ExpectedResult = false, Description = "BookMarket.8.3")]
        [TestCase("mehOu", "mehau", ExpectedResult=true, Description="BookMarket.8.4")]
        [TestCase("aaZ", "AAzz", ExpectedResult = true, Description = "BookMarket.8.4")]
        public bool TestisUnstablePair(string filename1, string filename2)
        {
            return BookMarket.isUnstablePair(filename1, filename2);
        }

        [TestCase("<button type='button' disabled>", ExpectedResult = "</button>", Description = "BookMarket.6.1")]
        [TestCase("<i>", ExpectedResult = "</i>", Description = "BookMarket.6.2")]
        [TestCase("<div id='my_area' class='data' title='This is a test for title on Div tag'>", ExpectedResult= "</div>", Description="BookMarket.6.3")]
        public string TesthtmlEndTagByStartTag(string startTag)
        {
            return BookMarket.htmlEndTagByStartTag(startTag);
        }

        [TestCase("AaBaa", ExpectedResult = true, Description = "BookMarket.4.1")]
        [TestCase("abac", ExpectedResult = false, Description = "BookMarket.4.2")]
        [TestCase("aBACaba", ExpectedResult = true, Description = "BookMarket.4.3")]
        [TestCase("opOP", ExpectedResult = false, Description = "BookMarket.4.4")]
        [TestCase("ZZzzazZzz", ExpectedResult=true, Description ="BookMarket.4.5")]
        public bool TestisCaseInsensitivePalindrome(string inputString)
        {
            return BookMarket.isCaseInsensitivePalindrome(inputString);
        }


        [TestCase("tandemtandem", ExpectedResult = true, Description = "BookMarket.3.1")]
        [TestCase("qqq", ExpectedResult = false, Description = "BookMarket.3.2")]
        [TestCase("2w2ww", ExpectedResult = false, Description = "BookMarket.3.3")]
        [TestCase("hophey", ExpectedResult = false, Description = "BookMarket.3.4")]
        [TestCase("CodeFightsCodeFights", ExpectedResult = true, Description = "BookMarket.3.5")]
        [TestCase("interestinterest", ExpectedResult=true, Description ="BookMarket.3.6")]
        public bool TestisTandemRepeat(string inputString)
        {
            return BookMarket.isTandemRepeat(inputString);
        }


        [TestCase("pARiS", ExpectedResult = "Paris", Description = "BookMarket.2.1")]
        [TestCase("John", ExpectedResult = "John", Description = "BookMarket.2.2")]
        [TestCase("mary", ExpectedResult= "Mary", Description="BookMarket.2.3")]
        public string TestproperNounCorrection(string noun)
        {
            return BookMarket.properNounCorrection(noun);
        }

        [TestCase("abacaba", ExpectedResult = "(abacaba)", Description = "BookMarket.1.1")]
        [TestCase("abcdef", ExpectedResult = "(abcdef)", Description = "BookMarket.1.2")]
        [TestCase("aaad", ExpectedResult = "(aaad)", Description = "BookMarket.1.3")]
       public string TestencloseInBrackets(string inputString)
       {
           return BookMarket.encloseInBrackets(inputString);
       }

    }
}
