using MyLibrary;

namespace Task3Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1_DifferentLengths()
        {
            StringArrayClass arr = new StringArrayClass(new[] { "a", "bb", "ccc" });
            Assert.AreEqual(3, arr.GetMaxLength());
            Assert.AreEqual(1, arr.GetMinLength());
            Assert.AreEqual(2, arr.GetAverageLength());
        }

        [TestMethod]
        public void TestMethod2_EqualLengths()
        {
            StringArrayClass arr = new StringArrayClass(new[] { "hello", "world" });
            Assert.AreEqual(5, arr.GetMaxLength());
            Assert.AreEqual(5, arr.GetMinLength());
            Assert.AreEqual(5, arr.GetAverageLength());
        }

        [TestMethod]
        public void TestMethod3_EmptyArray()
        {
            StringArrayClass arr = new StringArrayClass(new string[] { });
            Assert.AreEqual(0, arr.GetMaxLength());
            Assert.AreEqual(0, arr.GetMinLength());
            Assert.AreEqual(0, arr.GetAverageLength());
        }

        [TestMethod]
        public void TestMethod4_MixedLengths()
        {
            StringArrayClass arr = new StringArrayClass(new[] { "a", "abc", "ab" });
            Assert.AreEqual(3, arr.GetMaxLength());
            Assert.AreEqual(1, arr.GetMinLength());
            Assert.AreEqual(2, arr.GetAverageLength());
        }
    }
}
