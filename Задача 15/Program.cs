// Вычислить периметр и площадь прямоугольного треугольника по заданным длинам двух катетов а и b.
 
Console.WriteLine(" Введите длину катета а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите длину катета b: ");
int b = Convert.ToInt32(Console.ReadLine());

double sque = (a * b)/2;
Console.WriteLine(" Площадь треугольника равнa {0}", sque);

double per = Math.Sqrt((a * a) + (b * b)) + a + b;
Console.WriteLine(" Периметр треугольника равен {0}", per);
