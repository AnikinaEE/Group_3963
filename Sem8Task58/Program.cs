// Задача №58
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

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

int[,] MultiplyMatrix(int[,] matrFirst, int[,] matrSecond)
{
    int[,] outputMatr = new int[matrFirst.GetLength(0), matrSecond.GetLength(1)];
    for (int i = 0; i < outputMatr.GetLength(0); i++)
    {
        for (int j = 0; j < outputMatr.GetLength(1); j++)
        {
            outputMatr[i, j] = 0;
            for (int z = 0; z < matrFirst.GetLength(1); z++)
            {
                outputMatr[i, j] += matrFirst[i, z] * matrSecond[z, j];
            }
        }
    }
    return outputMatr;
}


Console.Clear();

// Принимаем от пользователя значения размеров матриц
int row1 = ReadData("Введите количество строк первого массива: ");
int column1 = ReadData("Введите количество столбцов первого массива: ");
Console.WriteLine();
int row2 = ReadData("Введите количество строк второго массива: ");
int column2 = ReadData("Введите количество столбцов второго массива: ");
Console.WriteLine();

// Заполняем матрицы случайными целыми числами и выводим на печать
int[,] array2DFirst = Gen2DArr(row1, column1, 1, 15);
Print2DArr(array2DFirst);
Console.WriteLine();
int[,] array2DSecond = Gen2DArr(row2, column2, 1, 9);
Print2DArr(array2DSecond);
Console.WriteLine();

// Проверка, возможно ли перемножить заданные матрицы (количество столбцов в первой матрице должно быть равно количеству строк во второй матрице)
if (array2DFirst.GetLength(1) == array2DSecond.GetLength(0))
{
    // Производим перемножение заданных матриц и выводим результат на печать
    int[,] multiplyArray = MultiplyMatrix(array2DFirst, array2DSecond);
    Print2DArr(multiplyArray);
}
else Console.WriteLine("Перемножение заданных матриц НЕ возможно!");