// Задача №34 
// Задайте массив, заполненный случайными положительными 
// трехзначными числами. 
// Напишите программу которая покажет количество 
// четных чисел в массиве
// * Отсортировать массив методом пузырька
// ** Отсортировать массив методом подсчета

// Метод заполнения массива случайными положительными трехзначными числами (100,999)
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

// *Метод сортировки массива пузырьком
void BubbleSort(int[] arr)
{
    for (int i=0; i<arr.Length-1; i++)
    {
        for (int j=i+1; j<arr.Length; j++)
        {
            if (arr[i]>arr[j])
            {
            int temp = arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
            }
        }
    }
}

// Метод подсчета количества четных чисел в массиве
int CountEvenNum(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Метод вывода полученного результата (количество четных элементов массива)
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}


// Метод заполнения массива случайными числами (1,9)
int[] Gen1DArr2(int len, int min, int max)   
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
void Print1DArr2(int[] arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

// **Метод сортировки массива подсчетом для диапазона елементов (1,9)
void CountSort(int[] arr)
{
    int[] count = new int[10];    // Создаем вспомогательный массив, куда будет записываться число вхождений каждого элемента исходного массива
    
    for (int i=0; i<arr.Length; i++)     // Проходим по всем элементам исходного массива 
    {
        count[arr[i]]++;     // Считаем число вхождений 
    }
    
    int j = 0;    // Вводим вспомогательную переменную для цикла
    for (int i=1; i<count.Length; i++)     // Проходим по элементам массива с результатом подсчета числа вхождений элементов исхлдного массива
    {
        while (count[i]>0)
        {
            arr[j] = i;    // Записываем номер ячейки (которая равна значению элемента в исходном массиве) в исходный массив 
            j++;
            count[i]--;    // Уменьшаем содержимое ячейки с подсчетом
        }
    }
} 



// Объявляем массив и заполняем его случайными трехзначными числами диапазона (100, 999)
int[] testArr = Gen1DArr(25, 100, 999);

// Выводим сгененрированный массив
Print1DArr(testArr);

// Производим сортировку массива пузырьковым методом и выводим результат
BubbleSort(testArr);
Print1DArr(testArr);

// Выводим полученный результат подсчета четных элементов массива
PrintData("Количество четных элементов массива равно: ", CountEvenNum(testArr));

// Объявляем второй массив и заполняем его случайными числами диапазона (1, 9)
int[] testArr2 = Gen1DArr2(25, 1, 9);

// Выводим на печеть сгенерированный массив
Print1DArr2(testArr2);

// Производим сортировку массива методом подсчета и выводим результат
CountSort(testArr2);
Print1DArr2(testArr2);
