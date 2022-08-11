Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите цифру дня недели (от 1 до 7): ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek < 1 || dayWeek > 7)
{
    Console.WriteLine("Введён неверный номер дня недели!");
}
else
{
    if (dayWeek <= 5)
    {
        int daysToEndWeek = 7 - dayWeek - 1;
        string endDayText = "дней";
        if (daysToEndWeek < 5)
            endDayText = "дня";
        if (daysToEndWeek == 1)
            endDayText = "день";
        Console.WriteLine("Работаем! До выходных " + daysToEndWeek + " " + endDayText);
    }
    else
    {
        Console.WriteLine("Ура! Выходной!");
    }
}

