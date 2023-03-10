// Задача №57
// Составить частотный словарь элементов двумерного массива.
// Ччастотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных

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

// Метод составления частотного словаря
int[] FregDicBuild(int[,] arr, int len)
{
    int[] dic = new int[len];     
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            dic[arr[i,j]]++;
        }
    }
    return dic;
}

// Метод вывода на печать одномерного массива (dic)
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

Console.Clear();

// Принимаем от пользователя значения размера матрицы
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
Console.WriteLine();

// Заполняем матрицу случайными целыми числами и выводим на печать
int[,] array2D = Gen2DArr(row, column, 0, 9);
Print2DArr(array2D);
Console.WriteLine();

// Составляем частотный словарь и выводим его на печать
int[] dictionary = FregDicBuild(array2D, 10);
Print1DArr(dictionary);