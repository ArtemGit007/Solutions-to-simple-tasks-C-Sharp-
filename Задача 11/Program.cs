//  Задача 11. 1. Составить программу обмена значениями трех переменных величин а, b, c по следующей схеме: 
// b присвоить значение c, а присвоить значение b, с присвоить значение а.

Console.WriteLine("Введите переменную а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную в: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную с: ");
int c = Convert.ToInt32(Console.ReadLine());

int temp = c;

c = a;
a = b;
b = temp;

Console.WriteLine("Новое значение переменной а = {0}", a);
Console.WriteLine("Новое значение переменной b = {0}", b);
Console.WriteLine("Новое значение переменной c = {0}", c);
