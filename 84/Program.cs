// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
    if (char.IsDigit(s[i])) sum += s[i] - 48;
else Console.WriteLine("Это не является верной записью целого");
System.Console.WriteLine($"Сумма цифр введенного числа: {sum}");

