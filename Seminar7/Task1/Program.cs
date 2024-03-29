﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//Пример:
//N = 5 => 1 2 3 4 5 


void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(number);
