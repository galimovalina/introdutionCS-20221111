﻿// 52. Написать программу преобразования десятичного числа в двоичное

string DecimaToBin(int n)
{
    string s = "";
    if (n == 0) return "0";
    while (n != 0)
    {
        //System.Console.Write(n%2);
        s = Convert.ToString(n % 2) + s;
        n /= 2;
    }
    return s;
}


System.Console.WriteLine(DecimaToBin(13));
