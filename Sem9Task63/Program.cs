// Задача №63
// Задайте значение N. Напишите программу,
// которая выведет ве натуральные числа в промежутке
// от N до 1 (выполнить с помощь рекурсии)

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод вывода ряда чисел от N до 1
void LineGenRec(int num)
{
    Console.Write(num + "\t");
    if (num == 1)
    {
    }
    else
    {
        LineGenRec(num - 1);
    }
}

Console.Clear();

// Принимаем от пользователя значение числа N
int numN = ReadData("Введите число N: ");

// Выводим в строку все натуральные числа от N до 1
LineGenRec(numN);