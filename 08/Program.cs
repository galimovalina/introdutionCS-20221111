// 8. Вывести на экран числа от -N до N

int N=Convert.ToInt32(Console.ReadLine());
int i=-N;
while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
}