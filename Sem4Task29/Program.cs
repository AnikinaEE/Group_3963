// Задача №29 
// Напишите программу, которая выводит массив из N
// элементов и выводит их на экран
// *Ввести с клавиатуры длину массива и диапазон значений элементов 


// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int arrLen = ReadData("Введите число N, определяющее длину массива: ");
int numMin = ReadData("Введите минимальное число дипазона значений элементов массива: ");
int numMax = ReadData("Введите максимальное число дипазона значений элементов массива: ");

// Метод вывода массива
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

// Метод заполнения массива в случайном порядке диапазопа (min,max)
int[] Gen1DArr(int len, int min, int max)    // По условию задачи len=8, min=0, max=1
{
    int[] arr = new int[len];    // new - выделение памяти
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
    return arr;
}

Print1DArr(Gen1DArr(arrLen, numMin, numMax));
