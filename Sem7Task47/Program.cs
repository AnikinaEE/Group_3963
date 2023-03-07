// Задача №47
// Задайте двумерный массив размером mxn,
// заполненный случайными вещественными числами

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Метод заполнения двумерного массива случайными вещественными числами
double[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    if (min > max) (min, max) = (max, min);

    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1) + new Random().NextDouble();    // Заполнение вещественными числами
            arr[i, j] = Math.Round(arr[i, j], 4);     // Округление до четырех знаков после запятой
        }
    }
    return arr;
}

// Метод вывода на печать двумерного массива
void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                             ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                             ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                             ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                             ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                             ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];     // Присваивание цвета элементу в случайном порядке
            Console.Write(arr[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
double[,] array2D = Gen2DArr(row, column, 10, 99);
Print2DArr(array2D);
