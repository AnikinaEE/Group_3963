// Задача №64
// Задайте значение N. Напишите программу,
// которая выведет ве натуральные числа в промежутке
// от 1 до N (выполнить с помощь рекурсии)

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод вывода ряда чисел от 1 до N
void LineOutputNumRec(int num)
{
    if (num == 1)
    {
        Console.Write(num + " ");
    }
    else
    {
        LineOutputNumRec(num-1);
        Console.Write(num + " ");
    }
}

Console.Clear();

// Принимаем от пользователя значение числа N
int number = ReadData("Введите число N: ");

// Выводим в строку все натуральные числа от 1 до N
LineOutputNumRec(number);