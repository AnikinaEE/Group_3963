// Задача №42
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numN = ReadData("Введите число: ");

// Метод перевода числа в двоичную систему счисления
string DecToBin(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num%2 + res;
        num = num/2;
    }
    return res;        
}

// // Альтернативный метод перевода числа в двоичную систему счисления (метод С#)
// string DecToBin2(int num, int baseI)
// {
//     return Convert.ToString(num, baseI);     // baseI - система счисления, в которую необходимо перевести число (2, 8, 16)
// }

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

// Вывод полученного результата
string result = DecToBin(numN);
PrintData($"Десятичное число {numN} в двоичном счислении равно: " + result);

