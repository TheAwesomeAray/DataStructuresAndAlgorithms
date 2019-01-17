using DivideAndConquer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgorithmTests
{
    public class QuickSortTests
    {

        [Theory]
        [InlineData(new[] { 'a' }, new[] { 'a' })]
        [InlineData(new[] { 'a', 'c', 'b' }, new[] { 'a', 'b', 'c' })]
        [InlineData(new[] { 'z', 'c', 'b', 'a', 'h', 'd' }, new[] { 'a', 'b', 'c', 'd', 'h', 'z' })]
        public static void QuickSort_ReturnsOrderedList(char[] input, char[] expected)
        {
            var actual = Sort.QuickSort(input.ToList());

            Assert.Equal(expected.ToList(), actual);
        }
    }
}
