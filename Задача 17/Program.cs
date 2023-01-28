//  Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.

Random rnd = new Random();

int x1 = rnd.Next(-100, 100);
Console.WriteLine("Значение х1 равно {0}", x1);
int y1 = rnd.Next(-100, 100);
Console.WriteLine("Значение y1 равно {0}", y1);
int x2 = rnd.Next(-100, 100);
int y2 = rnd.Next(-100, 100);
Console.WriteLine(" Координаты второй точки {0}, {1}", x2, y2);
double d = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)));

Console.WriteLine(" Расстояние между точками a и в равно {0}", d);