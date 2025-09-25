// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint1.Task6.V9.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите текст: ");
string str = Console.ReadLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.MoveLetterToStart(str));
Console.ReadKey();
