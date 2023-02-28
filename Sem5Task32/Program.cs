// Задача №32 
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот

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

// Метод смены знаков элементов массива
void InversArr(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

// Объявляем массив согласно условию задачи
int[] testArr = Gen1DArr(12, -9, 9);

// Выводим массив, заполненный случайными чмслами диапазона (-9, 9)
Print1DArr(testArr);

// Меняем значения элементов массива на противоположный знак
InversArr(testArr);

// Выводим полученный массив
Print1DArr(testArr);
