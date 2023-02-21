// Задача №22
// Напишите программу, которая на вход принимает
// число N и выдает таблицу квадратов чисел
// от 1 до N

// Метод считывания данных пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");
}

// Метод вычисления квадратов чисел
string LineBuilder(int num, int pow)
{
    string rez = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        rez = rez + Math.Pow(i,pow) + "\t";       // Math.Pow(i,pow)+"\t"
    }
    return rez;
}

int N = ReadData("Введите число: ");

Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));