// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Задайте размер матрицы");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] Array = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

void FillArray(int[,] Array)
{
    while (num <= size * size)
    {
        Array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
}



void PrintArray(int[,] Array)
{
    for (int x = 0; x < Array.GetLength(0); x++)
    {
        for (int y = 0; y < Array.GetLength(1); y++)
        {

            Console.Write($" {Array[x, y]} \t ");
        }
        Console.WriteLine();
    }
}

FillArray(Array);
PrintArray(Array);