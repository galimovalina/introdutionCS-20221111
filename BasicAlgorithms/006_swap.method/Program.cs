
void Swap(ref int a, ref int b)// reference-ссылка
{
    int t=a;
    a=b;
    b=t;
}

void Calculator (int a, int b, out int sum, out int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=3, b=5;
System.Console.WriteLine($"a={a}, b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a}, b={b}");
int sum, multi;
Calculator(a, b, out sum, out multi);
System.Console.WriteLine($"{sum}, {multi}");

Convert.ToInt32();
int.TryParse("1234hgf", out a);