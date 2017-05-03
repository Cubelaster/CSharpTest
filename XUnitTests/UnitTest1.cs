using CSharpTest;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [MemberData("DateDiff_TestDataList", MemberType =  typeof(TestData))]
        public void DateDiff_ShouldPass(DateTime? StartDate, DateTime? EndDate, int result)
        {
            Assert.True(Utils.DateDiff(StartDate, EndDate) == result);
        }


        [Theory]
        [MemberData("Duplicates_TestData", MemberType = typeof(TestData))]
        public void Duplicates_ShouldPass(int[] originalArray, int numberOfDuplicates)
        {
            Assert.True(Utils.Duplicates(originalArray).Length == numberOfDuplicates);
        }

    }

    public class TestData
    {
        public static readonly List<object[]> DateDiff_TestDataList = new List<object[]>
        {
            new object[]{ new DateTime(2017, 1, 12), new DateTime(2017, 1, 12), 0 },
            new object[]{ new DateTime(2017, 1, 12), new DateTime(2017, 1, 13), -1 },
            new object[]{ new DateTime(2017, 1, 13), new DateTime(2017, 1, 12), 1 },
            new object[]{ null, null, 0 }
        };

        public static readonly List<object[]> Duplicates_TestData = new List<object[]>
        {
            new object[] { new int[] { 1, 1, 1, 2 }, 1 },
            new object[] { new int[] { 1, 1, 2, 2 }, 2 },
            new object[] { new int[] { 1, 2, 3, 4 }, 0 },
            new object[] { new int[] { 1, 1, 1, 1 }, 1 }
        };
    }
}
