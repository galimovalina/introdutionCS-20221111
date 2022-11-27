// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
//Принять первые числа равными 0 и 1

string Fibonacci(int N)
{
    int a = 0;
    int b = 1;
    string s = "0 1";
    for (int i = 1; i <= N - 2; i++)
    {
        int t = a + b;
        a = b;
        b = t;
        s = s + " " + Convert.ToString(b);
    }
    return s;
}


System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Fibonacci(N));
