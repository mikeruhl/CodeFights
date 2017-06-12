using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CodeFights.Tests.Common;
using CodeFights.TheCore;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeFights.Tests.TheCore
{
    [TestFixture()]
    public class RegularHellTests
    {
        [TestCase("Roll d6-3 and 4d4+3 to pick a weapon, and finish the boss with 3d7!", ExpectedResult = 43, Description ="RH.09.01")]
        [TestCase("d6-almost 01d4+2 12d01-3 5d5-00 a valid formula", ExpectedResult = 46, Description = "RH.09.02")]
        [TestCase("meh4d2-3D3", ExpectedResult = 5, Description = "RH.09.03")]
        [TestCase("ad3+4, 44b-6, 5daa", ExpectedResult = 7, Description = "RH.09.04")]
        [TestCase("4d6-L1d20-10 did4n't expect that", ExpectedResult = 38, Description = "RH.09.05")]
        [TestCase("nothing here", ExpectedResult = 0, Description = "RH.09.06")]
        public int TestbugsAndBugfixes(string rules)
        {
            return RegularHell.bugsAndBugfixes(rules);
        }


        [TestCase("Hi, hi Jane! I'm so. So glad to to finally be able to write - WRITE!! - to you!", ExpectedResult=4, Description = "RH.08.01")]
        [TestCase("Yo-yo, how's s it going going for ya? Ya is okay, okay'nt ya?", ExpectedResult = 5, Description = "RH.08.02")]
        [TestCase("Hi Jane, how are you doing today?", ExpectedResult = 0, Description = "RH.08.03")]
        [TestCase("My friend, friend of mine, I am really-really happy for you! You are amazing, please write me back when you can.", ExpectedResult = 3, Description = "RH.08.04")]
        [TestCase("Everything is fine, fine perfectly here. Here I have fun (fun all the day!) days. Although I miss you, so please please, Jane, write, write me whenever you can! Can you do that? That is the only (!!ONLY!!) thing I ask from you, you sunshine.", ExpectedResult = 9, Description = "RH.08.05")]
        [TestCase("Do not notify me about this in the future", ExpectedResult = 0, Description = "RH.08.06")]
        [TestCase("ho-ho--he-he", ExpectedResult = 2, Description = "RH.08.07")]
        [TestCase("WeLl wElL", ExpectedResult = 1, Description = "RH.08.08")]
        public int TestrepetitionEncryption(string letter)
        {
            return RegularHell.repetitionEncryption(letter);
        }


        #region RH07
        private static List<ComplexTest<object[], string>> RH07 = new List<ComplexTest<object[], string>>
        {
            new ComplexTest<object[], string> //1
            {
                Input = new object[]
                {
                    "function add($n, m) {\t  return n + $m;\t}",
                    new [] {"n", "m"}
                },
                ExpectedResult = "function add($n, $m) {\t  return $n + $m;\t}"

            },
            new ComplexTest<object[], string> //2
            {
                Input = new object[]
                {
                    "function findSum(a, $cnt) {\t  var a0 = $a;\t  for (var _cnt = 0, _cnt < cnt; _cnt++)\t    a0 += _cnt;\t  return a0;\t}",
                    new [] {"a", "cnt"}
                },
                ExpectedResult = "function findSum($a, $cnt) {\t  var a0 = $a;\t  for (var _cnt = 0, _cnt < $cnt; _cnt++)\t    a0 += _cnt;\t  return a0;\t}"

            },
            new ComplexTest<object[], string> //3
            {
                Input = new object[]
                {
                    "function doNothing($uselessVariable) {\t  return $uselessVariable;\t}",
                    new [] { "uselessVariable" }
                },
                ExpectedResult = "function doNothing($uselessVariable) {\t  return $uselessVariable;\t}"

            },
            new ComplexTest<object[], string> //4
            {
                Input = new object[]
                {
                    "function addToVariable(variable) {\t  variable_which_should_be_increased_by_the_variable = 14;\t  variable_which_should_be_increased_by_the_variable += variable;\t  return variable_which_should_be_increased_by_the_variable;\t}",
                    new [] { "variable" }
                },
                ExpectedResult = "function addToVariable($variable) {\t  variable_which_should_be_increased_by_the_variable = 14;\t  variable_which_should_be_increased_by_the_variable += $variable;\t  return variable_which_should_be_increased_by_the_variable;\t}"

            },
            new ComplexTest<object[], string> //5
            {
                Input = new object[]
                {
                    "function replaceThemAll(rep, laceT, hemAll, ornot) {\t  var tmp = rep;\t  rep = laceT;\t  laceT = hemAll;\t  hemAll = tmp;\t  return [rep, laceT, hemAll]\t}",
                    new [] {"rep",
 "laceT",
 "hemAll"}
                },
                ExpectedResult = "function replaceThemAll($rep, $laceT, $hemAll, ornot) {\t  var tmp = $rep;\t  $rep = $laceT;\t  $laceT = $hemAll;\t  $hemAll = tmp;\t  return [$rep, $laceT, $hemAll]\t}"

            },
            new ComplexTest<object[], string> //6
            {
                Input = new object[]
                {
                    "function returnSecond(fu_,_re5,NOO) {\t  return _re5;\t}",
                    new [] {"fu_",
 "_re5",
 "NOO"}
                },
                ExpectedResult = "function returnSecond($fu_,$_re5,$NOO) {\t  return $_re5;\t}"

            },
            new ComplexTest<object[], string> //7
            {
                Input = new object[]
                {
                    "function getLength(k, m) {\t  return m.length;\t}",
                    new [] {"m"}
                },
                ExpectedResult = "function getLength(k, $m) {\t  return $m.length;\t}"

            },

        };
        #endregion
        [TestCaseSource("RH07")]
        public void TestprogramTranslation(ComplexTest<object[], string> test)
        {
            Assert.AreEqual(test.ExpectedResult, RegularHell.programTranslation((string)test.Input[0], (string[])test.Input[1]));

        }

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
