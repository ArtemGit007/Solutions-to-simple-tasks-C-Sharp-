//  Задача 9. Составить программу обмена значениями двух переменных величин.

Console.WriteLine("Введите переменную А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную В:");
int b = Convert.ToInt32(Console.ReadLine());

int buffer = a;

a = b;
b = buffer;

Console.WriteLine(" Новое значение перенменной A {0}", a);
Console.WriteLine(" Новое значение перенменной В {0}", b);
