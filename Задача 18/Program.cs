// Дан радиус окружности. Найти длину окружности и площадь круга.

Console.WriteLine(" Введите радиус окружности:");
int r = Convert.ToInt32(Console.ReadLine());

double pi = 3.14;
double c = 2 * pi * r;

Console.WriteLine(" Длина окружности равна {0}", c);

double sque = pi*r*r;
Console.WriteLine(" Площадь круга равна {0}", sque);

