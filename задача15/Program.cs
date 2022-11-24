// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру,обозначающую день недели");
int n = Convert.ToInt32(Console.ReadLine());

int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;

if(n == 6 ||  n == 7)
{
     Console.WriteLine("Ура. Сегодня выходной!");
}    
else if(n>7)
     Console.WriteLine("В неделе только 7 дней!" );
else
     Console.WriteLine("Сегодня рабочий день!");

         
