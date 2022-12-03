// 71. Показать натуральные числа от N до 1, N задано

void Digits(int N)
{
    if(N>=1)
    {
        System.Console.WriteLine(N);
         Digits(N-1);
    }
  
}

Digits(10);
