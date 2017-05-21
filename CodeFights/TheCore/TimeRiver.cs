using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.TheCore
{
    public static class TimeRiver
    {

        public static int newYearCelebrations(string takeOffTime, int[] minutes)
        {
            var isNewYearsEve = false;
            var newYears = 1;
            var timely = takeOffTime.Split(':').Select(s=>int.Parse(s)).ToArray();
            if(timely[0] >= 4 && timely[1] >= 41)
            {
                isNewYearsEve = true;
            }
            for( var i = 0; i < minutes.Length; i++)
            {
               
            }
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
