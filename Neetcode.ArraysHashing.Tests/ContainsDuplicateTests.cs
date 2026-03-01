using Xunit;
using Neetcode.ArraysHashing;

namespace Neetcode.ArraysHashing.Tests;

public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicate_ReturnsExpected(int[] nums, bool expected)
    {
        bool result = ContainsDuplicateSolution.ContainsDuplicate(nums);
        Assert.Equal(expected, result);
    }
}