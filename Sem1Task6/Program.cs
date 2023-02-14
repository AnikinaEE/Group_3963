// Задача №6
// Напишите программу, которая на вход принмает число
// и выдает, является ли число четным 
// (делится ли оно на два без остатка)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("число является ЧЕТНЫМ");
}
else
{
    Console.WriteLine("число является НЕЧЕТНЫМ");  
}
