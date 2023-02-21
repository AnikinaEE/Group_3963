// Задача №18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой
// четверти (x и y)

// Метод считывания данных пользователя
int ReadInput(string messege)
{
    Console.WriteLine(messege);
    return int.Parse(Console.ReadLine()?? "0");
}

int num = ReadInput("Введите номер четверти: ");

// Метод вывода данных дапазона возможных координат
void PrintAnsver(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("x > 0, y > 0");
        if (num == 2) Console.WriteLine("x > 0, y < 0");
        if (num == 3) Console.WriteLine("x < 0, y < 0");
        if (num == 4) Console.WriteLine("x < 0, y > 0");
    }
    else
    {
        Console.WriteLine("Неверно введена четверть");
    }
}
PrintAnsver(num);
