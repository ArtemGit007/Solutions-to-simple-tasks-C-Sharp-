// Дано x. Получить значения -2x + Зх^2 – 4х^3 и 1 + 2x + Зх^2 + 4*х^3. 
// Позаботиться об экономии операций.

string buf;
Console.WriteLine("Введите число х:");
buf = Console.ReadLine();
double x = Convert.ToDouble(buf);

double x1 = Math.Pow(x,3);

double y = -2*x + 3*x*x - x1*4;
double a = 1 + 2*x + 3*x*x + x1*4;

Console.WriteLine("Значение первой задачи: {0}, второй:  {1}", y, a);
