//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите два числа");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if(m>n) {(m,n)=(n,m);}

int Sum(int x, int y)
{
    if(x>y) { return 0;}
    int result  = Sum(x+1, y);
    return x + result;
}
Console.WriteLine(Sum(m,n));