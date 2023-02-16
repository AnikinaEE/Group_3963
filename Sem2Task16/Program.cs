// Задача №16 
// Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли одно число
// квадратом другого

Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine()?? "0");

// Запишем метод проверки первого числа на квадрат второго (void - пустой тип)
// * имя метода всегда пишется с большой буквы
void SqrTest(int numOne, int numTwo)
{
    if(numOne == numTwo*numTwo)
    {
        Console.WriteLine($"Первое число {numOne} является квадратом второго числа {numTwo}");
    }
    else
    {
        Console.WriteLine($"Первое число {numOne} НЕ является квадратом второго числа {numTwo}");
    }
}

SqrTest(numOne, numTwo);
SqrTest(numTwo, numOne);
