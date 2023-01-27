// Найти произведение цифр заданного многозначного числа.

Console.WriteLine(" Введите многозначное число: ");
int i = Convert.ToInt32(Console.ReadLine());

string str = i.ToString();
int[] b = new int[str.Length];
for (int j = 0; j < str.Length; j++)
{
    b[j] = int.Parse(str[j].ToString());

}
// для произведения цифр пятизначного числа
int res = b[0] * b[1] * b[2] * b[3] * b[4] * b[5] ;

Console.WriteLine(res);



