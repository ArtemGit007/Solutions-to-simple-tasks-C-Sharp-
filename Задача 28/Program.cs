// Получить: а^4 и а^20 за пять операций.

string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double j = a * a * a * a * 1; // j = a^4
double i = a * a; // i = a^2
double b = i * i; // в = a^4
double c = b * b; // с = a^8
double d = c * c; // d = a^16
double e = d * b; // e = a^20

Console.WriteLine(" a в четвертой степени = {0}, в 20-ой = {1}", j, e);

//  Проверка методом
double q = Math.Pow(a, 20);
Console.WriteLine("Проверка - а в степени 20 равно {0}",q);
