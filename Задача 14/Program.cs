 // Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

double mathAver = (a + b)/2;
Console.WriteLine("Среднее арифметическое введенных чисел равно {0}", mathAver);
double geomAver = Math.Sqrt(a + b);
Console.WriteLine("Среднее геометрическое введенных чисел равно {0}", geomAver);
