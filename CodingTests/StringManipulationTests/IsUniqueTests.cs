using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTests
{
    [TestClass]
    public class IsUniqueTests
    {
        [TestMethod]
        public void FalseIsUniqueStringHashSet()
        {
            string s = "barbecue";
            bool res = CodingChallenges.StringManipulation.IsUniqueHashSet(s);
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void TrueIsUniqueStringHashSet()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            bool res = CodingChallenges.StringManipulation.IsUniqueHashSet(s);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void FalseIsUniqueStringArray()
        {
            string s = "barbecue";
            bool res = CodingChallenges.StringManipulation.IsUniqueArray(s);
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void TrueIsUniqueStringArray()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            bool res = CodingChallenges.StringManipulation.IsUniqueArray(s);
            Assert.IsTrue(res);
        }
    }
}
