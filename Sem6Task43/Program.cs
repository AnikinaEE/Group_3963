// Задача №43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем
// * Найдите точки пересечения 3х прямых, длину прямых между тосками пересечения, 
// площадь треугольника образованного пересечением 3х прямых

// Метод ввода информации от пользователя
int ReadData(string mess)
{
    Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()?? "0");     // При вводе сразу осуществляем проверку на пустое значение - NULL
}

int numB1 = ReadData("Введите значение b1: ");
int numB2 = ReadData("Введите значение b2: ");
int numB3 = ReadData("Введите значение b3: ");
int numK1 = ReadData("Введите значение k1: ");
int numK2 = ReadData("Введите значение k2: ");
int numK3 = ReadData("Введите значение k3: ");

// Метод определения точки пересечения двух прямых
(double pointX, double pointY) Intersection(double b1, double b2, double k1, double k2)
{
    double newX = (b2-b1)/(k1-k2);
    double newY = (k1*b2 - k2*b1)/(k1-k2);
    return (newX,newY);
}

// Метод вывода полученного результата
void PrintData(string mess)
{
    Console.WriteLine(mess);
}

// Вычисляем координаты пересечения
(double X1, double Y1)coord1 = Intersection(numB1,numB2,numK1,numK2);
(double X2, double Y2)coord2 = Intersection(numB1,numB3,numK1,numK3);
(double X3, double Y3)coord3 = Intersection(numB2,numB3,numK2,numK3);

// PrintData($"Координаты точки пересечения двух прямых: ({coord1.X1},{coord1.Y1})");
PrintData($"Координаты точек пересечения трех прямых: A({coord1.X1};{coord1.Y1}), B({coord2.X2};{coord2.Y2}), C({coord3.X3};{coord3.Y3})");

// Метод расчета расстояния м/у точками на плоскости
double CalcLen(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y1-y2)*(y1-y2));       // Math.Sqrt(Math.Pow(x2-x1) + Math.Pow(y1-y2))
}

// Вычисляем длинну отрезков, образованных точками пересечения прямых
double line1 = CalcLen(coord1.X1, coord1.Y1, coord2.X2, coord2.Y2);
double line2 = CalcLen(coord1.X1, coord1.Y1, coord3.X3, coord3.Y3);
double line3 = CalcLen(coord2.X2, coord2.Y2, coord3.X3, coord3.Y3);

PrintData($"Длина отрезков между точками пересечения трех прямых: L1 = ({line1}), L2 = ({line2}), L3({line3})");

// Вычисление площади треугольника, образованного пересечением трех прямых
double areaTriangl = Math.Sqrt(((line1+line2+line3)/2)*((line1+line3-line1)*(line1+line3-line2)*(line1+line2-line3))/2);

PrintData($"Площадь треугольника, образованного точками пересечения трех прямых равна: " + areaTriangl);
