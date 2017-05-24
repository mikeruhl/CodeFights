using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.Tests.Common;
using CodeFights.TheCore;
using NUnit.Framework;

namespace CodeFights.Tests.TheCore
{
    [TestFixture]
    public class TimeRiverTests
    {
        [TestCase(3, "Wednesday", "November", 2016, ExpectedResult = 16, Description = "TimeRiver.08.01")]
        [TestCase(5, "Thursday", "November", 2016, ExpectedResult = -1, Description = "TimeRiver.08.02")]
        [TestCase(1, "Thursday", "January", 2015, ExpectedResult = 1, Description = "TimeRiver.08.03")]
        [TestCase(2, "Thursday", "January", 2015, ExpectedResult = 8, Description = "TimeRiver.08.04")]
        [TestCase(3, "Thursday", "January", 2015, ExpectedResult = 15, Description = "TimeRiver.08.05")]
        [TestCase(3, "Thursday", "January", 2101, ExpectedResult = 20, Description = "TimeRiver.08.06")]
        [TestCase(3, "Thursday", "January", 2401, ExpectedResult = 18, Description = "TimeRiver.08.07")]
        [TestCase(2, "Thursday", "December", 2500, ExpectedResult = 9, Description = "TimeRiver.08.08")]
        [TestCase(5, "Monday", "February", 2016, ExpectedResult = 29, Description = "TimeRiver.08.09")]
        public int Testholiday(int x, string weekDay, string month, int yearNumber)
        {
            return TimeRiver.holiday(x, weekDay, month, yearNumber);
        }


        #region TR07
        private static List<ComplexTest<object[], int>> TR07 = new List<ComplexTest<object[], int>>
        {
            new ComplexTest<object[], int> //1
            {
                Input = new object[] {2015, new[] {2,3}, new[] {"11-04",
 "02-22",
 "02-23",
 "03-07",
 "03-08",
 "05-09"}},
                ExpectedResult = 3
            },
             new ComplexTest<object[], int> //2
            {
                Input = new object[] {1900, new int[] {}, new string[] {}},
                ExpectedResult = 0
            },
              new ComplexTest<object[], int> //3
            {
                Input = new object[] {2100, new[] {1,4,7}, new[] {"10-28",
 "05-03",
 "10-02",
 "05-07",
 "05-25",
 "09-04",
 "10-30",
 "03-03",
 "09-02",
 "11-08"}},
                ExpectedResult = 4
            },
               new ComplexTest<object[], int> //4
            {
                Input = new object[] {1956, new[] {1,4,6,7}, new[] {"03-17",
 "04-03",
 "03-08",
 "09-18",
 "05-28",
 "02-14",
 "10-20",
 "01-02",
 "01-22",
 "10-04",
 "02-02",
 "10-07",
 "09-30",
 "05-20",
 "05-23",
 "09-22",
 "01-12",
 "05-02",
 "10-21",
 "03-20"}},
                ExpectedResult = 13
            }
        };
#endregion
        [TestCaseSource("TR07")]
        public void TestmissedClasses(ComplexTest<object[], int> test)
        {
            Assert.AreEqual(test.ExpectedResult, TimeRiver.missedClasses((int)test.Input[0], (int[])test.Input[1], (string[])test.Input[2]));
        }


        [TestCase("02-2016", ExpectedResult = "08-2016", Description = "TimeRiver.06.01")]
        [TestCase("05-2027", ExpectedResult = "11-2027", Description = "TimeRiver.06.02")]
        [TestCase("09-2099", ExpectedResult = "02-2100", Description = "TimeRiver.06.03")]
        [TestCase("01-1970", ExpectedResult = "06-1970", Description = "TimeRiver.06.04")]
        [TestCase("07-2024", ExpectedResult = "09-2025", Description = "TimeRiver.06.05")]
        public string TestregularMonths(string currMonth)
        {
            return TimeRiver.regularMonths(currMonth);
        }

        [TestCase("23:35", new[] { 60, 90, 140}, ExpectedResult =3, Description ="TimeRiver.05.01")]
        [TestCase("00:00", new[] { 60, 120, 180, 250 }, ExpectedResult = 4, Description = "TimeRiver.05.02")]
        [TestCase("13:36", new[] { 23, 33, 45, 56, 66, 88 }, ExpectedResult = 1, Description = "TimeRiver.05.03")]
        [TestCase("22:50", new int[] { }, ExpectedResult = 1, Description = "TimeRiver.05.04")]
        [TestCase("20:18", new[] {222, 342 }, ExpectedResult = 3, Description = "TimeRiver.05.05")]
        [TestCase("12:05", new[] { 1, 109, 113, 344, 345, 478, 545, 565, 809, 814, 838, 883, 971, 1007, 1029, 1053, 1133, 1271, 1314, 1500 }, ExpectedResult = 1, Description = "TimeRiver.05.06")]
        [TestCase("17:10", new[] { 150, 160, 293, 589, 614, 716, 760, 776, 781, 911, 1040, 1438 }, ExpectedResult = 3, Description = "TimeRiver.05.07")]
        [TestCase("18:15", new[] { 117, 241, 364, 375, 545, 1317 }, ExpectedResult = 1, Description = "TimeRiver.05.08")]
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
