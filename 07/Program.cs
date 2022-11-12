// 7. Выяснить является ли число чётным

System.Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    System.Console.WriteLine($"{a} - четное число");
}
else
{
    System.Console.WriteLine($"{a} - нечетное число");
}

