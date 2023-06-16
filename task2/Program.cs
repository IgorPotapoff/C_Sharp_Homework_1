/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


*/

using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine ("Input first number: ");

int a = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Input second number: ");

int b = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Input third number: ");

int c = Convert.ToInt32 (Console.ReadLine ());


    if ( a> b && a>c)

    Console.WriteLine ($"{a} - максимальное число из трёх");

    else if (b > c)

    Console.WriteLine ($"{b} - максимальное число из трёх");

    else 

    Console.WriteLine ($"{c} - максимальное число из трёх");


