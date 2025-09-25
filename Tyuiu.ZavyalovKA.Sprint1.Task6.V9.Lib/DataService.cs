using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZavyalovKA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            string[] words = value.Split(' ');
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    string transformedWord = TransformWord(words[i]);
                    result.Append(transformedWord);
                }
                if (i < words.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        private string TransformWord(string word)
        {
            if (word.Length <= 1)
            {
                return word;
            }
            return word[^1] + word[..^1];
        }
    }
}