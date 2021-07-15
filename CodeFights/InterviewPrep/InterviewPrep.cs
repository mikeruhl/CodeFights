using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.InterviewPrep
{
    public static class InterviewPrep
    {
        public static bool IsTreeSymmetric(Tree<int> t)
        {
            if (t.left?.value != t.right?.value)
                return false;
            return SymmetricValues(t.left, t.right);
        }

        private static bool SymmetricValues(Tree<int> left, Tree<int> right)
        {
            if (left == null || right == null)
                return left == null && right == null;

            if (left?.value != right?.value)
                return false;

            if(left.left == null || right.right == null)
                return left.left == null && right.right == null;

            if (!SymmetricValues(left.left, right.right))
                return false;

            if (left.right == null || right.left == null)
                return left.right == null && right.left == null;

            if (!SymmetricValues(left.right, right.left))
                return false;
            return true;
        }
    }
}
