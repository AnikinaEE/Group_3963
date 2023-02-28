// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива

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

// Метод заполнения массива в случайном порядке диапазопа (-9, 9)
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

// Метод подсчета положительных и отрицательных элементов массива
(int pos, int neg) NegPosSum(int[] arr)    // Сразу резервируем 2 переменные для подсчета сумм
{
    int posSum = 0;
    int negSum = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}

// Метод вывода полученного результата (подсчета сумм)
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Объявляем массив согласно условию задачи
int[] testArr = Gen1DArr(12, -9, 9);

// Объявляем переменную, в которую запишем результат подсчета суммы положительных и отрицательных элементов
(int posit, int negativ) results = NegPosSum(testArr);

// Выводим массив, заполненный случайными чмслами диапазона (-9, 9)
Print1DArr(testArr);

// Выводим результат подсчета сумм
PrintData("Сумма положительных значений массива: ", results.posit);
PrintData("Сумма отрицательных значений массива: ", results.negativ);
