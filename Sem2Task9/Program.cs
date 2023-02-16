// Задача №9
// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа

System.Random numSintesator = new System.Random();

// Определяем случайное число от 10 до 99 и выводим его на экран
int rndNumber = numSintesator.Next(10, 100);
Console.WriteLine(rndNumber); 

// Определяем первую и вторую цифру нашего случайного числа
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if(firstNum > secondNum)
{
    Console.WriteLine("Наибольшая цифра числа: " + firstNum);
}
else
{
    Console.WriteLine("Наибольшая цифра числа: " + secondNum);
}

// // Представим число в виде массива (char - тип символы) в строковом представлении (ToString) 
// char[] digits = numSintesator.Next(10, 100).ToString().ToCharArray();
// Console.WriteLine(digits);

// int firstNum = ((int)digits[0])-48;
// int secondNum = ((int)digits[1])-48;

// int resultNumber = firstNum > secondNum ? resultNumber = firstNum : resultNumber = secondNum;

// Console.WriteLine($"Наибольшая цифра числа: {resultNumber}");

