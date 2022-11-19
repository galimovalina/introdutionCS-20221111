// 25. Вывести на экран кубы чисел от 1 до N


System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int b=0;
for (int i = 1; i <= N; i++)
{
    b = (int)Math.Pow(i, 3);
    System.Console.WriteLine(b);
}
