// Вычислить расстояние между двумя точками с данными координатами (х1, у1) и (х2, у2).

Console.WriteLine(" Введите координату х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите координату y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите координату х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите координату y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)));

Console.WriteLine(" Расстояние между точками a и в равно {0}", d);