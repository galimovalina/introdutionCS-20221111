// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.Write("Введите номер дня недели: ");
int d = Convert.ToInt32(Console.ReadLine());
if (d > 0 && d < 8)
{
    if (d == 6 || d == 7) System.Console.WriteLine("Является выходным днем");
    else System.Console.WriteLine("Не является выходным днем");
}
else System.Console.WriteLine("Введите число от 1 до 7");