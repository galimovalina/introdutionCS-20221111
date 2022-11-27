// 51. С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

int CountNumbers(int N)
{
    int count=0;
    int a=0;
        for (int i = 1; i <= N; i++)
    {
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}


System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Чисел больше нуля: {CountNumbers(N)}");
