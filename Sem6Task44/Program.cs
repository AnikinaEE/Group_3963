// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1

int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numN = ReadData("Введите число N: ");

string FibNum(int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    int temp = 0;

    for (int i=1; i<num; i++)
    {
        res = res + " " + (first+last).ToString();
        temp = last;
        last = last+first;
        first = temp;
    }
    return res;
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

PrintData(FibNum(numN));
