using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class TimeRiverTests
    {
        [TestCase("02-01-2016", ExpectedResult = 5, Description = "TimeRiver.03.01")]
        [TestCase("01-01-1900", ExpectedResult = 6, Description = "TimeRiver.03.02")]
        [TestCase("02-29-2016", ExpectedResult = 28, Description = "TimeRiver.03.03")]
        [TestCase("01-16-2027", ExpectedResult = 11, Description = "TimeRiver.03.04")]
        [TestCase("10-12-2000", ExpectedResult = 6, Description = "TimeRiver.03.05")]
        [TestCase("02-29-2072", ExpectedResult = 40, Description = "TimeRiver.03.06")]
        public int TestdayOfWeek(string birthdayDate)
        {
            return TimeRiver.dayOfWeek(birthdayDate);
        }

        [TestCase("02:20:00", "07:00:00", ExpectedResult = new[] {1, 3}, Description = "TimeRiver.02.01")]
        [TestCase("25:26:20", "25:26:20", ExpectedResult = new[] { 1, 1 }, Description = "TimeRiver.02.02")]
        [TestCase("00:02:20", "00:10:00", ExpectedResult = new[] { 7, 30 }, Description = "TimeRiver.02.03")]
        public int[] TestvideoPart(string part, string total)
        {
            return TimeRiver.videoPart(part, total);
        }
    }
}
