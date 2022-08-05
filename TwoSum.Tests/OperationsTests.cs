using NUnit.Framework;

namespace TwoSum.Tests;

public class OperationsTests
{
    [TestCase(new int[] {2,7,11,15}, 9, new int[]{0,1})]
    [TestCase(new int[] {11,15,2,7}, 9, new int[]{2,3})]
    [TestCase(new int[] {4,4,2,7}, 8, new int[]{0,1})]
    [TestCase(new int[] {0,4,2,8}, 8, new int[]{0,3})]
    public void TwoSumTest(int[] numbers, int target, int[] expected)
    {
        var twoSum = new TwoSum.Logic.Operations();
        var result = twoSum.TwoSum(numbers, target);

        Assert.AreEqual(expected, result);
    }

}