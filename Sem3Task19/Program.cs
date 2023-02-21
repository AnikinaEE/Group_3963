// Задача №19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом

// Метод считывания данных, полученных от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int num = ReadData("Введите пятизначное число: ");

// Метод проверки введенного числа, является ли оно палиндромом
bool PalindromTest(int num)
{
    bool res = false;
    if ((num/10000 == num%10) && ((num/1000)%10 == (num/10)%10))
    {
        res = true;
    }
    return res;
}

// Введем переменную для записи резальтата работы метода PalindromTest
bool result = PalindromTest(num);

// Проверяем является ли введенное число палиндромом
if (result == true)
{
    Console.WriteLine("Введенное число - палиндром");
}
else
{
    Console.WriteLine("Введенное число - НЕ палиндром");
}
