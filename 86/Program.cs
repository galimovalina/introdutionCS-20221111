// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке


int Count(char a)
{
    string s = Console.ReadLine();
    int k = 0;
    char[] c = s.ToCharArray();
    for (int i = 0; i < s.Length; i++)
        if (c[i] == a) k++;
    return k;
}


System.Console.WriteLine(Count('b'));





