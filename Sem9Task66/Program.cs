// Задача №66
// Задайте значения m и n. Напишите программу, 
// которая найдет сумму натуральных элементов 
// в промежутке от m до n

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод подсчета суммы элементов в промежутке от m до n
int SumDiditRecMN(int m, int n)
{
    if (m >= n) 
    {
        return n;
    }
    else 
    {
        return m + SumDiditRecMN(m+1,n);
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

// Заносим результат в переменную, осуществляя сразу проверку "от дурака" (чтобы n было не больше m) бинарным способом
int resSumMN = num1<num2 ? SumDiditRecMN(num1,num2) : SumDiditRecMN(num2,num1);

// Выводим результат на печать
PrintData("Сумма натуральных элементов в промежутке от M до N равна: " + resSumMN);