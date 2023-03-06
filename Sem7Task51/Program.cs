// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");

// Метод заполнения двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    if (min>max) (min,max)=(max,min);
    Random rnd = new Random();
    int[,] arr = new int[countRow,countColumn];
    for (int i=0; i<countRow; i++)
    {
        for (int j=0; j<countColumn; j++)
        {
            arr[i,j] = rnd.Next(min,max+1);
        }
    } 
    return arr;
}

// Метод подсчета суммы элементов, находящихся на главной диагонали массива
int CountMainDiag(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    
    for(int j=0; j<min; j++)
    {
        res = res + arr[j,j];
    }
    return res;
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
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

int[,] arr2D = Gen2DArr(row,column,10,99);
Print2DArr(arr2D);
PrintData("Сумма элементов массива, находящихся на главной диагонали: " + CountMainDiag(arr2D));
