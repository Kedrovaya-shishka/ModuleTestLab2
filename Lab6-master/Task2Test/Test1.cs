using MyLibrary;

namespace Task2Test
{
    /// <summary>
    /// Тестовые данные для проверки суммы процентов
    ///
    /// №  | Резюме теста                                  | Массив, точность        | Ожидаемый результат | Вид теста
    /// 1  | Сумма точно равна 100                         | {50, 50}, 0.01          | true                 | позитивный
    /// 2  | Сумма отличается от 100 ровно на точность     | {30, 30, 39}, 1         | true                 | позитивный
    /// 3  | Сумма отличается от 100 больше, чем точность  | {30, 30, 30}, 1         | false                | негативный
    /// 4  | Пустой массив (сумма равна 0)                 | {}, 1                   | false                | негативный
    /// 5  | Сумма 100 с погрешностью округления            | {99.99, 0.02}, 0.01     | true                 | позитивный
    /// </summary>
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
