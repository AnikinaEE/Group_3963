// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int number = ReadData("Введите число: ");

// Метод подсчета количества цифр в веденном числе
int DigitSum(int num)
{
    int res = 0;    // res = num.ToString.Length;  res = Math.Log(num)+1;
    while (num > 0)
    {
        res+=1;
        num = num/10;
    }
    return res;
}

int sum = DigitSum(number);

// Метод вывода результата
void PrintResalt(string output)
{
    Console.WriteLine(output);
} 
PrintResalt("Количесиво цифр во введенном числе: " + sum);

