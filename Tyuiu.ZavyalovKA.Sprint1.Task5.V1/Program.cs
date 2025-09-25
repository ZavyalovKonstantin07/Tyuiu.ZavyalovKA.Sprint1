// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint1.Task5.V1.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
Console.WriteLine(res);
Console.ReadKey();

