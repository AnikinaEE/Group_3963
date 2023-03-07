// Задача №52
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов
// в каждом столбце

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

// Метод расчета среднего арифметического элементов в каждом столбце заданного массива
double[] ArithmeticMean(int[,] arr)
{
    double[] outArr = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            outArr[j] = outArr[j] + arr[i, j];
        }
        outArr[j] = Math.Round(outArr[j]/arr.GetLength(0),2);
    }
    return outArr;
}

// Метод вывода массива
void Print1DArr(double[] arr)
{
    // Console.Write("[");
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.Write(arr[arr.Length-1]);
    // Console.WriteLine("]");
}

// Принимаем от пользователя значения размера матрицы
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
Console.WriteLine();

// Заполняем матрицу случайными целыми числами и выводим на печать
int[,] array2D = Gen2DArr(row, column, 10, 99);
Print2DArr(array2D);
Console.WriteLine();

// Получаем массив средне арифметических значений столбцов матрицы и выводим значения под каждым столбцом
double[] resArr = ArithmeticMean(array2D);
Print1DArr(resArr);
