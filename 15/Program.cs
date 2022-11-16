// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

int a=Convert.ToInt32(Console.ReadLine());
if (a>99)
{
    System.Console.WriteLine((a/100)%10);
}
else
{
System.Console.WriteLine("NO");
}

// Вариант 2
if (a>99)
{
    while (a>1000)
    {
        a=a/10;
    }
    Console.WriteLine(a%10)
else
{
    Console.WriteLine("NO");
}
