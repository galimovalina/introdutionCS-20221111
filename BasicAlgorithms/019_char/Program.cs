
char c='a';
c='\x64';
c='\u0064';
char b='a';

System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='a' && b<='z') System.Console.WriteLine("It's letter");

if(Char.IsDigit(b)) System.Console.WriteLine("true");


string s="asdf";
//immutable string (неизменяемая строка)
System.Console.WriteLine(s[0]);
for (int i=0;i<s.Length;i++)
System.Console.WriteLine(s[i]);

char[] cc=s.ToCharArray();
cc[0]='S';
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("asdfg");
sb[0]='s';

s=sb.ToString();

for (int i=0;i<s.Length;i++)
sb.Append('1'); //приклеить к строке 1


string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2);
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1,2,s2,3,4,true));

//s1.Length
s2=s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("as"));
s2=s1.Replace('a','b');