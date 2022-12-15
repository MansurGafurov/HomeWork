// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите резмер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine();

List<int> SumStrings = new List<int>();

// int ReturnList(List<int> SumStrings)
// {
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    SumStrings.Add(sum);
}
// return List<int> SumStrings; 
//     return SumStrings.Add(sum);
// }

// ReturnList(SumStrings);
Console.WriteLine();

int ReturnIndex(List<int> SumStrings)
{
    int MaxIDX = 0;
    int Max = 0;

    for (int i = 0; i < SumStrings.Count; i++)
    {
        if (SumStrings[i] > Max)
        {
            Max = SumStrings[i];
            MaxIDX = i;
        }
    }
    return MaxIDX;
}
Console.WriteLine();
Console.WriteLine($" Строка с наибольшей суммой элементов: {ReturnIndex(SumStrings) + 1}");


