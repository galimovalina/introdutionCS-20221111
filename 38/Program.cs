// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size, int min = 0, int max = 100)
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

int Find(int[] a, int min=0, int max=1)
{
    int result=0;
    for (int i=min; i<=max; i++) result++;
     return result;
}

int[] m = RandomIntArray(123, 1, 100);
Print(m);
System.Console.WriteLine();
System.Console.WriteLine(Find(m, 10, 99));
