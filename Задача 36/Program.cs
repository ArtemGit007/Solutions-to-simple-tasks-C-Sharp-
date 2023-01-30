// Составить программу вычисления значения функции 
// x=12a^2+7a-16 при любом значении а.

string buf;
Console.WriteLine(" Введите вещественное число a: ");
buf = Console.ReadLine();
double a = Convert.ToDouble(buf);

double x = (12*a*a*2) + 7*a - 16;
Console.WriteLine(x);
