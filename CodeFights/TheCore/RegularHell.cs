using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class RegularHell
    {

        public static int bugsAndBugfixes(string rules)
        {
            Regex regex = new Regex("([0-9]+)*d([0-9]+)([\\+|-][0-9]+)*");
            MatchCollection formulas = regex.Matches(rules);

            int res = 0;
            foreach (Match match in formulas)
            {
                GroupCollection formula = match.Groups;
                int rolls = String.IsNullOrEmpty(formula[1].Value.Trim()) ?
                  1 : Int32.Parse(formula[1].Value);
                int dieType = Int32.Parse(formula[2].Value);
                int formulaMax = rolls * dieType;

                if (!String.IsNullOrEmpty(formula[3].Value))
                {
                    if (formula[3].Value[0] == '-')
                    {
                        formulaMax -= Int32.Parse(formula[3].Value.Substring(1));
                    }
                    else
                    {
                        formulaMax += Int32.Parse(formula[3].Value.Substring(1));
                    }
                }

                res += formulaMax;
            }

            return res;
        }


        public static int repetitionEncryption(string letter)
        {
            Regex regex = new Regex("[^a-zA-Z]?([a-zA-Z]+)[^a-zA-Z]+\\1([^a-zA-Z]+|$)", RegexOptions.IgnoreCase);
            return regex.Matches(letter).Count;
        }


        public static string programTranslation(string solution, string[] args)
        {
            string argumentVariants = String.Join("|", args);
            string pattern = "\\$?\\b("+argumentVariants+")\\b";
            string sub = "$$$1";
            return Regex.Replace(solution, pattern, sub);
        }

        public static bool eyeRhyme(string pairOfLines)
        {

            var regex = new Regex("(.*)(...)(\t)(.*)(...)$");
            var match = regex.Match(pairOfLines);
            return match.Groups[2].Value == match.Groups[5].Value;
        }

        public static bool isSubsequence(string t, string s)
        {
            var pat = "(";
            foreach (var c in s)
            {
                if (@"[\^$.|?*+()".Contains(c.ToString()))
                {
                    pat += '\\';
                }
                pat += c + "+.*";
            }
            pat += ")";
            
        var regex = new Regex(pat);
            return regex.Match(t).Success;
        }

        public static string nthNumber(string s, int n)
        {
            var regex = new Regex("\\d+");
            return regex.Matches(s)[n-1].Value.TrimStart('0');
        }

        public static string swapAdjacentWords(string s)
        {
            
            var regex = new Regex("\\w+");
            var groups = regex.Matches(s);
            var odds = new List<string>();
            var evens = new List<string>();

            var l = 0;
            foreach (Match g in groups)
            {

                if(l % 2 == 1)
                    evens.Add(g.Value);
                else
                    odds.Add(g.Value);

                l++;
            }

            var sb = new StringBuilder();
            for (var i = 0; i < Math.Max(odds.Count, evens.Count); i++)
            {
                if (i < evens.Count)
                    sb.Append(evens[i] + " ");
                if (i < odds.Count)
                    sb.Append(odds[i] + " ");
            }

            return sb.ToString().Trim();
        }

        public static string replaceAllDigitsRegExp(string input)
        {
           var regEx = new Regex("[0-9]");
            return regEx.Replace(input, "#");
        }

        public static bool isSentenceCorrect(string sentence)
        {
            var regex = new Regex("^[A-Z][^.!?]*[.!?]$");
            return regex.IsMatch(sentence);
        }

    }
}
