using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.InterviewPrep;
using CodeFights.Tests.Common;
using NUnit.Framework;

namespace CodeFights.Tests.InterviewPrep
{
    public class InterviewPrepTests
    {
        #region symmetrictreecases

        private static List<ComplexTest<Tree<int>, bool>> SymmetricTrees = new List<ComplexTest<Tree<int>, bool>>
        {
            new ComplexTest<Tree<int>, bool>(new Tree<int>()
            {
                value = 1,
                left = new Tree<int>
                {
                    value = 2,
                    left = null,
                    right = null
                },
                right = new Tree<int>
                {
                    value = 3,
                    left = null,
                    right = null
                }
            }, true),
            new ComplexTest<Tree<int>, bool>(new Tree<int>
            {
                value = 1,
                left = new Tree<int>
                {
                    value = 2,
                    left = null,
                    right = new Tree<int>
                    {
                        value = 3,
                        left = null,
                        right = null
                    }
                        },
                right = new Tree<int>
                {
                    value = 2,
                    left = null,
                    right = new Tree<int>
                    {
                        value = 3,
                        left = null,
                        right = null
                    }
                }
            }, false)
    };

        #endregion

        [Description("InterviewPrep.IsTreeSymmetric")]
        [TestCaseSource("SymmetricTrees")]
        public void IsTreeSymmetricTests(ComplexTest<Tree<int>, bool> testCase)
        {
            var result = CodeFights.InterviewPrep.InterviewPrep.IsTreeSymmetric(testCase.Input);
            Assert.AreEqual(testCase.ExpectedResult, result);
        }
    }
}
