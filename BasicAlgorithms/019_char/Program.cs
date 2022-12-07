
char c='a';
c='\x64';
c='\u0064';
char b='a';

System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='a' && b<='z') System.Console.WriteLine("It's letter");

if(Char.IsDigit(b)) System.Console.WriteLine("true");


