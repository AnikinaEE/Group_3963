// Задача №67
// Напишите программу, которая на вход принимает число и
// и возвращает сумму цифр данного числа

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод поиска суммы цифр числа
int RecSumDigit(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num%10 + RecSumDigit(num/10); 
    }
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

Console.Clear();

// Принимаем от пользователя значение числа
int numN = ReadData("Введите число: ");

// Выводим сумму цифр числа
int sumDigit = RecSumDigit(numN);
PrintData("Сумма цифр введенного числа равна: " + sumDigit);