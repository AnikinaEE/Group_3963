// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру

Console.WriteLine("Введите номер дня недели: ");
string? lineDay = Console.ReadLine();

if (lineDay != null)
{
    int day = int.Parse(lineDay);

    string[] dayWeek = new string[7];
    dayWeek[0] = "понедельник";
    dayWeek[1] = "вторник";
    dayWeek[2] = "среда";
    dayWeek[3] = "четверг";
    dayWeek[4] = "пятница";
    dayWeek[5] = "суббота";
    dayWeek[6] = "воскресение";

    Console.WriteLine(dayWeek[day-1]);

    // string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
    // Console.WriteLine(outDayOfWeek);
}
