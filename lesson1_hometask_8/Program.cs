Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for( int a = 2; a<num; a = a + 2)
{
    if( a!= 2 )
        Console.Write(", ");
    Console.Write(a);
}
Console.WriteLine();


