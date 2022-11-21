Console.WriteLine("Введите три числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if(A>B && A>C)
{
    Console.WriteLine( "Max =" +A );
}
else if(B>A && B>C)
{
    Console.WriteLine( "Max =" +B );
}
else 
{
    Console.WriteLine ("Max =" +C);
}


