// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint1.Task2.V4.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Завьялов Константин Андреевич | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифмитические операторы в C#                                     *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Завьялов Константин Андреевич | РППб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int x;
Console.WriteLine("Длина стороны квадрата: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Площадь квадрата = " + ds.CalculateSquare(x));
Console.ReadLine();

