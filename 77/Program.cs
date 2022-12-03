// 77. Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности 0 и 1

int Fibonacci(int n)
{
    if(n==1) return 0;
    if(n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}

for (int i=1;i<=7;i++)
{
    System.Console.WriteLine(Fibonacci(i));
}
