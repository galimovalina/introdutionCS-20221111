// 4. По заданному с клавиатуры номеру дня недели вывести его название

System.Console.Write("Введите номер дня недели: ");
int d=Convert.ToInt32(Console.ReadLine());
if (d==1)
{
    System.Console.WriteLine("Понедельник");
}
if (d==2)
{
    System.Console.WriteLine("Вторник");
}
if (d==3)
{
    System.Console.WriteLine("Среда");
}
if (d==4)
{
    System.Console.WriteLine("Четверг");
}
if (d==5)
{
    System.Console.WriteLine("Пятница");
}
if (d==6)
{
    System.Console.WriteLine("Суббота");
}
if (d==7)
{
    System.Console.WriteLine("Воскресенье");
}


