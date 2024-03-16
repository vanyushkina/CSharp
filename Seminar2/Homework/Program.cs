//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}


//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.Write("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.Write("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.Write("Четвртая четверть");
}


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = a % 10;

if (a < 10 || a > 90)
{
    Console.Write("Число выходит за необходимый диапазон");
}
else if (b > c)
{
    Console.Write(b);
}
else if (c > b)
{
    Console.Write(c);
}
else if (c == b)
{
    Console.Write(c);
}


//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите любое натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int i1 = 1;
int i2 = 1;
int l1 = a;
string g = "";

if (b < 10)
{
    Console.Write(b);
}
else if (b > 9)
{
    while (b > 0)
    {
        int d = b % 10;
        b = b / 10;
        g = g + d;
        i1 = i1 + 1;
    }
    int s = Convert.ToInt32(g);
    while (i2 < i1)
    {
        int v = s % 10;
        s = s / 10;
        i2 = i2 + 1;
        l1 = l1 / 10;
        if (l1 > 10)
        {
            Console.Write(v + ", ");
        }
        else
        {
            Console.Write(v);
        }
    }
}