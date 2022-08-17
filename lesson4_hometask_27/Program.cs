Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int r = n;
int sum = 0;
while( r > 0 )
{
    sum += r % 10;
    r /= 10;
}

Console.WriteLine($"Сумма цифр в числе {n} равна {sum}");