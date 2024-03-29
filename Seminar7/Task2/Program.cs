//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//Пример:
// 1 2 3 => 6
// 6 3 => 9


int SumOfDigitsNum(int num)
{
    if(num == 0) return 0;
    return num % 10 + SumOfDigitsNum(num / 10);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigitsNum(number));
