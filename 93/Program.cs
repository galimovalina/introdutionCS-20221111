// 93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Random2DArray(int n, int m, int min = 1, int max = 9)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
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

int[,] PowArrays(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    for ( i = 0; i < b.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
        for ( j = 0; j < b.GetLength(1); j++)
        a[i,j]=a[i,j]*b[i,j];
            
    return a;
}

int[,] a = Random2DArray(4, 4);
int[,] b = Random2DArray(4, 4);
Print2DArray(a);
System.Console.WriteLine();
Print2DArray(b);
PowArrays(a,b);
System.Console.WriteLine();
Print2DArray(a);
