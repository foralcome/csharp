Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

int Degree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if(b <= 0){
    Console.WriteLine("Число B должно быть больше 0!");
}
else
{
    int result = Degree(a,b);
    Console.WriteLine($"Результат: {result}");
}