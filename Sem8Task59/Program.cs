// Задача №59
// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива

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

// Метод поиска минимального элемента массива и его индексов
(int x, int y) SearchMinElemIn2DArr(int[,] arr)
{
    int row = 0; int col = 0;
    int min = int.MaxValue;
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i,j];
                row = i;
                col = j;
            }
        }
    }
    return (row,col);
}

// Метод удаления строки и столбца, на пересечении котрых лежит min
int[,] Update2DArr(int[,] arr, int row, int col)
{
    int[,] result = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int k=0; int m=0;
    for (int i=0; i<arr.GetLength(0); i++)
    {
        m=0;
        for (int j=0; j<arr.GetLength(1); j++)
        {
            if (i != row && j !=col)
            {
                result[k,m]=arr[i,j];
            }
            if (j !=col) m++;
        }
        if (i != row) k++;
    }
    return result;
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

// Находим минимальный элемент в массиве печатаем новый массив, исключая строку и столбец, на пересечении которых лежит min
(int indexRow, int indexCol) minElem = SearchMinElemIn2DArr(array2D);
Console.WriteLine("Минимальный эдемент массива: " +array2D[minElem.indexRow,minElem.indexCol]);
Console.WriteLine();

// Определяем новый массив и выводим его на печать
int[,] out2DArr = Update2DArr(array2D, minElem.indexRow, minElem.indexCol);
Print2DArr(out2DArr);