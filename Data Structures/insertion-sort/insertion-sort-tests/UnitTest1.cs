using System;
using Xunit;
using insertion_sort;

namespace insertion_sort_tests
{
    public class UnitTest1
    {
        [Fact]
        public void InsertionSortWorksWithRandomArr()
        {
            int[] numbers = new int[6] { 1, -1, 4, 0, 6, 3 };
            int[] answer = new int[6] { -1, 0, 1, 3, 4, 6, };
            Assert.Equal(answer, Program.InsertionSort(numbers));
        }
        [Fact]
        public void InsertionSortWorksWithSortedArr()
        {
            int[] numbers = new int[6] { -1, 0, 1, 3, 4, 6, };
            int[] answer = new int[6] { -1, 0, 1, 3, 4, 6, };
            Assert.Equal(answer, Program.InsertionSort(numbers));
        }
        [Fact]
        public void InsertionSortWorksWithBackwardsArr()
        {
            int[] numbers = new int[6] { 6, 5, 4, 3, 2, 1 };
            int[] answer = new int[6] { 1, 2, 3, 4, 5, 6};
            Assert.Equal(answer, Program.InsertionSort(numbers));
        }
        [Fact]
        public void InsertionSortWorksWithWEmptysArr()
        {
            int[] numbers = new int[] { };
            int[] answer = new int[] { };
            Assert.Equal(answer, Program.InsertionSort(numbers));
        }
        [Fact]
        public void InsertionSortWorksWithSingleIntArr()
        {
            int[] numbers = new int[1] { 1 };
            int[] answer = new int[1] { 1 };
            Assert.Equal(answer, Program.InsertionSort(numbers));
        }
    }
}
