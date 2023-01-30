// Дано вещественное число а. Пользуясь только операцией умножения, 
// получить: а^3 и а^10 за четыре операции.


 string buf;
 Console.WriteLine(" Введите вещественное число а: ");
 buf = Console.ReadLine();
 double a = double.Parse(buf);

double j = a * a * a * 1; // j = a^3

double i = a * a; // i = a^2
double b = i * i; // b = a^4
double c = b * b; // c = a^8
double d = c * i; // d = a^10

Console.WriteLine(" a в nh третьей степени = {0}, в 10-ой = {1}", j, d);

//  Проверка методом
double q = Math.Pow(a, 10);
Console.WriteLine(" Проверка - а в степени 10 = {0}",q);
