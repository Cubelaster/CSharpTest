using System;
using System.Collections.Generic;

namespace CSharpTest
{
    public static class Utils
    {
        /// <summary>
        /// Returns the days difference of StartDate - EndDate in integer format.
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public static int DateDiff(DateTime? StartDate, DateTime? EndDate)
        {
            if(!StartDate.HasValue || !EndDate.HasValue)
            {
                return 0;
            }
            return Convert.ToInt32((StartDate.Value - EndDate.Value).TotalDays);
        }

        /// <summary>
        /// Finds the key values that are duplicates in original array of ints.
        /// </summary>
        /// <param name="original">Array to be checked for duplicates.</param>
        /// <returns></returns>
        public static int[] Duplicates(int[] original)
        {
            List<int> duplicates = new List<int>();
            var keyValueDict = new Dictionary<int, int>();
            
            foreach(var value in original)
            {
                if (!keyValueDict.ContainsKey(value))
                {
                    keyValueDict[value] = 1;
                }
                else
                {
                    keyValueDict[value]++;
                }
            }

            foreach(var key in keyValueDict.Keys)
            {
                if(keyValueDict[key] > 1)
                {
                    duplicates.Add(key);
                }
            }
            return duplicates.ToArray();
        }
    }
}