// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint1.Task7.V11.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("        (lnsinx)^x                                                         ");
Console.WriteLine(" z =    -----------  +  (y-√|x|)                                           ");
Console.WriteLine("         ln(1+x^2)                                                         ");
double x, y;
Console.WriteLine("Введите значение x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(x, y));
Console.ReadKey();

