// Задача№38
// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементом массива
// Отсортируйте массив методом вставки

// Метод заполнения массива случайными вещественными числами
double[] Gen1DArr(int len, int min, int max)   
{
    // Проверяем и корректируем входные данные (чтобы min не был больше max)
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    double[] arr = new double[len];    // new - выделение памяти
    for (int i=0; i<len; i++)
    {
        arr[i] = new Random().Next(min,max+1) + new Random().NextDouble();
    }
    return arr;
}
// Метод вывода массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

// Метод вывода полученного результата (разница между максимальным и минимальным элементом)
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

// Метод расчета разницы между максимальным и минимальным элементом массива
double MaxMin(double[] arr)
{
    double minNum = double.MaxValue;
    double maxNum = double.MinValue;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
        if (arr[i] < minNum) minNum = arr[i];
    }
    return (maxNum-minNum);
}

void InsertSort(double[] arr)
{
    for (int i=1; i<arr.Length; i++)
    {
        double var = arr[i];
        int j = i-1;

        while (j>=0 && arr[j]>var)
        {
            arr[j+1]=arr[j];
            j--;
        }
        arr[j+1]=var;
    }
}

// Вывод сгенерированного массива
double[] array = Gen1DArr(10, 3, 20);
Print1DArr(array);

// Вывод отсортированного массива
InsertSort(array);
Print1DArr(array);

// Вывод разницы между максимальным и минимальным элементом массива
PrintData("Разница между максимальным и минимальным элементом массива равна: ", MaxMin(array));

