using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public static class ArcadeIntro6
    {

        public static bool chessBoardCellColor(string cell1, string cell2)
        {
            if (cell1.Length != 2 | cell2.Length != 2)
                return false;

            var cell1c = char.ToUpper(cell1.Substring(0,1).ToCharArray()[0]) - 64;
            var cell2c = char.ToUpper(cell2.Substring(0, 1).ToCharArray()[0]) - 64;

            var cell1r = int.Parse(cell1.Substring(1, 1));
            var cell2r = int.Parse(cell2.Substring(1, 1));

            return (cell1c + cell1r) % 2 == (cell2c + cell2r) % 2;
        }


        public static string alphabeticShift(string inputString)
        {
            var sb = new StringBuilder();
            var c = 'a';
            for (var i = 0; i < inputString.Length; i++)
            {
                if (inputString.Substring(i, 1) == "z")
                    sb.Append("a");
                else
                {
                    c = inputString.Substring(i, 1).ToCharArray()[0];
                    c++;
                    sb.Append(c);
                }

            }

            return sb.ToString();
        }

        public static bool variableName(string name)
        {
            if ("1234567890".Contains(name.Substring(0, 1)))
                return false;

            return name.All(c => "1234567890abcdefghijklmnopqrstuvwxyz_".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) != -1);
        }

        public static bool evenDigitsOnly(int n)
        {
            var s = n.ToString();
            foreach (var c in s)
            {
                if ("13579".Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (var i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                    inputArray[i] = substitutionElem;
            }
            return inputArray;
        }
    }
}
