using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CodeFights.TheCore;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeFights.Tests.TheCore
{
    [TestFixture()]
    public class RegularHellTests
    {
        [TestCase("cough\tbough", ExpectedResult = true, Description = "RegularHell.06.01")]
        [TestCase("CodeFig!ht\tWith all your might", ExpectedResult = false, Description = "RegularHell.06.02")]
        [TestCase("quod erat demonstrandum\tand that, ladies and gentlemen, is the end of my memorandum", ExpectedResult = true, Description = "RegularHell.06.03")]
        [TestCase("yup\tyes", ExpectedResult = false, Description = "RegularHell.06.04")]
        [TestCase("hey\they", ExpectedResult = true, Description = "RegularHell.06.05")]
        [TestCase("E = MC<sup>2</sup>\twhich in turn equals sup", ExpectedResult = false, Description = "RegularHell.06.06")]
        [TestCase("Isn't it correct?!\tIt definitely is! Does it mean that we've just obtained a full set?!", ExpectedResult = true, Description = "RegularHell.06.07")]
        [TestCase("Nothing can go wrong here :)\tHehehehe:)", ExpectedResult = false, Description = "RegularHell.06.08")]
        [TestCase("!1?/\tsldkjfl3 sldjf 1?/", ExpectedResult = true, Description = "RegularHell.06.09")]
        [TestCase("simple\tpimple", ExpectedResult = true, Description = "RegularHell.06.10")]
        public bool TesteyeRhyme(string pairOfLines)
        {
            return RegularHell.eyeRhyme(pairOfLines);
        }

        [TestCase("CodeFights", "CoFi", ExpectedResult = true, Description = "RegularHell.05.01")]
        [TestCase("CodeFights", "cofi", ExpectedResult = false, Description = "RegularHell.05.02")]
        [TestCase("somestring", "", ExpectedResult = true, Description = "RegularHell.05.03")]
        [TestCase("penny", "longsenselessstringwithpennyinside", ExpectedResult = false, Description = "RegularHell.05.04")]
        [TestCase("parliament", "partialmen", ExpectedResult = false, Description = "RegularHell.05.05")]
        [TestCase("", "", ExpectedResult = true, Description = "RegularHell.05.06")]
        [TestCase("", "hoho", ExpectedResult = false, Description = "RegularHell.05.07")]
        [TestCase("he sd.f dsk e8.sd??l**23, 23,f.s++83+", "h  8.?*3+", ExpectedResult = true, Description = "RegularHell.05.08")]
        public bool TestisSubsequence(string t, string s)
        {
            return RegularHell.isSubsequence(t, s);
        }

        [TestCase("8one 003number 201numbers li-000233le number444", 4, ExpectedResult = "233", Description = "RegularHell.04.01")]
        [TestCase("some023020 num ber 033 02103 32 meh peh beh 4328 ", 5, ExpectedResult = "4328", Description = "RegularHell.04.02")]
        [TestCase("007 is an awesome agent", 1, ExpectedResult = "7", Description = "RegularHell.04.03")]
        [TestCase("Everyone hates error 404", 1, ExpectedResult = "404", Description = "RegularHell.04.04")]
        [TestCase("LaS003920tP3rEt4t04Yte0023s3t", 4, ExpectedResult = "4", Description = "RegularHell.04.05")]
        [TestCase("=_aaYiM*}&0077|D))ztIV00012432748730156644204805614898523099655216oio0854102350044141_|YDL0584511290939644184700867021026771007612398051168360441323oIc:G*0204864749576405915~wqgN0037594999439741539584332{F&wjxiLy-mE", 4, ExpectedResult = "584511290939644184700867021026771007612398051168360441323", Description = "RegularHell.04.06")]
        public string TestnthNumber(string s, int n)
        {
            return RegularHell.nthNumber(s, n);
        }

        [TestCase("CodeFight On", ExpectedResult = "On CodeFight", Description = "RegularHell.03.01")]
        [TestCase("How are you today guys", ExpectedResult = "are How today you guys", Description = "RegularHell.03.02")]
        [TestCase("IAmALongStringWithNoWhiteSpaceCharacters", ExpectedResult = "IAmALongStringWithNoWhiteSpaceCharacters", Description = "RegularHell.03.03")]
        [TestCase("A b C D e F g h I j", ExpectedResult = "b A D C F e h g j I", Description = "RegularHell.03.04")]
        [TestCase("", ExpectedResult = "", Description = "RegularHell.03.05")]
        public string TestswapAdjacentWords(string s)
        {
            return RegularHell.swapAdjacentWords(s);
        }

        [TestCase("There are 12 points", ExpectedResult = "There are ## points", Description = "RegularHell.02.01")]
        [TestCase("012ss210", ExpectedResult = "###ss###", Description = "RegularHell.02.02")]
        [TestCase(" _Aas 23", ExpectedResult = " _Aas ##", Description = "RegularHell.02.03")]
        [TestCase("no digits here", ExpectedResult = "no digits here", Description = "RegularHell.02.04")]
        [TestCase(" aa_0239mehce3d", ExpectedResult = " aa_####mehce#d", Description = "RegularHell.02.05")]
        [TestCase("v z gv4zyx eu mu ", ExpectedResult = "v z gv#zyx eu mu ", Description = "RegularHell.02.06")]
        public string TestreplaceAllDigitsRegExp(string input)
        {
            return RegularHell.replaceAllDigitsRegExp(input);
        }

        [TestCase("This is an example of *correct* sentence.", ExpectedResult = true, Description = "RegularHell.01.01")]
        [TestCase("!this sentence is TOTALLY incorrecT", ExpectedResult = false, Description = "RegularHell.01.02")]
        [TestCase("Almost correct sentence", ExpectedResult = false, Description = "RegularHell.01.03")]
        [TestCase("Something is !wrong! here.", ExpectedResult = false, Description = "RegularHell.01.04")]
        [TestCase("Time to roll!!!", ExpectedResult = false, Description = "RegularHell.01.05")]
        [TestCase("This one is okay though, isn't it?", ExpectedResult = true, Description = "RegularHell.01.06")]
        [TestCase("this sentence, I'm afraid, is a bit incorrect.", ExpectedResult = false, Description = "RegularHell.01.07")]
        [TestCase("I'm glad this sentence is correct, my friends.", ExpectedResult = true, Description = "RegularHell.01.08")]
        [TestCase("CodeFights is lame!!!", ExpectedResult = false, Description = "RegularHell.01.09")]
        public bool TestisSentenceCorrect(string sentence)
        {
            return RegularHell.isSentenceCorrect(sentence);
        }

    }
}
