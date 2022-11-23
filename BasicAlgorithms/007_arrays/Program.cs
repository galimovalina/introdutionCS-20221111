// Рассчитать среднюю температуру за неделю


//массивы - это объекты
int N=7;
int [] t=new int[N];// создаем массив, то есть в t помещаем адрес массива, размер массива
double s=0;
//заполнить массив
for(int i=0;i<t.Length;i++)
{
    t[i]=Convert.ToInt32(Console.ReadLine());
}
//обработать массив
for(int i=0;i<t.Length;i++)
s=s+t[i];
//вывод результата
System.Console.WriteLine(s/t.Length);
