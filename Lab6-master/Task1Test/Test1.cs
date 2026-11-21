using MyLibrary;

namespace Task1Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1_SeveralOccurrences()
        {
            CharCounter cc = new CharCounter();
            cc.Text = "hello world";
            Assert.AreEqual(2, cc.Count('o'));
        }

        [TestMethod]
        public void TestMethod2_SymbolNotFound()
        {
            CharCounter cc = new CharCounter();
            cc.Text = "hello";
            Assert.AreEqual(0, cc.Count('z'));
        }

        [TestMethod]
        public void TestMethod3_EmptyString()
        {
            CharCounter cc = new CharCounter();
            cc.Text = "";
            Assert.AreEqual(0, cc.Count('a'));
        }

        [TestMethod]
        public void TestMethod4_AllCharsMatch()
        {
            CharCounter cc = new CharCounter();
            cc.Text = "aaaa";
            Assert.AreEqual(4, cc.Count('a'));
        }

        [TestMethod]
        public void TestMethod5_CaseMismatch()
        {
            CharCounter cc = new CharCounter();
            cc.Text = "Hello";
            Assert.AreEqual(0, cc.Count('h'));
        }
    }
}
