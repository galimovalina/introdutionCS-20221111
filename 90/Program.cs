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

// int[] RandomArray(int size, int min, int max)
// {
//     int[] a = new int[size];
//     Random random = new Random();
//     for (int i = 0; i < size; i++)
//         a[i] = random.Next(min, max + 1);
//     return a;
// }

// void Print(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//         System.Console.Write($"{a[i],5}");
// }


// void DataToDec(int[] data, int[] info)
// {
//     // bit=info.ToString();
//     // char [] bitInfo=bit.ToCharArray();
//     int k = 0;
//     for (int i = 0; i < info.Length; i++)
//         {
//             for (int j = 0; j < info[i]; j++)
//             System.Console.Write(data[k + j] + ",");
//         k = k + info[i];
//         }
// }

// int size = 10;

// int[] data = RandomArray(size, 0, 1);
// Print(data);
// System.Console.WriteLine();
// int[] info = RandomArray(5, 0, 9);
// Print(info);
// int[] result = new int[info.Length];
// System.Console.WriteLine();
// DataToDec(data,info);


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int k = 0; // счетчик количества цифр в data
for (int i = 0; i < info.Length; i++) //разбываем data на числа в двоичном коде на основе количества бит из info
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[k + j]);
    }
    k += info[i];
    Console.Write(", ");
}

k = 0;
for (int i = 0; i < info.Length; i++) // преобразуем получившиеся числа из 2-ой в 10-ую
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[k + j] * (int)Math.Pow(2, info[i] - 1 - j);
    }
    k += info[i];
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
