// Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^28 за шесть операций.

 string buf;
 Console.WriteLine(" Введите вещественное число а: ");
 buf = Console.ReadLine();
 double a = double.Parse(buf);

double i = a * a; // i = a^2
double b = i * i; // b = a^4
double c = b * b; // c = a^8
double d = c * c; // d = a^16
double e = d * c; // c = a^24
double x = e * b; // x = a^28

Console.WriteLine(" a в 28-ой степени = {0} ",  x);

//  Проверка методом
double q = Math.Pow(a, 28);
Console.WriteLine(q);
