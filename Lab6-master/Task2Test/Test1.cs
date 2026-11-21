using MyLibrary;

namespace Task2Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1_ExactSum()
        {
            PercentChecker pc = new PercentChecker();
            pc.Percents = new double[] { 50, 50 };
            Assert.IsTrue(pc.CheckSum(0.01));
        }

        [TestMethod]
        public void TestMethod2_BoundaryWithinPrecision()
        {
            PercentChecker pc = new PercentChecker();
            pc.Percents = new double[] { 30, 30, 39 };
            Assert.IsTrue(pc.CheckSum(1));
        }

        [TestMethod]
        public void TestMethod3_OutsidePrecision()
        {
            PercentChecker pc = new PercentChecker();
            pc.Percents = new double[] { 30, 30, 30 };
            Assert.IsFalse(pc.CheckSum(1));
        }

        [TestMethod]
        public void TestMethod4_EmptyArray()
        {
            PercentChecker pc = new PercentChecker();
            pc.Percents = new double[] { };
            Assert.IsFalse(pc.CheckSum(1));
        }

        [TestMethod]
        public void TestMethod5_RoundingWithinPrecision()
        {
            PercentChecker pc = new PercentChecker();
            pc.Percents = new double[] { 99.99, 0.02 };
            Assert.IsTrue(pc.CheckSum(0.01));
        }
    }
}
