// На основе символов строки (тип string) сформир массив символов (тип char[]). Вывести массив на экран.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// static char[] StringToCharsArray(string str)
// {
//     char[] array = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         array[i] = str[i];
//     }

//     return array;
// }

// Console.WriteLine(StringToCharsArray("Hello!"));

char[] StringToCarsArray(string str)
{
    char[] arr = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
        arr[i] = str[i];
    return arr;
}
void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"'{array[i]}', ");
        }
        else
        {
            Console.Write($"'{array[i]}' ");
        }

    }
    Console.WriteLine("]");
}

string str = "Hello!";

PrintArray(StringToCarsArray(str));