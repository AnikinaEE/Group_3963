// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ = m+n 
// Выведите полученный массив на экран

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");

// Метод заполнения двумерного массива
int[,] Gen2DArr(int countRow, int countColumn)
{    
    int[,] resArr = new int[countRow,countColumn];
    for (int i=0; i<countRow; i++)
    {
        for (int j=0; j<countColumn; j++)
        {
            resArr[i,j] = i+j;
        }
    } 
    return resArr;
}

// Метод вывода на печать двумерного массива
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                             ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                             ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                             ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                             ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                             ConsoleColor.Yellow};

    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arr2D = Gen2DArr(row,column);
Print2DArr(arr2D);

