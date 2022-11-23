Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int I = 1;
while(I <= N)
{
    if((I % 2) == 0)
    {
       Console.Write(I + ", ");
    }
    I ++;
}

