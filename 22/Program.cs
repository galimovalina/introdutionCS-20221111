// 22. Программа проверяет пятизначное число на палиндромом.

System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n;
int b = 0;
if (n > 9999 && n < 100000)
{
    while (n % 10 > 0)
    {
        b = b * 10 + n % 10;
        n = n / 10;
    }
    if (a == b) System.Console.WriteLine("Является палиндромом");
    else System.Console.WriteLine("Не является палиндромом");
}
else System.Console.WriteLine("Число не пятизначное");
