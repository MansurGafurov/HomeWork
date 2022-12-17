// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] ArrA = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] ArrB = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] ArrC = new int[2, 3];

if (ArrA.GetLength(0) == ArrB.GetLength(0) && ArrA.GetLength(1) == ArrB.GetLength(1))
{
    for (int i = 0; i < ArrC.GetLength(0); i++)
    {
        for (int j = 0; j < ArrC.GetLength(1); j++)
        {
            ArrC[i, j] = ArrA[i, j] * ArrB[i, j];
            Console.Write($" {ArrC[i, j]} \t ");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine($"Произведение матриц не возможно!");









