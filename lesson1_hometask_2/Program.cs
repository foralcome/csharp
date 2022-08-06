Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.");

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Число1 (" + num1 + ") больше числа2 (" + num2 + ")");
}
if (num1 < num2)
{
    Console.WriteLine("Число1 (" + num1 + ") меньше числа2 (" + num2 + ")");
}
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}