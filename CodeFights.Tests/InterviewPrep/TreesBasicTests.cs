using CodeFights.InterviewPrep;
using NUnit.Framework;

namespace CodeFights.Tests.InterviewPrep
{
    [TestFixture]
    public class TreesBasicTests
    {
        [TestCase(3, 3, ExpectedResult = "Doctor", Description = "TreesBasic.FindProfession.1")]
        [TestCase(1, 1, ExpectedResult = "Engineer", Description = "TreesBasic.FindProfession.2")]
        [TestCase(4, 5, ExpectedResult = "Doctor", Description = "TreesBasic.FindProfession.3")]
        [TestCase(4, 6, ExpectedResult = "Engineer", Description = "TreesBasic.FindProfession.4")]
        [TestCase(4, 2, ExpectedResult = "Doctor", Description = "TreesBasic.FindProfession.5")]
        [TestCase(8, 100, ExpectedResult = "Engineer", Description = "TreesBasic.FindProfession.6")]
        [TestCase(10, 470, ExpectedResult = "Engineer", Description = "TreesBasic.FindProfession.7")]
        [TestCase(17, 5921, ExpectedResult = "Doctor", Description = "TreesBasic.FindProfession.8")]
        [TestCase(20, 171971, ExpectedResult = "Engineer", Description = "TreesBasic.FindProfession.9")]
        public string TestFindProfessions(int level, int position)
        {
            return FindProfession.Solution(level, position);
        }
    }
}
