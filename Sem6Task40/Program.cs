// Задача №40 
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник со сторонами такой длинны

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numFirst = ReadData("Введите первое число: ");
int numSecond = ReadData("Введите второе число: ");
int numThird = ReadData("Введите третье число: ");

// Метод провреки на существование треугольника со стронами введенной длины
bool TriangleTest(int a, int b, int c)
{
    bool res = false;
    if(a<=b+c && b<=a+c && c<=a+b)
    {
        res = true;
    }
    return res;
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

bool result = TriangleTest(numFirst, numSecond, numThird);

// Выводим результат проверки на существование треугольника
if (result == false) PrintData("Треугольника со сторонами такой длины не существует");
else PrintData("Треугольник со сторонами такой длины существовать может");
