// Составить программу вычисления значения функции y=7x^2+3x-6 
// при любом значении x.

string buf;
Console.WriteLine("Введите любое число х:");
buf = Console.ReadLine();
double x = Convert.ToDouble(buf);

double y = 7*x*x*2 + 3*x - 6;
Console.WriteLine(y);
