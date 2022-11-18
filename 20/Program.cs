// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//тип имя(аргументы)
int Part(int x, int y)
{
    //тело подпрограммы
    int part=0;
if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;
return part;
}


System.Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
int p=Part(x,y);
System.Console.WriteLine("Part: "+p);