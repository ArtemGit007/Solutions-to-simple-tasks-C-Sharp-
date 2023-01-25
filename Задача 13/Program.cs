// Найти произведение цифр заданного многозначного числа.

Console.WriteLine(" Введите многозначное число: ");
int i = Convert.ToInt32(Console.ReadLine());


//string _str = i.ToString();

//for (int j = _str.Length; j=>0; j--)
//   Console.WriteLine(_str[j]);

int c = i;
string str = c.ToString();
int[] b = new int[str.Length];
for (int j = 0; j < str.Length; j++)
{
    b[j] = int.Parse(str[j].ToString());

}

int res = b[0] * b[1] * b[2] * b[5];

Console.WriteLine(res);



