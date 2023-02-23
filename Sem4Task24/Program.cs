// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int number = ReadData("Введите число N: ");

// Метод подсчета суммы чисел от 1 до N
int SumSimple(int numN)
{
    int sum = 0;
    for (int i=0; i<=numN; i++)
    {
        sum+=i;   // Аналогично sum=sum+i
    }
    return sum;
}

int SumGausse(int numS)
{
    int sum = 0;
    sum = ((1+numS)*numS)/2;
    return sum;
}

// Введем переменную, куда запишем результат работы метода подсчета суммы чисел
// int res1 = SumSimple(number);
// int res2 = SumGausse(number);

// Метод вывода результата
void PrintResalt(string output)
{
    Console.WriteLine(output);
} 

DateTime d1 = DateTime.Now;     // DateTime d1 - время старта работы программы, DateTime.Now - время окончания, соответственно
int res1 = SumSimple(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGausse(number);
Console.WriteLine(DateTime.Now - d2);

PrintResalt("Сумма чисел от 1 до N равна: " + res1);
PrintResalt("Сумма чисел от 1 до N равна: " + res2);

