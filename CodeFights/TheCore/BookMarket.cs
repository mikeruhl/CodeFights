using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class BookMarket
    {

        public static bool isUnstablePair(string filename1, string filename2)
        {
            var l1 = new List<string> {filename1, filename2};
            l1.Sort(StringComparer.Ordinal);
            var l2 = new List<string> {filename1, filename2};
            l2.Sort(StringComparer.InvariantCultureIgnoreCase);
            return l1[0] != l2[0];
        }

        //isMAC48Address is in ArcadeIntro10

        public static string htmlEndTagByStartTag(string startTag)
        {
            return "</" + startTag.Substring(startTag.IndexOf("<")+1, startTag.IndexOfAny(new [] { '>', ' '}, startTag.IndexOf("<")) - startTag.IndexOf("<")-1) + ">";
        }

        //findEmailDomain also in ArcadeIntro10

        public static bool isCaseInsensitivePalindrome(string inputString)
        {
            return inputString.Substring(0, (int) Math.Ceiling((double) inputString.Length / 2.00)).ToLower() ==
                   new string(inputString.Substring((int)Math.Floor((double)inputString.Length / 2.00)).ToLower().Reverse().ToArray());
        }


        public static bool isTandemRepeat(string inputString)
        {
            return inputString.Length % 2 != 1 && inputString.Substring(0, inputString.Length / 2) == inputString.Substring(inputString.Length/2);
        }


        public static string properNounCorrection(string noun)
        {
            return new string(noun.Select((s, i) => i == 0 ? char.ToUpper(s) : char.ToLower(s)).ToArray());
        }

        public static string encloseInBrackets(string inputString)
        {
            return "(" + inputString + ")";
        }
    }
}
