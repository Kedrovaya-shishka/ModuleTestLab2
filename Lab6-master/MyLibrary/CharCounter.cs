namespace MyLibrary
{

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
