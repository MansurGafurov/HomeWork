// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Обозначте размер массива!");
int [] Array = new int [Convert.ToInt32(Console.ReadLine())];
int difference = 0;
for(int i = 0; i < Array.Length; i++) {
    Array[i] = new Random(). Next(1,99);
    Console.WriteLine(Array[i]);
}

int min = Array[0];
int max = Array[0];
foreach (int index  in Array)  
{
    if (min > index) min = index;
    if (max < index) max = index;
}   
difference = max - min;
Console.WriteLine("Максимальный элемент = " + max);
Console.WriteLine("Минимальный  элемент = " + min);
Console.WriteLine("Разницу между максимальным и минимальным элементом массива = " + difference);

