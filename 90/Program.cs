// 90. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
//Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1

int[] RandomDataArray(int size, int min=0, int max=1)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int[] RandomInfoArray(int size, int min=0, int max=9)
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

int size=5;
int[] data=RandomDataArray(size);
Print(data);
System.Console.WriteLine();
int[] info=RandomInfoArray(5);
Print(info);

//int [] info=new int[];
