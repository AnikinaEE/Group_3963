// Задача №17
// Напишите программу, которая принимает на вход
// координаты точки (x,y), причем x не равно 0 и
// y не равно 0, и выдает черверть плоскости, 
// в которой находится эта точка


// <тип> <имя метода>(<тип> <название переменной>)
// {
// return <тип>
// }

// Метод считывания данных, вводимых пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");
}

// Метод вывода данных
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка находится в I четверти плоскости");
    if (x > 0 && y < 0) Console.WriteLine("Точка находится во II четверти плоскости");
    if (x < 0 && y < 0) Console.WriteLine("Точка находится в III четверти плоскости");
    if (x < 0 && y > 0) Console.WriteLine("Точка находится в IV четверти плоскости");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);
