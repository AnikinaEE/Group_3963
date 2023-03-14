// Задача№68
// Напишите программу вычмсления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных 
// числа m и n

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод расчета функции Аккермана
long FunctionAkkRec(long n, long m)
{
    if (n == 0) 
    {
        return m+1;
    }
    else if ((n != 0) && (m == 0)) 
    {
        return FunctionAkkRec(n-1, 1);
    }
    else
    {
        return FunctionAkkRec(n-1, FunctionAkkRec(n, m-1));
    }
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

Console.Clear();

// Принимаем от пользователя значения чисел m и n
int num1 = ReadData("Введите число M: ");
int num2 = ReadData("Введите число N: ");

// Выводим результат расчета функции Аккермана
long resAkk = FunctionAkkRec(num1,num2);
PrintData($"Функция Akk({num1},{num2}) = " + resAkk);