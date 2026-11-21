namespace MyLibrary
{
    /// <summary>
    /// Задание 3. Класс "одномерный массив строк".
    /// Поля: число элементов в массиве, сам массив.
    /// Методы: длина самой длинной строки, длина самой короткой строки,
    /// среднее арифметическое длин строк.
    /// </summary>
    public class StringArrayClass
    {
        public int Count { get; set; }
        public string[] Items { get; set; }

        public StringArrayClass(string[] items)
        {
            Items = items;
            Count = items.Length;
        }

        public int GetMaxLength()
        {
            if (Count == 0) return 0;

            int max = Items[0].Length;
            for (int i = 1; i < Count; i++)
                if (Items[i].Length > max)
                    max = Items[i].Length;

            return max;
        }

        public int GetMinLength()
        {
            if (Count == 0) return 0;

            int min = Items[0].Length;
            for (int i = 1; i < Count; i++)
                if (Items[i].Length < min)
                    min = Items[i].Length;

            return min;
        }

        public double GetAverageLength()
        {
            if (Count == 0) return 0;

            int sum = 0;
            for (int i = 0; i < Count; i++)
                sum += Items[i].Length;

            return (double)sum / Count;
        }
    }
}
