/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine ("Input first number: ");

int a = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Input second number: ");

int b = Convert.ToInt32 (Console.ReadLine ());


if (a>b)
{
Console.WriteLine ($"{a} is bigger than {b} ");



}

else
{

Console.WriteLine ($"{b} is bigger than {a} ");


}
