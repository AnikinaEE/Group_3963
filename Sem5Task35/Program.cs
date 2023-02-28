// Задача №35
// Задайте массив из 123 случайных чисел.
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99]

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

// Метод заполнения массива в случайном порядке заданного диапазона 
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

// Метод подсчета количества элементов, занчения которых лежат на отрезке [10,99]
int NumElemInRange(int[] arr, int minValue, int maxValue)
{
    int result = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if ((arr[i]>minValue)&&(arr[i]<maxValue))
        {
            result++;
        }
    }
    return result;
}

// Метод вывода полученного результата (количество элементов заданного отрезка)
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Заполняем массив из 123 элементов случайными числами
int[] testArray = Gen1DArr(123, 1, 345);

// Выводим заполненный массив
Print1DArr(testArray);

// // Вводим переменную для подсчета количества элементов отрезка [10,99]
// int res = NumElemInRange(testArray, 10, 99);

// // Выводим плученный результат
// PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99], равно: ", res);

PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99], равно: ", NumElemInRange(testArray, 10, 99));
