// Задача №39
// Напишите программу, которая перевернет
// одномерный массив (последний элемент будет
// на первом месте, а первый - на последнем и т.д.)

// Метод заполнения массива случайными вещественными числами
int[] Gen1DArr(int len, int min, int max)   
{
    // Проверяем и корректируем входные данные (чтобы min не был больше max)
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[] arr = new int[len];    // new - выделение памяти
    for (int i=0; i<len; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

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

// Метод переворота массива (числа меняются местами в исходном массиве)
void SwapArray(int[] arr)
{
    int bufElem = 0;
    for (int i=0; i<arr.Length/2; i++)
    {
        bufElem = arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=bufElem;
    }
}

// Метод переворота массива (создание нового массива, куда записываются элементы исходного в обратном порядке)
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i=0; i<outArr.Length; i++)
    {
        outArr[i]=arr[arr.Length-1-i];
    }
    return outArr;
}

int[] testArray = Gen1DArr(33,10,100);
Print1DArr(testArray);
int[] newArray = SwapNewArray(testArray);
SwapArray(testArray);
Print1DArr(testArray);
Console.WriteLine();
Print1DArr(newArray);

