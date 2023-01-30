 string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double j = a * a * 1 * a * a ; // j = a^5

double i = a * a; // i = a^2
double b = i * i; // b = a^4
double c = b * b; // c = a^8
double d = c * a; // d = a^9
double f = d * b * 1; // f = a^13

Console.WriteLine(" a в пятиой  степени = {0}, в 13-ой = {1}", j, f);

//  Проверка методом
double q = Math.Pow(a, 13);
Console.WriteLine(q);
