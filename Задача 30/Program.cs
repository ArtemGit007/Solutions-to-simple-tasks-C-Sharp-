 // Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^4, а^12 и а^28 за шесть операций.

string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double j = a * a * 1 * a * a * 1; // j = a^4

double i = a * a;  // i = a^2
double b = i * i;  // b = a^4
double c = b * b; // c = a^8
double d = c * i; // d = a^10
double f = d * i * 1; // d = a^12
double e = d * d; // d = a^20
double t = e * c; // d = a^28

Console.WriteLine(" a в четвертой степени = {0}, в 12-ой = {1}  в 28-ой = {2}", j, f, t);

//  Проверка методом
double q = Math.Pow(a, 28);
Console.WriteLine(" a в степени {0}", q);
