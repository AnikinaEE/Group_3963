// Задача №36 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Метод заполнения массива случайными числами
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

// Метод подсчета суммы элементов, стоящих на нечетных позициях
int OddSum(int[] arr)
{
    int sum = 0;
    for (int i =1; i<arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

// Метод вывода полученного результата (сумма элементов, стоящих на нечетных позициях)
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Ввод данных, чтобы задать массив
int numLen = ReadData("Введите число N, определяющее длину массива: ");
int numMin = ReadData("Введите минимальное число дипазона значений элементов массива: ");
int numMax = ReadData("Введите максимальное число дипазона значений элементов массива: ");

int[] array = Gen1DArr(numLen, numMin, numMax);

// Вывод заполненного массива, согласно введенным данным
Print1DArr(array);

// Вывод суммы элементов массива, стоящих на нечетных позициях
PrintData("Сумма элементов массива, стоящих на нечетных позициях, равна: ", OddSum(array));


