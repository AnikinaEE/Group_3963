// Задача №11
// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру
// этого числа

// Генерируем случайное трехзначное число (100, 1000)
int num = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " + num);

// Определяем первую и последнюю цифру числа
int firstDigit = num % 10;
int lastDigit = num / 100;

// Полученные две цифры собираем в число (перезаписав его в переменную "num")
num = firstDigit * 10 + lastDigit;
Console.WriteLine("Полученное число: " + num);

// // Также результат можно сразу вывести одной строкой без использования доп переменных
// Console.WriteLine((num / 100)*10 + (num % 10));

