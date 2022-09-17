Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");

string[] LoadMenu()
{
    string[] menu = new string[3];
    menu[0] = "Выход";
    menu[1] = "Автоматическое тестирование";
    menu[2] = "Ручное тестирование";
    return menu;
}
void PrintMenu(string[] menu)
{
    Console.WriteLine();
    Console.WriteLine("----- MENU ----------------------------");
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i}) " + menu[i]);
    }
}
int GetSelectMenu(string[] menu)
{
    PrintMenu(menu);
    int selectMenu = 1;
    while (true)
    {
        Console.Write("Выберите пункт меню: ");
        selectMenu = int.Parse(Console.ReadLine());
        if (selectMenu < 0 || selectMenu > menu.Length)
        {
            continue;
        }
        Console.WriteLine();
        return selectMenu;
    }
}
string GetRandomString(int maxCountChars = 10)
{
    if (maxCountChars <= 0)
    {
        throw new ArgumentException("Длиина строки должна быть больше 0!");
    }

    const string arrayChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    string currentString = "";
    int indexChar = 0;
    int countChars = 0;
    while (countChars < maxCountChars)
    {
        indexChar = new Random().Next(0, arrayChars.Length - 1);

        currentString += arrayChars[indexChar];
        countChars++;
    }
    return currentString;
}

string[] FillArrayRandom(int sizeArray = 10, int maxLenghtString = 10)
{
    if (sizeArray <= 0)
    {
        throw new ArgumentException("Размер массива должен быть больше 0!");
    }
    if (maxLenghtString <= 0)
    {
        throw new ArgumentException("Максимальная длиина строки должна быть больше 0!");
    }

    string[] arrayString = new string[sizeArray];
    for (int i = 0, sizeString = 0; i < sizeArray; i++)
    {
        sizeString = new Random().Next(1, maxLenghtString);
        arrayString[i] = GetRandomString(sizeString);
    }

    return arrayString;
}

string[] FillArrayManual(int sizeArray = 10)
{
    if (sizeArray <= 0)
    {
        throw new ArgumentException("Размер массива должен быть больше 0!");
    }

    string[] arrayString = new string[sizeArray];
    for (int i = 0, sizeString = 0; i < sizeArray; i++)
    {
        Console.Write($"Введите строку {(i + 1)}: ");
        arrayString[i] = Console.ReadLine();
    }

    return arrayString;
}

string[] GetStringsInArrayByMaxLenght(string[] array, int maxLength = 3)
{
    int sizeFinalArray = 0;
    int sizeArray = array.Length;
    string[] tmpArray = new string[sizeArray];
    for (int index = 0, tmpIndex = 0; index < sizeArray; index++)
    {
        if (array[index].Length <= maxLength)
        {
            tmpArray[tmpIndex] = array[index];
            tmpIndex++;
            sizeFinalArray++;
        }
    }

    string[] finalArray = new string[sizeFinalArray];
    for (int index = 0; index < sizeFinalArray; index++)
    {
        finalArray[index] = tmpArray[index];
    }

    return finalArray;
}

void PrintArrayString(string[] arrayString)
{
    Console.WriteLine("----- МАССИВ -------------------------");
    if (arrayString.Length == 0)
    {
        Console.WriteLine("массив пуст");
    }
    for (int i = 0; i < arrayString.Length; i++)
    {
        Console.WriteLine($"{(i + 1)}) " + arrayString[i]);
    }
}

void RunAutoTest()
{
    Console.WriteLine("----- 1) AUTO ТЕСТИРОВАНИЕ -----------");

    Console.WriteLine("----- ЗАПОЛНЕНИЕ МАССИВА --------------");
    int sizeArrayString = 10;
    string[] array = FillArrayRandom(sizeArrayString, 10);
    PrintArrayString(array);

    Console.WriteLine("----- ПОИСК СТРОК ---------------------");
    int maxLengthString = 3;
    Console.Write($"Максимальная длина строки: {maxLengthString}");
    Console.WriteLine();
    string[] findArray = GetStringsInArrayByMaxLenght(array, maxLengthString);
    PrintArrayString(findArray);
}

void RunManualTest()
{
    Console.WriteLine("----- 2) РУЧНОЕ ТЕСТИРОВАНИЕ ----------");
    Console.WriteLine("----- ЗАПОЛНЕНИЕ МАССИВА --------------");
    Console.Write("Укажите размер массива строк: ");
    int sizeArrayString = int.Parse(Console.ReadLine());
    if (sizeArrayString <= 0)
    {
        Console.WriteLine("Размер массива должен быть больше 0!");
        return;
    }
    string[] array = FillArrayManual(sizeArrayString);
    PrintArrayString(array);

    Console.WriteLine("----- ПОИСК СТРОК ---------------------");
    Console.Write("Максимальная длина строки: ");
    int maxLengthString = int.Parse(Console.ReadLine());
    if (maxLengthString <= 0)
    {
        Console.WriteLine("Длина строки должна быть больше 0!");
        return;
    }
    else
    {
        string[] findArray = GetStringsInArrayByMaxLenght(array, maxLengthString);
        PrintArrayString(findArray);
    }
}

try
{
    string[] menu = LoadMenu();
    int selectMenu = GetSelectMenu(menu);
    while (selectMenu != 0)
    {
        switch (selectMenu)
        {
            case 1:
                RunAutoTest();
                break;
            case 2:
                RunManualTest();
                break;
            default:
                Console.WriteLine("Неизвестная операция!");
                break;
        }
        selectMenu = GetSelectMenu(menu);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
