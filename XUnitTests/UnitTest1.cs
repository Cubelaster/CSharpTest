using CSharpTest;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [MemberData("DateDiff_TestDataList", MemberType =  typeof(DateDiff_TestData))]
        public void DateDiff_ShouldPass(DateTime? StartDate, DateTime? EndDate, int result)
        {
            Assert.True(Utils.DateDiff(StartDate, EndDate) == result);
        }
    }

    public class DateDiff_TestData
    {
        public static readonly List<object[]> DateDiff_TestDataList = new List<object[]>
        {
            new object[]{ new DateTime(2017, 1, 12), new DateTime(2017, 1, 12), 0 },
            new object[]{ new DateTime(2017, 1, 12), new DateTime(2017, 1, 13), -1 },
            new object[]{ new DateTime(2017, 1, 13), new DateTime(2017, 1, 12), 1 },
            new object[]{ null, null, 0 }
        };
    }
}
