// Задача №60
// Сформируйте трехмерный массив из неповторяющихся
// двухзначных чисел. напишите программу, которая
// будет построчно выводить массив, добавляя индексы
// каждого элемента

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Метод заполнения трехмерного массива
int[,,] Gen3DArr(int x, int y, int z, int min, int max)
{
    if (min > max) (min, max) = (max, min);

    int[,,] arr3D = new int[x, y, z];
    int[] tempNum = new int[x * y * z];   // Массив неповторяющихся двухзначных чисел, размером количества ячеек трехмерного массива
    int number = 0;
    for (int i = 0; i < tempNum.Length; i++)
    {
        tempNum[i] = new Random().Next(min, max + 1);
        number = tempNum[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempNum[i] == tempNum[j])
                {
                    tempNum[i] = new Random().Next(min, max + 1);
                    j = 0;
                    number = tempNum[i];
                }
                number = tempNum[i];
            }
        }
    }

    int index = 0;
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = tempNum[index];
                index++;
            }
        }
    }
    return arr3D;
}

// Метод вывода на печать трехмерного массива
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Console.Write($"X({i}); Y({j}); ");
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k],1}({i},{j},{k});\t");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}


Console.Clear();

// Принимаем от пользователя значения размера 3D массива
int lineX = ReadData("Введите значение X размера массива: ");
int lineY = ReadData("Введите значение Y размера массива: ");
int lineZ = ReadData("Введите значение Z размера массива: ");
Console.WriteLine();

// Заполняем трехмерный массив случайными целыми неповторяющимися числами и выводим на печать
int[,,] array3D = Gen3DArr(lineX, lineY, lineZ, 10, 98);
Print3DArr(array3D);