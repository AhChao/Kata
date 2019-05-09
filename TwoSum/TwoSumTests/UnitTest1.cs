using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace TwoSumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void arrayCmpTest()
        {
            int[] arr1 = { 2, 4 };
            int[] arr2 = { 2, 4 };
            Assert.IsTrue(Solution.ArrayCmp(arr1, arr2),"Wrong Case");
        }
        [TestMethod]
        public void arrayCmpErrTest()
        {
            int[] arr1 = { 2, 4 };
            int[] arr2 = { 2, 5 };
            Assert.IsFalse(Solution.ArrayCmp(arr1, arr2), "Wrong Case");
        }
        [TestMethod]
        public void twoSumTest()
        {
            int [] nums = {2,7,11,15};
            int target = 9;
            int [] ans = { 0, 1 };
            Assert.IsTrue(Solution.ArrayCmp(Solution.TwoSum(nums, target),ans), "Wrong Case");
        }
    }
}
