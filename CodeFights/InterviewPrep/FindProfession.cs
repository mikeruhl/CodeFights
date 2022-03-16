using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.InterviewPrep
{
    public static class FindProfession
    {
        public static string Solution(int level, int pos)
        {
            return findProfession(level,pos) == 'e' ? "Engineer" : "Doctor";
        }

        private static char findProfession(int level, int pos)
        {
            if (level == 1)
                return 'e';

            if (findProfession(level - 1,
                              (pos + 1) / 2) == 'd')
                return (pos % 2 > 0) ?
                                 'd' : 'e';


            return (pos % 2 > 0) ?
                             'e' : 'd';
        }
    }
}
