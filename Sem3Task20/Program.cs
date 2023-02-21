// Задача №20
// Напишите программу, которая на вход принимает координаты 
// двух точек и находит расстояние между ними в 2D пространстве

// Метод считывания данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");
}

// Метод расчета расстояния м/у точками на плоскости
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y1-y2)*(y1-y2));       // Math.Sqrt(Math.Pow(x2-x1) + Math.Pow(y1-y2))
}

// Метод выввода данных
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}


// Ввод координат точек
int x1 = ReadData("Введите координату X точки A: ");
int y1 = ReadData("Введите координату Y точки A: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

double res = CalcLen2D(x1, x2, y1, y2);
PrintData("Расстояние между точками A и B: ", res);
