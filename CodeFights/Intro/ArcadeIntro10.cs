using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeFights.Intro
{
    public static class ArcadeIntro10
    {

        public static bool isMAC48Address(string inputString)
        {
            var re = new Regex("[A-F,0-9]{2}-[A-F,0-9]{2}-[A-F,0-9]{2}-[A-F,0-9]{2}-[A-F,0-9]{2}-[A-F,0-9]{2}$");
            return re.IsMatch(inputString);
        }

        public static int electionsWinners(int[] votes, int k)
        {
            var toBeat = votes.Max();
            if (votes.Count(a => a == toBeat) == 1 && k == 0)
                return 1;

            return votes.Where(t => t + k > toBeat).Count();
            //return votes.Where((t1, i) => votes.Where((s, t) => t != i).ToArray().All(m => m < t1 + k)).Count();
        }


        public static string buildPalindrome(string st)
        {
            Func<string, bool> IsPal = (string s) =>
            {
                for (var i = 0; i < s.Length; i++)
                {
                    if (s.Substring(i, 1) != s.Substring(s.Length - 1 - i, 1))
                        return false;
                }
                    return true;
            };

            var sb = new StringBuilder();
            for (var i = 0; i < st.Length; i++)
            {
                if (IsPal(st + sb))
                {
                    return sb.Insert(0, st).ToString();
                }
                
                    sb.Insert(0, st.Substring(i, 1));
               
            }

            return sb.Insert(0, st).ToString();
        }

        public static string findEmailDomain(string address)
        {
            return address.Substring(address.LastIndexOf("@") + 1);
        }

        public static bool isBeautifulString(string inputString)
        {
            var lastCount = int.MaxValue;
            var thisCount = 0;
            foreach (var l in "abcdefghijklmnopqrstuvwxyz")
            {
                thisCount = inputString.Count(b => b == l);
                if (thisCount > lastCount)
                    return false;

                lastCount = thisCount;
            }
            return true;
        }
    }
}
