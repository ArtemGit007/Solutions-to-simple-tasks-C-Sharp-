// Дано а. Не используя никаких функций и никаких операций, 
// кроме умножения, получить а^8 за три операции; а^10 и а^16 за четыре операции.
    string buf;
    Console.WriteLine(" Введите вещественное число а: ");
    buf = Console.ReadLine();
    double a = double.Parse( buf );
    
    double j = a * a; // j = a^2
    double b = j * j; // b = a^4
    double c = b * b; // с = a^8
    double d = c * a; // d = a^10
    double e = d * d; // e = a^16
    
    Console.WriteLine(" Ваше число a в 8 степени равно {0}, в 10 - {1},  в 16 - {2}", c, d, e);
    
    
