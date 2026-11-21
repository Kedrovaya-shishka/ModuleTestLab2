using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class MyStringClass
    {
        public string Value { get; set; }

        public MyStringClass(string value)
        {
            Value = value;
        }

        public string[] ToWordsArray()
        {
            string trimmed = Value.Trim();
            if (trimmed.Length == 0)
                return Array.Empty<string>();

            return Regex.Split(trimmed, @"\s+");
        }

        public List<string> GetWordsByRegex(string pattern)
        {
            List<string> result = new List<string>();
            Regex regex = new Regex(pattern);

            foreach (string word in ToWordsArray())
            {
                if (regex.IsMatch(word))
                    result.Add(word);
            }

            return result;
        }
    }
}
