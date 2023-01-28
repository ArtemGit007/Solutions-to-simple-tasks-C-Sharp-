// Известны координаты на плоскости двух точек (x1, y1 и x2, y2). 
// Составить программу вычисления расстояния между ними.

Console.WriteLine(" Введите pзначение х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите pзначение y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите pзначение х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите pзначение y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)));

Console.WriteLine(" Расстояние между заданными двумя точками составляет {0}", d);