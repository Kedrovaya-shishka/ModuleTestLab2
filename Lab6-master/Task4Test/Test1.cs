using MyLibrary;

namespace Task4Test
{
    /// <summary>
    /// Тестовые данные для проверки разбиения строки на слова (ToWordsArray)
    ///
    /// №  | Резюме теста                         | Строка              | Ожидаемый результат          | Вид теста
    /// 1  | Несколько пробелов между словами     | "hello world  foo"  | {"hello","world","foo"}      | позитивный
    /// 2  | Строка из одних пробелов             | "   "                | {}                            | негативный
    /// 3  | Одно слово без пробелов              | "single"             | {"single"}                    | позитивный
    /// 4  | Пустая строка                         | ""                   | {}                            | негативный
    ///
    /// Тестовые данные для проверки выборки слов по регулярному выражению (GetWordsByRegex)
    ///
    /// №  | Резюме теста                         | Строка, шаблон               | Ожидаемый результат | Вид теста
    /// 1  | Слова, начинающиеся на "c"           | "cat dog cow bird", "^c"      | {"cat","cow"}        | позитивный
    /// 2  | Слова, состоящие только из цифр      | "123 abc 456 def", @"^\d+$"  | {"123","456"}        | позитивный
    /// 3  | Совпадений нет                        | "apple banana cherry", "^z"   | {}                    | негативный
    /// </summary>
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1_MultipleSpaces()
        {
            MyStringClass s = new MyStringClass("hello world  foo");
            CollectionAssert.AreEqual(new[] { "hello", "world", "foo" }, s.ToWordsArray());
        }

        [TestMethod]
        public void TestMethod2_OnlySpaces()
        {
            MyStringClass s = new MyStringClass("   ");
            CollectionAssert.AreEqual(Array.Empty<string>(), s.ToWordsArray());
        }

        [TestMethod]
        public void TestMethod3_SingleWord()
        {
            MyStringClass s = new MyStringClass("single");
            CollectionAssert.AreEqual(new[] { "single" }, s.ToWordsArray());
        }

        [TestMethod]
        public void TestMethod4_EmptyString()
        {
            MyStringClass s = new MyStringClass("");
            CollectionAssert.AreEqual(Array.Empty<string>(), s.ToWordsArray());
        }

        [TestMethod]
        public void TestMethod5_WordsStartingWithC()
        {
            MyStringClass s = new MyStringClass("cat dog cow bird");
            CollectionAssert.AreEqual(new List<string> { "cat", "cow" }, s.GetWordsByRegex("^c"));
        }

        [TestMethod]
        public void TestMethod6_WordsAllDigits()
        {
            MyStringClass s = new MyStringClass("123 abc 456 def");
            CollectionAssert.AreEqual(new List<string> { "123", "456" }, s.GetWordsByRegex(@"^\d+$"));
        }

        [TestMethod]
        public void TestMethod7_NoMatches()
        {
            MyStringClass s = new MyStringClass("apple banana cherry");
            CollectionAssert.AreEqual(new List<string>(), s.GetWordsByRegex("^z"));
        }
    }
}
