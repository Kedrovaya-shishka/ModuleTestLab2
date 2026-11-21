namespace MyLibrary
{
    /// <summary>
    /// Задание 1. Метод получает строку и символ и определяет,
    /// сколько раз этот символ входит в эту строку.
    /// </summary>
    public class CharCounter
    {
        public string Text { get; set; } = string.Empty;

        public int Count(char symbol)
        {
            int count = 0;
            foreach (char c in Text)
            {
                if (c == symbol)
                    count++;
            }
            return count;
        }
    }
}
