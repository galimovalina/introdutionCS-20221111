// 70. Показать натуральные числа от 1 до N, N задано

void Digits(int i,int N)
{
    if(i<=N)
    {
        System.Console.WriteLine(i);
        Digits(i+1, N);
    }
}

Digits(1,10);

