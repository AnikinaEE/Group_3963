// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N

using System.Numerics; 

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int number = ReadData("Введите число N: ");

// Метод подсчета произведения чисел от 1 до N (факториала числа N)
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i=1; i<=num; i++)
    {
        res=res*i;
    }
    return res;
}

// Метод вывода результата
void PrintResalt(string output)
{
    Console.WriteLine(output);
} 
PrintResalt("Произведение чисел от 1 до N равно: " + FactorCalc(number));
