 // Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^21 за шесть операций.

string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double i = a * a; // i = a^2
double b = i * i; // b = a^4
double c = b * b; // c = a^8
double d = c * c; // d = a^16
double e = d * a; // c = a^17
double x = e * b; // x = a^21

Console.WriteLine(" a в 21-ой степени = {0} ",  x);

//  Проверка методом
double q = Math.Pow(a, 21);
Console.WriteLine(q);
