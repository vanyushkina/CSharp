//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}

Console.Write("Введите число n, больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m, больше 0: ");
int m = Convert.ToInt32(Console.ReadLine());

int resulatAckermann = Ackermann(n, m);
Console.WriteLine($"A(n, m) = A({n}, {m}) = {resulatAckermann}");
