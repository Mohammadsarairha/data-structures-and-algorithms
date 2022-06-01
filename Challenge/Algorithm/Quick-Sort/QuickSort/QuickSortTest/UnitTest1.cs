using System;
using Xunit;
using QuickSort;

namespace QuickSortTest
{
    public class UnitTest1
    {
        // Test Quick Sort function
        [Fact]
        public void Test1()
        {
            int[] sortArr = new int[] { 15, 38, 39, 41, 42, 51, 66, 72, 95 };

            int[] arr = new int[] { 51, 95, 66, 72, 42, 38, 39, 41, 15 };

            Program.Quick_Sort(arr, 0, arr.Length - 1);

            Assert.Equal(sortArr , arr);
        }
    }
}
