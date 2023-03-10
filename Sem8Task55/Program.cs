// Задача №55 
// Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя

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

// Метод транпонирования матрицы
void TranspArr(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

Console.Clear();

// Принимаем от пользователя значения размера матрицы
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
Console.WriteLine();

// Заполняем матрицу случайными целыми числами и выводим на печать
int[,] array2D = Gen2DArr(row, column, 10, 99);
Print2DArr(array2D);
Console.WriteLine();

// Проверка, возможно ли транспонировать матрицу (транспонирование возможно только квадратной матрицы)
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    // Производим транспонирование матрицы и выводим результат на печать
    TranspArr(array2D);
    Print2DArr(array2D);
}
else Console.WriteLine("Транспонирование заданной матрицы НЕ возможно!");