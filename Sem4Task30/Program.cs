// Задача №30 
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке

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
int[] Gen1DArr()   
{
    int[] arr = new int[8];    // new - выделение памяти
    for (int i=0; i<8; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

Print1DArr(Gen1DArr());
