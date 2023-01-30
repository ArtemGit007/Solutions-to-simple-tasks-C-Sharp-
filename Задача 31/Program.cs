 // Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^2, а^5 и а^17 a за шесть операций.

 string buf;
 Console.WriteLine(" Введите вещественное число а: ");
 buf = Console.ReadLine();
 double a = double.Parse(buf);

double j = a * a * 1 * 1 * 1 * 1 * 1; // j = a^2
double k = a * a * a * a * a * a * 1; // k = a^5

double i = a * a; // i = a^2
double b = i * i; // b = a^4
double c = b * b; // c = a^8
double d = c * a; // d = a^9
double e = d * b; // c = a^13
double x = e * b; // x = a^17

Console.WriteLine(" a во второй степени = {0}, в 5-ой = {1},  в 17-ой = {2}", j, k, x);

//  Проверка методом
double q = Math.Pow(a, 17);
Console.WriteLine(q);
