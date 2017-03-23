using System.Linq;
using System.Text;

namespace CodeFights.Intro
{

    public static class ArcadeIntro11
    {

        public static int deleteDigit(int n)
        {
            var o = n.ToString().ToCharArray();
            var x = int.MinValue;
            int temp;
            for (var i = 0; i < o.Length; i++)
            {
                var what = new string(o.Where((a, b) => b != i).ToArray()).TrimStart('0');
                if (string.IsNullOrEmpty(what))
                    temp = 0;
                else
                    temp = int.Parse(what);

                if (temp > x)
                    x = temp;
            }

            return x;
        }

        public static int chessKnight(string cell)
        {
            var c = 0;
            switch (cell.ToCharArray()[0])
            {
                case 'a':
                    c = 1;
                    break;
                case 'b':
                    c = 2;
                    break;
                case 'c':
                    c = 3;
                    break;
                case 'd':
                    c = 4;
                    break;
                case 'e':
                    c = 5;
                    break;
                case 'f':
                    c = 6;
                    break;
                case 'g':
                    c = 7;
                    break;
                case 'h':
                    c = 8;
                    break;
            }

            var r = int.Parse(cell.ToCharArray()[1].ToString());
            var tally = 0;

            if (c + 1 < 9 & r + 2 < 9)
                tally++;
            if (c + 2 < 9 & r + 1 < 9)
                tally++;
            if (c + 2 < 9 & r - 1 > 0)
                tally++;
            if (c + 1 < 9 & r - 2 > 0)
                tally++;
            if (c - 1 > 0 & r - 2 > 0)
                tally++;
            if (c - 2 > 0 & r - 1 > 0)
                tally++;
            if (c - 2 > 0 & r + 1 < 9)
                tally++;
            if (c - 1 > 0 & r + 2 < 9)
                tally++;

            return tally;

        }

        public static string lineEncoding(string s)
        {
            var sChar = s.ToCharArray();
            var count = 1;
            var output = new StringBuilder();
            for (var i = 0; i < sChar.Length; i++)
            {
                if (i + 1 == sChar.Length || sChar[i] != sChar[i + 1])
                {
                    if (count == 1)
                    {
                        output.Append(sChar[i]);
                    }
                    else
                    {
                        output.Append(count + sChar[i].ToString());
                    }
                    count = 1;
                }
                else
                {
                    count++;
                }

            }
            return output.ToString();
        }

        public static bool isDigit(char symbol)
        {
            return "1234567890".Contains(symbol);
        }
    }
}
