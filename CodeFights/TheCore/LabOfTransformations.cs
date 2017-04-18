using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class LabOfTransformations
    {

        public static bool alphanumericLess(string s1, string s2)
        {
            var numbers = "0123456789";
            var tokens1 = new List<string>();
            var tokens2 = new List<string>();
            for (var i = 0; i < Math.Max(s1.Length, s2.Length); i++)
            {
                if (i < s1.Length)
                {

                    if (numbers.IndexOf(s1[i]) >= 0 && tokens1.Count > 0 && numbers.IndexOf(tokens1[tokens1.Count - 1][0]) >= 0)
                    {
                        tokens1[tokens1.Count - 1] += s1[i];
                    }
                    else
                    {
                        tokens1.Add(s1[i].ToString());
                    }
                }

                if (i < s2.Length)
                {
                    if (numbers.IndexOf(s2[i]) >= 0 && tokens2.Count > 0 && numbers.IndexOf(tokens2[tokens2.Count - 1][0]) >= 0)
                    {
                        tokens2[tokens2.Count - 1] += s2[i];
                    }
                    else
                    {
                        tokens2.Add(s2[i].ToString());
                    }
                }
            }
            var n1 = 0;
            var n2 = 0;

            bool? s1HasMoreLeadingZeros = null;

            for (var t = 0; t < Math.Max(tokens1.Count, tokens2.Count); t++)
            {
                if (t == tokens1.Count)
                    return true;
                if (t == tokens2.Count)
                    return false;
                if (int.TryParse(tokens1[t], out n1) && int.TryParse(tokens2[t], out n2))
                {
                    if (n1 != n2)
                        return n1 < n2;

                    if (tokens1[t].Length != tokens2[t].Length && s1HasMoreLeadingZeros == null)
                        s1HasMoreLeadingZeros = tokens1[t].Length > tokens2[t].Length;
                }
                else if (int.TryParse(tokens1[t], out n1))
                {
                    return true;
                }
                else if (int.TryParse(tokens2[t], out n2))
                {
                    return false;
                }
                else
                {
                    if (tokens1[t] != tokens2[t])
                        return tokens1[t][0] < tokens2[t][0];
                }
            }

            //equals

            if (s1HasMoreLeadingZeros != null)
                return (bool)s1HasMoreLeadingZeros;

            return false;

        }


        public static string decipher(string cipher)
        {
            var sb = new StringBuilder();
            var current = string.Empty;
            for (var i = 0; i < cipher.Length; i++)
            {
                var n = int.Parse(current + cipher[i]);
                if (n >= 97 & n <= 122)
                {
                    sb.Append((char)n);
                    current = string.Empty;
                }
                else
                {
                    current = n.ToString();
                }

            }
            return sb.ToString();
        }

        public static bool higherVersion(string ver1, string ver2)
        {
            var split1 = ver1.Split('.').Select(int.Parse).ToArray();
            var split2 = ver2.Split('.').Select(int.Parse).ToArray();
            for (var i = 0; i < split1.Length; i++)
            {
                if (split1[i] == split2[i])
                    continue;
                return split1[i] > split2[i];
            }
            return false;
        }

        public static string stolenLunch(string note)
        {
            var sb = new StringBuilder();
            foreach (var c in note)
            {
                if ("abcdefghij".Contains(c))
                    sb.Append("abcdefghij".IndexOf(c));
                else if ("0123456789".Contains(c))
                    sb.Append("abcdefghij".Substring(int.Parse(c.ToString()), 1));
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public static string cipher26(string message)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var sb = new StringBuilder();
            var runningSum = 0;
            foreach (var c in message)
            {
                var toAdd = alphabet.IndexOf(c);
                var find = 0;
                while ((runningSum + find) % 26 != toAdd)
                {
                    find++;
                }

                sb.Append(alphabet.Substring(find, 1));

                runningSum = (runningSum + find) % 26;

            }
            return sb.ToString();
        }


        public static string[] newNumeralSystem(char number)
        {
            var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var system = new List<string>();
            var nX = alpha.IndexOf(number);

            for (var i = 0; i <= Math.Floor(nX / 2.0); i++)
            {
                system.Add(alpha[i] + " + " + alpha[nX - i]);
            }
            return system.ToArray();
        }

        public static string reflectString(string inputString)
        {
            const string myAlpha = "abcdefghijklmnopqrstuvwxyz";

            return inputString.Aggregate(string.Empty, (current, c) => current + myAlpha[26 - myAlpha.IndexOf(c) - 1]);
        }

        public static string characterParity(char symbol)
        {
            if ("13579".Contains(symbol))
                return "odd";
            if ("02468".Contains(symbol))
                return "even";
            return "not a digit";
        }
    }
}
