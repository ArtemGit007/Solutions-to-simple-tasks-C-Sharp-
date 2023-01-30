 // Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^15 за пять операций.

string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double j = a * a; // j = a^2
double b = j * a; // в = a^3
double c = b * b; // с = a^6
double d = c * c; // d = a^12
double e = d * b; // e = a^15

Console.WriteLine(" Ваше число в 15 степени равно {0}", e);
