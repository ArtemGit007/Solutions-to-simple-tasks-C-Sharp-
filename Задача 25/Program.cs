// Вычислить периметр и площадь прямоугольника по заданным пользователем 
// длинам сторон.

Console.WriteLine("Введите значение стороны а:"); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны b:"); 
int b = Convert.ToInt32(Console.ReadLine());


double per = (a + b)*2;
Console.WriteLine("Периметр прямоугольника равен {0}", per);

double sque = a * b;
Console.WriteLine("Площадь  прямоугольника равна {0}", sque);
