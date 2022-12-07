
string s = "asdf";
//immutable string (неизменяемая строка)
System.Console.WriteLine(s[0]);
for (int i = 0; i < s.Length; i++)
    System.Console.WriteLine(s[i]);

char[] cc = s.ToCharArray();
cc[0] = 'S';
s = new String(cc);

System.Text.StringBuilder sb = new System.Text.StringBuilder("asdfg");
sb[0] = 's';
s = sb.ToString();

for (int i = 0; i < s.Length; i++)
    sb.Append("1"); //приклеить к строке 1


string s1 = "Hello";
string s2 = "Hello";
System.Console.WriteLine(s1 == s2);
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1, 2, s2, 3, 4, true)); //2- с какого символа сравнивать s1, 3 - с какого символа сравнивать s2, 4-сколько символов сравнивать

//s1.Length
s2 = s1.Substring(2, 4); //вырезать часть строки 
System.Console.WriteLine(s1.IndexOf("as")); //найти совпадение
s1 = s1.Replace('a', 'b'); //поменять символ на символ 

string s = Console.ReadLine();
string[] ss = s.Split(' ');
int[] n = new int[ss.Length];
for (int i = 0; i < ss.Length; i++)
    n[i] = Convert.ToInt32(ss[i]);
int a = n[0];
int b = n[1];
int c = n[2];


string[] ss = Console.ReadLine().Split(' ');
int[] n = Array.ConvertAll<string, int>(ss, Convert.ToInt32); //обобщенные типы и параметризированные методы
int a = n[0];
int b = n[1];
int c = n[2];