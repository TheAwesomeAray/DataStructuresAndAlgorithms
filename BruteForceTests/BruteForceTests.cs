using BruteForce;
using Xunit;

namespace AlgorithmTests
{
    public class BruteForceTests
    {
        [Theory]
        [InlineData(new[] { 1, 0, 0, 0, 0 }, 1)]
        [InlineData(new[] { 3, 0, 0, 0, 0 }, 3)]
        [InlineData(new[] { 5, 0, 0, 0, 0 }, 5)]
        [InlineData(new[] { 9, 0, 0, 0, 0 }, 9)]
        [InlineData(new[] { 0, 1, 0, 0, 0 }, 10)]
        [InlineData(new[] { 5, 1, 0, 0, 0 }, 15)]
        [InlineData(new[] { 9, 1, 0, 0, 0 }, 19)]
        [InlineData(new[] { 0, 2, 0, 0, 0 }, 20)]
        [InlineData(new[] { 0, 0, 1, 0, 0 }, 100)]
        [InlineData(new[] { 0, 0, 0, 1, 0 }, 1000)]
        [InlineData(new[] { 9, 9, 9, 9, 0 }, 9999)]
        [InlineData(new[] { 3, 0, 1, 1, 0 }, 1103)]
        public void Iterate_GetsNextValue_ForCurrentIndex(int[] expected, int iterations)
        {
            var actual = new int[] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < iterations; i++)
                Iterator.GetNext(actual);

            Assert.Equal(expected, actual);
        }
    }
}
