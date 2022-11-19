// 30. Написать программу вычисления произведения чисел от 1 до N
/* Без подпрограммы
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int prod=1;
while (i!=N)
{
    i++;
    prod=prod*i;
}
System.Console.WriteLine(prod);
*/

int Fact (int Number)
{
int i=1;
int prod=1;
while (i!=Number)
{
    i++;
    prod=prod*i;
}
return prod;
}

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Fact(N));