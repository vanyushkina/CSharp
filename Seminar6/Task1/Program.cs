//Задайте массив символов (тип char[]). Создайте строку из символов этого массива.
//Пример
//[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


static string ArrayCharsToString(char[] chars, string str)
{
    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i]; // str = str + chars[i]
    }

    return str;
}

char[] chars = {'a', 'b', 'c', 'd'};
string str = string.Empty;

str = ArrayCharsToString(chars, str);
Console.WriteLine(str);

