Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введите число: ");
string numStr = Console.ReadLine();
int numLen = numStr.Length;

Console.Write("Какую по порядку цифру числа надо найти?: ");
int numFind = Convert.ToInt32(Console.ReadLine());
if (numFind == 0)
{
    numFind = 3;
}
Console.WriteLine("Ищем " + numFind + " цифру");

if (numLen < numFind)
{
    Console.WriteLine(numFind + "-й цифры в числе " + numStr + " нет");
}
else
{
    int num = Convert.ToInt32(numStr);

    int numPow = 1;
    for (int pow = 1; pow <= numLen - (numFind - 1); pow++)
        numPow *= 10;

    int numN = (num % (numPow)) / (numPow / 10);
    Console.WriteLine("Искомая цифра: " + numN);
}

