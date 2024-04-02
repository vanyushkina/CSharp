//Задача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

bool CheckNumbers(int m, int n)
{
    if (m > 0 && n > 0) return true;
    Console.WriteLine("Недопустимый ввод");
    return false;
}

void PrintDecreaseNaturalNumbers(int m, int n)
{
    if (m < n) return;
    Console.Write($"{m} ");
    PrintDecreaseNaturalNumbers(m - 1, n);
}

void PrintIncreaseNaturalNumbers(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    PrintIncreaseNaturalNumbers(m + 1, n);
    
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (CheckNumbers(m, n))
{
    
    if (m > n) PrintDecreaseNaturalNumbers(m, n);
    PrintIncreaseNaturalNumbers(m, n);
}
