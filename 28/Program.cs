// 28. Определить кол-во цифр в числе

int CountDigits(int Number)
{
    Number = Math.Abs(Number);
    int count = 0;
    if (Number == 0) count = 1;
    while (Number > 0)
    {
        Number = Number / 10;
        count++;
    }
    return count;
}

int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));