// Подсчитать сумму цифр, встречающихся в строке

// string s="12345";
// int sum=s.ToCharArray().Cast<int>().Sum();
// System.Console.WriteLine();

//Делегаты

// int CountDigits(string s)
// {
//     int count=0;
//     foreach (char c in s)
//     if (char.IsDigit(c))
//     count ++;
//     return count;
// }

// int CountLatin(string s)
// {
//     int count=0;
//     foreach (char c in s)
//     if (c>='A' && c<='Z' || c>='a' && c<='z')
//     //if (char.IsLetter(c))
//     count ++;
//     return count;
// }

// int CountRus(string s)
// {
//     int count=0;
//     foreach (char c in s)
//     if (c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё')
//         count ++;
//     return count;
// }

using System.Linq;
delegate bool IsChar(char c); //сигнатура bool(char)

class Program
{
    static int CountChars(string s, IsChar IsChar)
{
    int count=0;
    foreach (char c in s)
    if (IsChar(c))
       count ++;
    return count;
}

static bool IsLatin(char c)
{
    return (c>='A' && c<='Z' || c>='a' && c<='z');
}

static bool IsRus(char c)
{
return ((c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё'));
}

static void Main()
{
    // Action click;
    // click =new Action(выделение);
    // click=new Action(заливка;)
    //Func
    string s="Эта строка содержит latinskie буквы и цифры 12345";
    //System.Console.WriteLine(CountChars(s,IsLatin));
    System.Console.WriteLine(CountChars(s,delegate(char c)//анонимный делегат
    {
        return (c>='A' && c<='Z' || c>='a' && c<='z');
    }
    ));
    System.Console.WriteLine(CountChars(s,IsRus));
}
}


//Лямбда выражения

System.Console.WriteLine(CountChars(s,(c)=>//лямбда-выражение многострочное
    {
        return (c>='A' && c<='Z' || c>='a' && c<='z');
    }
));

System.Console.WriteLine(CountChars(s,(c)=>c>='A' && c<='Z' || c>='a' && c<='z'));//лямбда-выражение однострочное

//LINQ

static void Main()
{
    string s="Эта строка содержит latinskie буквы и цифры 12345";
    var queary=(from c in s where (c>='A' && c<='Z' || c>='a' && c<='z') select c).Count();
    System.Console.WriteLine(queary);

    System.Console.WriteLine(CountChars(s,IsLatin));
    System.Console.WriteLine(CountChars(s,IsRus));
}
