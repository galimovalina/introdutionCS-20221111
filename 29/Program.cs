// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int CountSum(int Number)
{
    int sum = 0;
    if (Number == 0) sum = 0;
    while (Number > 0)
    {
        sum=sum+Number%10;
        Number = Number / 10;
    }
    return sum;
}

int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountSum(N));
