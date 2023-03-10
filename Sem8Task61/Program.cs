// Задача №61
// Вывести N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine() ?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

// Вспомогательный метод расчета Факториала
long Factorial(int n)
{
    long res = 1;
    for (int i = 1; i < n; i++)
    {
        res = res * i;
    }
    return res;
}

// Метод заполнения элементов треугольника Паскаля и вывод на печать результата
void PrintPascalTriangle(int nRow)
{
    for (int i=0; i<nRow; i++)
    {
        for (int k=0; k<nRow-i; k++)
        {
            Console.Write(" ");
        }
        for (int j=0; j<=i; j++)
        {
            Console.Write(" ");
            // Согласно формуле вычисления элементов треугольника Паскаля n!/k!*(n-k)!, n - номер строки элемента, k - номер столбца
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));       
        }
        Console.WriteLine();
    }
}

// Ввод количества строк треугольника, которое необходимо вывести
int countRow = ReadData("Введите количество строк треугольника Паскаля: ");

// Вывод полученного треугольника на печать
PrintPascalTriangle(countRow);