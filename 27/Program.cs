// 27. Возведите число А в натуральную степень B используя цикл

/*Без подпрограммы
System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
int s=A;
int i=1;
while(i!=B)
{
    A=A*s;
    i++;
}
System.Console.WriteLine(A);
*/

int Power(int num, int pow)
{
    int s = num;
    int i = 1;
    while (i != pow)
    {
        num = num * s;
        i++;
    }
    return num;
}

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Power(A,B));