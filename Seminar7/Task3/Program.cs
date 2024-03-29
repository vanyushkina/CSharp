//Считать стоку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
//Пример:
//"hello" => h l l
//"world" => w r l d
//"Hello world!" => H l l w r l d


void PrintOnlyConsonans(string line)
{
    if(line.Length == 0) return;
    string chars = "aeiouy";
        if(char.IsAsciiLetter(line[0]) && !chars.Contains(line[0]))
            Console.Write($"{line[0]}");
        PrintOnlyConsonans(line.Substring(1));
}


Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
PrintOnlyConsonans(str);