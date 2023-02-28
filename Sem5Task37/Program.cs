// Задача №37
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и
// предпоследний и т.д.
// Результат вывести в новом массиве

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

// Метод создания нового массива произведений пар чисел
int[] ConvertArr (int[] arr)
{
    int[] tempArr = new int[(arr.Length/2)+1];
    for (int i=0; i<((arr.Length/2)+1); i++)
    {
        tempArr[i] = arr[i]*arr[arr.Length-1 -i];
    }
    return tempArr; 
}

// Объявляем массив и заполняем его случайными числами диапазона
int[] testArr = Gen1DArr(15, 1, 30);

// Выводим сгененриванный массив
Print1DArr(testArr);

// Объявляем новый массив, куда запишем результат работы метода по вычислению произведений пар чисел
int[] multArr = ConvertArr(testArr);

// Выводим новый массив
Print1DArr(multArr);
