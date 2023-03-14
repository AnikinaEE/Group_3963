// Задача №65
// Задайте значения m и n. Напишите программу, которая найдет
// все натуральные элементы в промежутке от m до n

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Рекурсивный метод поска чисел от m до n
string RecMN(int m, int n)
{
    string res = String.Empty;
    if (m >= n)
    {
        res = n.ToString();
    }
    else
    {
        res = res + m + " " + RecMN(m+1,n);
    }
    return res;
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

Console.Clear();

// Принимаем от пользователя значение чисел m и n
int numN = ReadData("Введите число N: ");
int numM = ReadData("Введите число M: ");


// Защита от "дурака" (если введено n меньше m)
string resultLine = numN < numM ? RecMN(numN,numM) : RecMN(numM,numN);

// Выводим найденные элементы от m до n
PrintData(resultLine);