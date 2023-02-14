// Задача №4
// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел


Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

// if (first > second)
// {
//     if (first > third)
//     {
//         Console.WriteLine("Максимальное число равно: "+first);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число равно: "+third);
//     }
// }
// else
// {
//     if (second > third)
//     {
//         Console.WriteLine("Максимальное число равно: "+second);
//     }
//     else
//     {
//     Console.WriteLine("Максимальное число равно: "+third);  
//     }
// }

int max = first;

if (second > max) max = second;
if (third > max) max = third;

Console.Write("Максимальное число равно: ");
Console.WriteLine(max);

