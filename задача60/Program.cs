// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задайте размер трехмерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());
int[,,] Array = new int[m, n, r];
Console.WriteLine();

int count = 10; 
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int k = 0; k < Array.GetLength(2); k++)
        {
            Array[i, j, k] = count;
            Console.WriteLine($"In Array [{i}, {j}, {k}] the number is stored {Array[i, j, k]} ");
            count++;
        }
    }
}
