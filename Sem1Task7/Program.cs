// задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа

Console.WriteLine("Введите число: ");
string? lineN = Console.ReadLine();

if (lineN != null)
{
    int N = int.Parse(lineN);
    int res = N % 10;
    Console.WriteLine("Последняя цифра числа: " + res);
}