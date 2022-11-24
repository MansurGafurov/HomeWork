// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое цело число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number);
if(Number <= 99)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
     //int Number3 = Number % 10;   
}
