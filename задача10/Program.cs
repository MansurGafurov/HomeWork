// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (number);

//int A = number / 100;
//Console.WriteLine(A);
// так мы нашли первое значение в трехзначном числе!

//int C = number % 10;
//Console.WriteLine(C);
// так нашли третье значение в трехзначном числе!
// ЭТО ДЛЯ СЕБЯ.



int B = ((number/10) % 10);
// or int B = ((number%100) / 10);
Console.WriteLine(B);



