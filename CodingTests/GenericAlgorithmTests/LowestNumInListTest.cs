using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTests
{
    [TestClass]
    public class LowestNumInListTest
    {
        [TestMethod]
        public void LowestNumInListBasicTest()
        {
            int[] nums = {5,4,10,2,1};
            int res = CodingChallenges.GenericAlgorithmQuestions.findLowestPositiveNumberNotInList(nums);
            Assert.AreEqual(res, 3);
        }
    }
}
