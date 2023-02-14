// Задача №2
// Напишите программу, которая на вход
// принимает два числа и выдает, какое 
// большее, а какое меньшее


Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("первое число больше второго");
}
else
{
    Console.WriteLine("второе число больше первого");
}

