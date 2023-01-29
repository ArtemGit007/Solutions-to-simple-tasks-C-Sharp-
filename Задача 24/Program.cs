// Найти площадь треугольника, две стороны которого равны а и b, 
// а угол между этими сторонами равен g.

Console.WriteLine("Введите значение стороны а:"); 
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны b:"); 
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение угла gradus:"); 
double gradus = Convert.ToInt32(Console.ReadLine());


// S = 0,5 * a * b⋅*sin(gradus).
// радиан = градусы умножить на пи и разделить на 180.

//double pi = 3.14;
double radian = (gradus * Math.PI)/180;


double sque = Math.Sin(radian) * a * b * 0.5;
Console.WriteLine("Площадь треугольника равна {0}", sque);