// Массив из случайных чиел



int[] RandomIntArray(int size, int min=0, int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i], 5}");
}

int[] m=RandomIntArray(10);
Print(m);