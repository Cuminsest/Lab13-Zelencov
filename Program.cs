/*PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("Дата формирования отчёта: 23.11.2026");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("    Конец программы");
    Console.WriteLine("X_X");
}


void PrintStudentCard(string name, int age, string group)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
}

PrintStudentCard("Егор", 18, "ИС-21");
PrintStudentCard("Валерия", 17, "ИС-21");


double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade)
{
    return averageGrade >= 4.5;
}

double averageGrade = 4.7;
double result;

if (IsEligibleForBonus(averageGrade))
{
    result = CalculateScholarship(2000, 15);
    Console.WriteLine($"Стипендия с надбавкой 15%: {result}");
}
else
{
    result = CalculateScholarship(2000, 0);
    Console.WriteLine($"Стипендия без надбавки: {result}");
}


double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine($"Средний балл: {average}, количество пятёрок: {fives}");


void PrintDivider()
{
    Console.WriteLine("--------------------");
}

Console.WriteLine("Начало работы программы");
PrintDivider();
Console.WriteLine("Обработка данных");
PrintDivider();
Console.WriteLine("Формирование отчёта");
PrintDivider();
Console.WriteLine("Работа завершена");


void PrintPerson(string name, int age)
{
    Console.WriteLine($"Имя: {name}, возраст: {age}");
}

PrintPerson("Анна", 20);
PrintPerson("Дмитрий", 25);
PrintPerson("Ольга", 19);


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


void PrintSeparator()
{
    Console.WriteLine("====================");
}

Console.WriteLine("Меню открыто");
PrintSeparator();
Console.WriteLine("Раздел «Оценки»");
PrintSeparator();
Console.WriteLine("Раздел «Расписание»");
PrintSeparator();
*/

double CalculateArea(double width, double height)
{
    return width * height;
}

double area = CalculateArea(5.5, 3.2);
Console.WriteLine($"Площадь прямоугольника: {area}");
