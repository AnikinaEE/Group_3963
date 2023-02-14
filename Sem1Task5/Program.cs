// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N

Console.WriteLine("Введите число: ");
string? lineN = Console.ReadLine();

if (lineN != null)
{
    int N = int.Parse(lineN);
    string res = string.Empty;
    int negN = N * (-1);
    while (negN <= N)
    {
        res = res + negN + " ";
        negN = negN + 1;
    }
    Console.WriteLine(res);
}