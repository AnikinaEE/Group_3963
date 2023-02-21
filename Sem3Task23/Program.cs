// Задача №23
// Напишите программу, которая на вход принимает
// число N и выдает таблицу кубов чисел
// от 1 до N

// Метод считывания данных от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");
}

int N = ReadData("Введите число: ");

// Метод вычисления кубов чисел
string CalcCube(int num, int pow)
{
    string rez = string.Empty;     // Пустая строка для дальнейшего заполнения цифрами
    for (int i = 1; i <= num; i++)     // Цикл перебора чисел от 1 до N
    {
        rez = rez + Math.Pow(i,pow) + "\t";     // \t - табуляция (длинный отступ) 
    }
    return rez;
}

// Вывод в консоль результата метода CalcCube
Console.WriteLine(CalcCube(N,1));
Console.WriteLine(CalcCube(N,3));