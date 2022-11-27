// 56. Написать программу копирования массива

int[] RandomIntArray(int size, int min = 1, int max = 100)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

void CopyArray(int[] a)
{
    int[] b=new int[a.Length];
    for (int i = 0; i < a.Length; i++)
        b[i] = a[i];    
}

int[] m = RandomIntArray(10);
Print(m);
CopyArray(m);
System.Console.WriteLine();
Print(m);