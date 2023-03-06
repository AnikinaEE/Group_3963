// Задача №45 
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования

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

// Метод поэлементного копирования массива 
int[] CopyArrStandart(int[] inputArr)
{
    int[] outArr = new int[inputArr.Length];
    inputArr.CopyTo(outArr, 0);    // 0 - указывает, с какого элемента необходимо произвести копирование
    return outArr;
}

int[] testArr = Gen1DArr(40, 1, 50);
Print1DArr(testArr);
int[] testArrNew = CopyArrStandart(testArr);
Print1DArr(testArrNew);
