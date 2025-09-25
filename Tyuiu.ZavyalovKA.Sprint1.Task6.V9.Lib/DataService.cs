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
            return value[^1] + value[..^1];
        }
    }
}