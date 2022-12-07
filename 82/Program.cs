// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s = Console.ReadLine();
int k = 0;
char[] c = s.ToCharArray();
for (int i = 0; i < s.Length; i++)
    if (c[i] != '.') k++;
    else break;
System.Console.WriteLine(k);







