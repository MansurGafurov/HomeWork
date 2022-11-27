// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое цело число");
string n = Console.ReadLine();
int i = 0;
if (Convert.ToInt32(n) <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
     char[] array = new char[n.Length];
    
        while(i < n.Length)
        {
            array[i] = n[i];
            i ++;
        }
    Console.WriteLine("Третья цифра = " + array[2]);
}