using MyLibrary;

namespace Task3Test
{
    /// <summary>
    /// Тестовые данные для проверки класса "одномерный массив строк"
    ///
    /// №  | Резюме теста                          | Массив строк                | Ожидаемый результат (max/min/avg) | Вид теста
    /// 1  | Разные длины строк                    | {"a", "bb", "ccc"}          | 3 / 1 / 2                          | позитивный
    /// 2  | Все строки одинаковой длины           | {"hello", "world"}          | 5 / 5 / 5                          | позитивный
    /// 3  | Пустой массив                          | {}                           | 0 / 0 / 0                          | негативный
    /// 4  | Смешанные длины, повтор длины          | {"a", "abc", "ab"}          | 3 / 1 / 2                          | позитивный
    /// </summary>
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
