// 31. Сгенерировать 10 случайных чисел. Показать кубы чисел, заканчивающихся на четную цифру

bool Test(int a)
{
    //if (a%2==0) return true; else return false;
    return a%2==0;
}


Random random=new Random();
random.Next(1,100);
for (int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(b))
    System.Console.WriteLine($"{a}, {b}");
}

