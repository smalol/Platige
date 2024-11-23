using System.Text;

namespace Platige.Core.Utilities
{
    public static class RandomHelper
    {
        private static readonly Random Random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            return Random.Next(min, max + 1);
        }

        public static decimal GetRandomDecimal(int min, int max)
        {
            return Random.Next(min, max) + Random.Next(0, 100+ 1) / 100m;
        }

        public static DateTime GetRandomDate(DateTime startDate, DateTime endDate)
        {
            Random random = new Random();

            int range = (endDate - startDate).Days;

            int randomDays = random.Next(range + 1);

            return startDate.AddDays(randomDays);
        }

        public static string GetRandomText(int length)
        {
            if (length <= 0) return string.Empty;

            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var sb = new StringBuilder();
            int currentLength = 0;

            while (currentLength < length)
            {
                int wordLength = Random.Next(1, Math.Max(1, length - currentLength));

                var word = new StringBuilder(wordLength);
                for (int i = 0; i < wordLength; i++)
                {
                    word.Append(chars[Random.Next(chars.Length)]);
                }

                sb.Append(word);
                currentLength += word.Length;

                if (currentLength >= length)
                {
                    break;
                }

                sb.Append(' ');
                currentLength++;
            }

            var text = sb.ToString();
            return string.IsNullOrEmpty(text) ? string.Empty : char.ToUpper(text[0]) + text.Substring(1);
        }

        public static string GetRandomTextWithoutSpace(int length)
        {
            if (length <= 0) return string.Empty;

            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var sb = new StringBuilder();
            int currentLength = 0;

            while (currentLength < length)
            {
                sb.Append(chars[Random.Next(chars.Length)]);
                currentLength++;
            }

            return sb.ToString();
        }

        public static bool GetRandomBoolean()
        {
            return Random.Next(0, 2) == 0;
        }

        public static string GetRandomDigitString(int length)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Random.Next(0, 10));
            }
            return sb.ToString();
        }

        public static string GetRandomListValue(List<string> values)
        {
            if (values == null || values.Count == 0)
            {
                return string.Empty;
            }

            Random random = new Random();
            int index = random.Next(values.Count);
            return values[index];
        }
    }
}
