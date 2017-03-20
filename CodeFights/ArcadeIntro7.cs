using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFights
{
    public static class ArcadeIntro7
    {

        public static bool stringsRearrangement(string[] inputArray)
        {
            var queue = new Queue<List<string>>();
            
            foreach (var t in inputArray)
            {
                queue.Enqueue(new List<string>{ t });
            }

            Func<string, string, bool> offByOne = (s1, s2) =>
            {
                return s1.Where((t, s) => s1.Substring(s, 1) != s2.Substring(s, 1)).Count() == 1;
            };

            while (queue.Count != 0)
            {
                var q = queue.Dequeue();
  
                    foreach (var i in inputArray)
                    {
                        if (q.Count(a1=>a1 == i) < inputArray.Count(a2=>a2 == i) && offByOne(q[q.Count-1], i))
                        {
                            var newList = new List<string>();
                            newList.AddRange(q);
                            newList.Add(i);
                            if (newList.Count == inputArray.Length)
                                return true;

                            queue.Enqueue(newList);
                        }
                    }
                
            }

            return false;
        }

        public static int absoluteValuesSumMinimization(int[] a)
        {
            var smallestInd = 0;
            var smallest = int.MaxValue;
            var newSmallest = int.MaxValue;
            for (var i = 0; i < a.Length; i++)
            {
                newSmallest = a.Sum(x => Math.Abs(x - a[i]));
                if (newSmallest < smallest)
                {
                    smallest = newSmallest;
                    smallestInd = i;
                }
            }

            return a[smallestInd];
        }

        public static int depositProfit(int deposit, int rate, int threshold)
        {
            var dDeposit = (double)deposit;
            var year = 0;
            while (dDeposit < threshold)
            {
                dDeposit += Math.Round(dDeposit * rate / 100, 2);
                year++;
            }
            return year;
        }

       public static int circleOfNumbers(int n, int firstNumber)
       {
           var halfway = n / 2;
           if(firstNumber < halfway)
            return halfway + firstNumber;
           else if (firstNumber == halfway)
               return 0;
           else
               return firstNumber - halfway;
       }
    }
}
