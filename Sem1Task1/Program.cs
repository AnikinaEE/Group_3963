// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго

Console.WriteLine("Введите первое число: ");
string? numLine1 = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numLine2 = Console.ReadLine();

if (numLine1 != null && numLine2 != null)
{
    // Parse метод преобразования строки в целое число
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);

    if (num2 * num2 == num1)
    {
        Console.WriteLine("Первое чсло ЯВЛЯЕТСЯ квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго");
    }
}
