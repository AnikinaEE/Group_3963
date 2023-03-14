// Задача №69 
// Напишите прграмму, которая принимает два числа А и В, 
// и возведет А в степень В (с помощью рекурсии)

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// // Рекурсивный метод возведения числа в степень
// long RecPow(int a, int b)
// {
//     if (b <= a) return a;
//     return a * RecPow(a, b-1);
// }

// Рекурсивный метод 2 возведения числа в степень
long MyPow(int a, int b)
{
    // if (b == 2) return 4;    // Если степень четная
    // else return MyPow(a, b/2) * MyPow(a, b/2);

    if (b == 2) return a*a;
    if (b == 1) return a;

    if (b%2 == 0)
    {
        return MyPow(a, b/2) * MyPow(a, b/2);
    }
    else
    {
        return MyPow(a, b/2) * MyPow(a, b/2 + 1);
    }
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

Console.Clear();

// Принимаем от пользователя значения чисел А и В
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");

// Выводим число А, возведенное в степень В
// long resPow = RecPow(numA,numB);
long resPow = MyPow(numA,numB);
PrintData("Число А в степени В равно: " + resPow);