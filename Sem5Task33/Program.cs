// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
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

// // Метод поиска заданного числа в массиве
// bool SearchElem(int[] arr, int elem)
// {
//     bool res = false;
//     for (int i=0; i < arr.Length; i++)
//     {
//         if (arr[i] == elem)
//         {
//             res = true;
//             break;
//         }
//     }
//     return res;
// }

// Метод поиска заданного числа в массиве (более универсальный вариант)
int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}

// Объявляем массив согласно условию задачи
int[] mass = Gen1DArr(12, -9, 9);

// Выводим массив, заполненный случайными чмслами диапазона (-9, 9)
Print1DArr(mass);

// Ввод искомого элемента пользователем
int searchNum = ReadData("Введите искомый элемент массива: ");

// Введем переменную для хранения результата работы метода поиска заданного элемента
int result = SearchElem(mass, searchNum);

// Выводим результат поиска
if (result >= 0)
{
    Console.WriteLine("Искомый элемент найден и находится в массиве под индексом: " +result);
}
else
{
    Console.WriteLine("Искомый элемент в массиве отсутствует");
}
