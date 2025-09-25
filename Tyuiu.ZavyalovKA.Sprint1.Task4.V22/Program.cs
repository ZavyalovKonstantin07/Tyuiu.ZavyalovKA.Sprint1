using Tyuiu.ZavyalovKA.Sprint1.Task4.V22.Lib;
class Program
{
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("Введите значение x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("√xy / 1 + (х + 2 * y) ^ 2 = " + ds.Calculate(x, y));
        Console.ReadKey();
    }
}

              