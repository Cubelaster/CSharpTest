using System;

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
    }
}
