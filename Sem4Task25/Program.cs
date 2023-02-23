// Задача №25
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

// Метод возведения числа А в степень В
long Pow(int numA, int numB)
{
    long res = 1;
    while (numB>0)
    {
        res = res*numA;
        numB = numB-1;
    }
    return res;
} 

// Метод вывода результата
void PrintResalt(string output)
{
    Console.WriteLine(output);
} 
PrintResalt("Число А, возведенное в степень В, равно: " + Pow(numberA, numberB));

