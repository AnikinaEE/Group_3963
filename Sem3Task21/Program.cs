// Задача №21
// Напишите программу, которая на вход принимает координаты
// двух точек и находит расстояние между ними в 3D пространстве

// Метод считывания данных от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");
}

// Осуществляем ввод координат точек
int x1 = ReadData("Введите координату X точки A: ");
int y1 = ReadData("Введите координату Y точки A: ");
int z1 = ReadData("Введите координату Z точки A: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z2 = ReadData("Введите координату Z точки B: ");

// Метод расчета расстояния м/у точками на плоскости
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y1-y2)*(y1-y2) + (z2-z1)*(z2-z1));       // либо - Math.Sqrt(Math.Pow(x2-x1) + Math.Pow(y1-y2) + Math.Pow(z2-z1))
}

// Введем переменную для записи результата работы метода CalcLen3D
double res = CalcLen3D(x1, x2, y1, y2,z1,z2);

// Метод выввода данных
void PrintData(string mess, double distance)
{
    Console.WriteLine(mess+distance);
}

PrintData("Расстояние между точками A и B равно: ", res);

