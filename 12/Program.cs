// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a=Convert.ToInt32(Console.ReadLine());
int max=0;
if (a%10>a/10) 
    {
        max=a%10;
    }
    else
    {
        max=a/10;
    }
System.Console.WriteLine(max);
    
//Условие ввода

int a;
do
{
    a=Convert.ToInt32(Console.ReadLine());
}
while (a<10 || a>99);
