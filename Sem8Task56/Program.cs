// Задача №56
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Метод заполнения двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    if (min > max) (min, max) = (max, min);

    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

// Метод вывода на печать двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Метод подсчета суммы строк заданного массива
int MinRowCount(int[,] arr)
{
    int index = -1;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    return index;
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

Console.Clear();

// Принимаем от пользователя значения размера матрицы
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива отличное от количества строк: ");
Console.WriteLine();

// Осуществляем проверку, чтобы заданная матрица была прямоугольной
if (row != column)
{
    // Заполняем матрицу случайными целыми числами и выводим на печать
    int[,] array2D = Gen2DArr(row, column, 10, 99);
    Print2DArr(array2D);
    Console.WriteLine();

    // Находим минимальную сумму строки и выводим индекс определенной строки
    PrintData("Строка с наименьшей суммой элементов: " + MinRowCount(array2D));
}
else Console.WriteLine("Введен неверный размер матрицы, повторите попытку ввода");