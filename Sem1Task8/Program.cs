// Задача №8 
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < numberN; i = i+2)
{
    Console.Write(i+" ");
}
