﻿// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.WriteLine("Введите первое натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n)
{
    Console.WriteLine(count + " ");
    count = count + 1;
}