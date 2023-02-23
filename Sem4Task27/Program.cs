// Задача №27
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numN = ReadData("Введите число N: ");

int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + (num%10);
        num = num/10;
    }
    return res;
}

// Метод вывода результата
void PrintResalt(string output)
{
    Console.WriteLine(output);
} 
PrintResalt("Сумма цифр числа N равна: " + SumDigit(numN));

