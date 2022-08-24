void PrintTaskText()
{
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
}

int GetDeterminant(int [,]m)
{
    if(m.GetLength(0) != m.GetLength(1)) 
        throw new ArgumentException("Получена не квадратная матрица");
        
    if( m.GetLength(0)==2 )
    {
        return m[0,0] * m[1,1] - m[1,0] * m[0,1];
    }

    throw new ArgumentException($"Матрица размера {m.GetLength(0)} не может быть обработана!");
}
void PrintMatrix(int [,]m)
{
    for(int i=0; i<m.GetLength(1); i++)
    {
        Console.Write("| ");    
        for(int j=0; j<m.GetLength(0); j++)
        {
            Console.Write( $"{m[i, j]} " );
        }
        Console.WriteLine("|");    
    }
}

PrintTaskText();
Console.WriteLine("Введите значения k1, b1 уравнения 1: y = k1 * x + b1");
Console.Write("Введите значения k1:");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значения b1:");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения k2, b2 уравнения 2: y = k2 * x + b2");
Console.Write("Введите значения k2:");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите значения b2:");
int b2 = int.Parse(Console.ReadLine());
Console.Clear();

PrintTaskText();
Console.WriteLine();

Console.WriteLine($"Уравнение 1: y = {k1}x + {b1}");
Console.WriteLine($"Уравнение 2: y = {k2}x + {b2}");
Console.WriteLine();

Console.WriteLine("Шаг 1: Приведение уравнения к виду k * x - y + b = 0");
Console.WriteLine($"Уравнение 1: {k1}x - 1y + {b1} = 0");
Console.WriteLine($"Уравнение 2: {k2}x - 1y + {b2} = 0");
Console.WriteLine();

Console.WriteLine("Шаг 2: Подготовка матрицы определителя D");
int [,]m = new int[2,2];
m[0,0] = k1; m[0,1] = -1;
m[1,0] = k2; m[1,1] = -1;
PrintMatrix(m);

try
{
    int d = GetDeterminant(m);
    Console.WriteLine($"Определитель D равен: {d}");
    Console.WriteLine();

    if( d==0 )
    {
        Console.WriteLine("Прямые уравнений 1 и 2 не пересекаются. Точек пересечения нет!");
    }
    else
    {
        Console.WriteLine("Шаг 3: Подготовка матрицы определителя DX");
        int [,]mx = new int[2,2];
        mx[0,0] = b1 * (-1); mx[0,1] = -1;
        mx[1,0] = b2 * (-1); mx[1,1] = -1;
        PrintMatrix(mx);
        int dx = GetDeterminant(mx);
        Console.WriteLine($"Определитель DX равен: {dx}");
        Console.WriteLine();

        Console.WriteLine("Шаг 4: Находим неизвестную переменную X = DX / D");
        double x = (double)dx / d;
        Console.WriteLine($"X равен: {x}");
        Console.WriteLine();

        Console.WriteLine("Шаг 5: Подготовка матрицы определителя DY");
        int [,]my = new int[2,2];
        my[0,0] = k1; my[0,1] = b1 * (-1);
        my[1,0] = k2; my[1,1] = b2 * (-1);
        PrintMatrix(my);
        int dy = GetDeterminant(my);
        Console.WriteLine($"Определитель DY равен: {dy}");
        Console.WriteLine();

        Console.WriteLine("Шаг 6: Находим неизвестную переменную X = DY / D");
        double y = (double)dy / d;
        Console.WriteLine($"Y равен: {y}");
        Console.WriteLine();

        Console.WriteLine($"Результат: Прямые пересекаются в точке ({x};{y})");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Работа программы прекращена: {ex.Message}!");
}