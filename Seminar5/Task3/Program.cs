//Задайте двумерный массив из целыхх чисел.
//Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.
// Пример:
//2 3 4 3 
//4 3 4 1   => [3 3 5]
//2 9 5 4 


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        //Console.WriteLine("]");
        Console.WriteLine();
    }
}

double[] ArraySumAverage(int[,] matrix)
{
    double[] ArrayResult = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow = SumRow + matrix[i, j];
        }
        ArrayResult[i] = (double) SumRow / matrix.GetLength(1);
    }
}
return ArrayResult;

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
double[] array = ArraySumAverage(matr);
PrintArray(array);