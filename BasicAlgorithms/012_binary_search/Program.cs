// Бинарный поиск

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

int BinSearch(int[] a, int find)
{
    int i;
    int left = 0;
    int right = a.Length - 1;
    i = left + (right - left) / 2;
    while (a[i] != find && left < right)
    {
        if (find > a[i])
            left = i+1;
        else 
           right = i;
        i = left + (right - left) / 2;
    }
    if (a[i] != find) return -1;
    else
        return i;
}


int[] m = RandomIntArray(10, 1, 10);
Print(m);
System.Console.WriteLine("\n" + BinSearch(m, find: 8));