// 37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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

int AmountEven(int[] a)
{
    int even = 0;
        for (int i = 0; i < a.Length; i++)
        if (a[i] % 2 == 0) even++;
            return even; 
}

int AmountOdd(int[] a)
{
    int odd = 0;
        for (int i = 0; i < a.Length; i++)
        if (a[i] % 2 != 0) odd++;
            return odd; 
}


int[] m = RandomIntArray(5, 100, 999);
Print(m);
System.Console.WriteLine();
System.Console.WriteLine($"Количетво четных чисел: {AmountEven(m)}");
System.Console.WriteLine($"Количетво нечетных чисел: {AmountOdd(m)}");
