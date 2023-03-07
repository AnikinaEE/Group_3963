// Задача №50
// Напишите прграмму, которая на вход принимает 
// позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же
// указание, что такого элемента нет
// * Заполните двумерный массив числами Фибоначчи

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
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
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

// Метод поиска заданного значения элемента
int SearchElem(int[,] arr, int elem)
{
    int result = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == elem)
            {
                result = j;
                break;
            }
        }
    }
    return result;
}

// *Метод заполнения массива числами Фибоначчи (для небольшой матрицы, в противном случе, необходимо поменять тип данных)
int[,] FibonacciGen2DArr(int countRow, int countColumn)
{
    int[,] arr = new int[countRow, countColumn];
    int first = 0;
    int last = 1;

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = first;
            first = last;
            last = arr[i,j]+first;
        }
    }
    return arr;
}

// Принимаем от пользователя значения размера матрицы
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");

// Заполняем матрицу случайными целыми числами и выводим на печать
int[,] array2D = Gen2DArr(row, column, 10, 99);
Print2DArr(array2D);

// Принимаем от пользователя искомое значение элемента
int num = ReadData("Введите искомое значение элемента массива: ");

// Вывод результата поиска заданного элемента
if (SearchElem(array2D, num) >= 0)
{
    Console.WriteLine($"Искомый элемент найден и находится в {SearchElem(array2D, num) + 1} столбце массива");
}
else
{
    Console.WriteLine("Искомый элемент в массиве отсутствует");
}

Console.WriteLine();

// *Заполняем матрицу числами Фибоначчи и выводим на печать
int[,] arrayFibonacci = FibonacciGen2DArr(row, column);
Print2DArr(arrayFibonacci);