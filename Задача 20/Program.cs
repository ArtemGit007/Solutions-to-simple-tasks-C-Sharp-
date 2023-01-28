//  Заданы координаты трех вершин треугольника (х1, y1), (х2, у2), (х3, у3). 
// Найти его периметр и площадь.

Console.WriteLine(" Введите значение х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение х3:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение y3:");
int y3 = Convert.ToInt32(Console.ReadLine());

double sque = (((x1 - x3)*(y2 - y3)) - ((y1 - y3)*(x2 - x3)))/2;
Console.WriteLine(" Площадь треугольника равна {0}", sque);

double ab = Math.Sqrt((x2 -x1)*(x2 -x1) + (y2 - y1)*(y2 - y1));
double ac = Math.Sqrt((x2 -x3)*(x2 -x3) + (y2 - y3)*(y2 - y3));
double cb = Math.Sqrt((x1 -x3)*(x1 -x3) + (y1 - y3)*(y1 - y3));

double per = ab + ac + cb;
Console.WriteLine(" Периметр треугольника равен {0}", per);

