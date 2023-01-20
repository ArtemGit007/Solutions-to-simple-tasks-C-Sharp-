// Даны два действительных числа x и у. Вычислить их сумму, 
// разность, произведение и частное.

Console.WriteLine("Введите переменную х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную y: ");
int y = Convert.ToInt32(Console.ReadLine());

double sum = x + y;
// double sub = x - y;
// double tub = x * y;
// double del = x / y;

Console.WriteLine("Сумма чисел х и число у равна: {0}",  sum);  
Console.WriteLine("Разность чисел х и число у равна: {0}",  (double) x - y);  
Console.WriteLine("Произведение числа х на число у равно: {0}", (double) x * y);  
Console.WriteLine("Деление числа х на число у равно: {0}", (double) x / y);
