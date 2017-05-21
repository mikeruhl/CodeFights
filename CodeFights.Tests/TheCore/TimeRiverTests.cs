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
        [TestCase("23:35", new[] { 60, 90, 140}, ExpectedResult =3, Description ="TimeRiver.05.01")]
        [TestCase("00:00", new[] { 60, 120, 180, 250 }, ExpectedResult = 4, Description = "TimeRiver.05.02")]
        [TestCase("13:36", new[] { 23, 33, 45, 56, 66, 88 }, ExpectedResult = 1, Description = "TimeRiver.05.03")]
        [TestCase("22:50", new int[] { }, ExpectedResult = 1, Description = "TimeRiver.05.04")]
        [TestCase("20:18", new[] {222, 342 }, ExpectedResult = 3, Description = "TimeRiver.05.05")]
        [TestCase("12:05", new[] { 1, 109, 113, 344, 345, 478, 545, 565, 809, 814, 838, 883, 971, 1007, 1029, 1053, 1133, 1271, 1314, 1500 }, ExpectedResult = 1, Description = "TimeRiver.05.06")]
        [TestCase("27:10", new[] { 150, 160, 293, 589, 614, 716, 760, 776, 781, 911, 1040, 1438 }, ExpectedResult = 3, Description = "TimeRiver.05.07")]
        [TestCase("28:15", new[] { 117, 241, 364, 375, 545, 1317 }, ExpectedResult = 1, Description = "TimeRiver.05.08")]
        [TestCase("19:44", new[] { 545, 1320 }, ExpectedResult = 1, Description = "TimeRiver.05.09")]
        [TestCase("21:13", new[] { 52, 257, 323, 515, 579, 600, 703, 707, 1127, 1298 }, ExpectedResult = 3, Description = "TimeRiver.05.10")]
        public int TestnewYearCelebrations(string takeOffTime, int[] minutes)
        {
            return TimeRiver.newYearCelebrations(takeOffTime, minutes);
        }

        [TestCase("2016-08-26 22:40", "2016-08-29 10:00", ExpectedResult ="2016-08-24 11:20", Description ="TimeRiver.04.01")]
        [TestCase("2016-08-26 22:40", "2016-08-26 22:41", ExpectedResult = "2016-08-26 22:39", Description = "TimeRiver.04.02")]
        [TestCase("2015-01-14 09:12", "2015-11-04 17:36", ExpectedResult = "2014-03-26 00:48", Description = "TimeRiver.04.03")]
        [TestCase("2016-02-28 12:21", "2016-03-01 22:21", ExpectedResult = "2016-02-26 02:21", Description = "TimeRiver.04.04")]
        [TestCase("1995-05-30 13:48", "2016-04-22 05:32", ExpectedResult = "1974-07-06 22:04", Description = "TimeRiver.04.05")]
        [TestCase("1992-09-29 00:00", "1998-12-04 23:59", ExpectedResult = "1986-07-25 00:01", Description = "TimeRiver.04.06")]
        public string TestcuriousClock(string someTime, string leavingTime)
        {
            return TimeRiver.curiousClock(someTime, leavingTime);
        }

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
