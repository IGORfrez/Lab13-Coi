// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader(){
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабараторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 16 октября 2026 года");
//     Console.WriteLine("0_0");
// }
// void PrintFooter(){
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, string group)
// {
//     Console.WriteLine($"Студент {name}, возраст {age}, группа {group}");
// }
// PrintStudentCard("Егор", 18, "ИСП");
// PrintStudentCard("Валерия", 17, "ЗСП");

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double averageGrade = 4.7;
// double baseScholarship = 2000;

// if (IsEligibleForBonus(averageGrade)) {
//     double totalScholarship = CalculateScholarship(baseScholarship, 15);
//     Console.WriteLine($"Стипендия с надбавкой: {totalScholarship}");
// } else {
//     Console.WriteLine($"Стипендия без надбавки: {baseScholarship}");
// }

// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }
// int CountFives(int[] grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) {
//             count++;
//         }
//     }
//     return count;
// }
// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fivesCount = CountFives(grades);
// Console.WriteLine($"Средний балл: {average}");
// Console.WriteLine($"Количество пятёрок: {fivesCount}");

// bool IsEven(int number) {
//     return number % 2 == 0;
// }
// int testNumber = 8;
// if (IsEven(testNumber)) {
//     Console.WriteLine($"{testNumber} — чётное число.");
// } else {
//     Console.WriteLine($"{testNumber} — нечётное число.");
// }

// int FindMax(int[] numbers) {
//     if (numbers.Length == 0) {
//         throw new ArgumentException("Массив не может быть пустым.");
//     }
//     int max = numbers[0];
//     for (int i = 1; i < numbers.Length; i++) {
//         if (numbers[i] > max) {
//             max = numbers[i];
//         }
//     }
//     return max;
// }
// int[] numbers = { 3, 7, 2, 9, 5 };
// Console.WriteLine($"Максимальное число: {FindMax(numbers)}");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// int SumArray(int[] numbers)
// {
//     int sum = 0;
//     foreach (int number in numbers)
//     {
//         sum += number;
//     }
//     return sum;
// }
// int[] myNumbers = { 1, 2, 3, 4, 5 };
// int total = SumArray(myNumbers);
// Console.WriteLine($"Сумма элементов массива: {total}");

// bool ContainsValue(int[] numbers, int target)
// {
//     foreach (int number in numbers)
//     {
//         if (number == target)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] sampleArray = { 10, 20, 30, 40, 50 };

// Console.WriteLine(ContainsValue(sampleArray, 25));
// Console.WriteLine(ContainsValue(sampleArray, 30));
// Console.WriteLine(ContainsValue(sampleArray, 10));

