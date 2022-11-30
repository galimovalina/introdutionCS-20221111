// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению

int[,] Random2DArray(int n, int k, int min = 0, int max = 10)
{
    int[,] a = new int[n, k];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < k; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}


void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

void ChangeEl(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                a[i, j] = Convert.ToInt32(Math.Pow(a[i, j], 2));
}

int[,] a = Random2DArray(4, 5);
Print2DArray(a);
System.Console.WriteLine();
ChangeEl(a);
Print2DArray(a);