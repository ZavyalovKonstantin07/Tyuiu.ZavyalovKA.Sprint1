// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint1.Task3.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double versts = 100; 
        Console.WriteLine("Расстояние в вёрстах = " + versts);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double kilometers = ds.VerstsToKilometers(versts);
        Console.WriteLine("Расстояние в км = " + kilometers);

        Console.ReadKey();
    }
}
