using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class TimeRiver
    {

        public static int holiday(int x, string weekDay, string month, int yearNumber)
        {

            var months = new[]
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };
            var mi = Array.IndexOf(months, month) + 1;

            var weekDays = new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            var wd = Array.IndexOf(weekDays, weekDay);

            var dat = new DateTime(yearNumber, mi , 1);


            while ((int)dat.DayOfWeek != wd)
            {
                dat = dat.AddDays(1);
            }
            for(var y = 1; y < x; y ++)
            dat = dat.AddDays(7);     
            
            if (dat.Month != mi)
                return -1;

            return dat.Day;

        }


        public static int missedClasses(int year, int[] daysOfTheWeek, string[] holidays)
        {
            var dates =
                holidays.Select(h => h.Split('-'))
                    .Select(i => new DateTime(int.Parse(i[0]) > 5 ? year : year + 1, int.Parse(i[0]), int.Parse(i[1])))
                    .ToArray();

            return dates.Count(t => daysOfTheWeek.Select(z=>z == 7 ? 0 : z).Any(f => f == (int) t.DayOfWeek));

        }


        public static string regularMonths(string currMonth)
        {
            var splits = currMonth.Split('-');

            var dat = new DateTime(int.Parse(splits[1]), int.Parse(splits[0]), 1);
            dat = dat.AddMonths(1);
            while (dat.DayOfWeek != DayOfWeek.Monday)
                dat = dat.AddMonths(1);

            return dat.ToString("MM-yyyy");

        }

        public static int newYearCelebrations(string takeOffTime, int[] minutes)
        {
            var tally = 0;
            var newYears = 0;
            var newYearsDay = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            var timely = takeOffTime.Split(':').Select(s=>int.Parse(s)).ToArray();
            var currentTime = new DateTime(DateTime.Now.Year - 1, 12, 31, timely[0], timely[1], 0);
            if(currentTime.Hour <= 4)
            {
                if(currentTime.Hour == 4 && currentTime.Minute <=40)
                    currentTime = currentTime.AddDays(1);
                else if (currentTime.Hour != 4)
                    currentTime = currentTime.AddDays(1);
            }
            for( var i = 0; i < minutes.Length; i++)
            {
                if (currentTime <= newYearsDay && currentTime.AddMinutes(minutes[i] - tally) >= newYearsDay)
                    newYears++;
                currentTime = currentTime.AddMinutes(minutes[i] - tally);
                currentTime = currentTime.AddHours(-1);
                tally = minutes[i];
            }
            if (currentTime <= newYearsDay)
                newYears++;

            return newYears;
        }

        public static string curiousClock(string someTime, string leavingTime)
        {
            var sT = DateTime.Parse(someTime);
            var lT = DateTime.Parse(leavingTime);

            var span = lT.Subtract(sT);
            var reallyLeave = sT.Subtract(span);

            return reallyLeave.ToString("yyyy-MM-dd HH:mm");

        }

        public static int dayOfWeek(string birthdayDate)
        {
            var date = DateTime.Parse(birthdayDate);
            var isLeap = date.Day == 29 && date.Month == 2;
            var dow = date.DayOfWeek;
            int count = 1, day = date.Day;
            for (var i = 1; i < 100; i++)
            {
                date = date.AddYears(1);
                if (isLeap && DateTime.IsLeapYear(date.Year))
                    date = date.AddDays(1);
                if (dow == date.DayOfWeek && day == date.Day)
                {
                    break;
                }
                count++;
            }
            return count;
        }

        public static int[] videoPart(string part, string total)
        {
            var partS = (int)part.Split(':').Select((s, i) => int.Parse(s) * Math.Pow(60, 2 - i)).Sum();
            var totalS = (int)total.Split(':').Select((s, i) => int.Parse(s) * Math.Pow(60, 2 - i)).Sum();

            var a = partS;
            var b = totalS;


            while (b > 0)
            {
                var rem = a % b;
                a = b;
                b = rem;
            }

            return new[] { partS / a, totalS / a };

        }

        //validTime in ArcadeIntro12
    }
}
