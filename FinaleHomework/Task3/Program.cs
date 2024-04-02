//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateRndArray(int min = 0, int max = 100)
{
    Random rnd = new Random();
    int size = rnd.Next(5, 11);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }

        else
        {
            {
                Console.Write(array[i]);
            }
        }
    }
    Console.Write("] => ");
}

void ReversArray(int[] array, int length)
{
    if (length == 0) return;
    Console.Write($"{array[length - 1]} ");
    ReversArray(array, length - 1);
}

int[] array = CreateRndArray();
PrintArray(array);

ReversArray(array, array.Length);