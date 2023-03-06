// Задача №41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numN = ReadData("Введите количество чисел для ввода: ");

// Метод ввода чисел с клавиатуры и подсчета положительных среди введенных
int CountNum(int number)
{
    int res = 0;
    for (int i=0; i<number; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        int num = int.Parse(Console.ReadLine()?? "0");
        if (num > 0)
        res++;
    }
    return res;
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

PrintData("Количество положительных чисел среди введенных равно:" + CountNum(numN));
