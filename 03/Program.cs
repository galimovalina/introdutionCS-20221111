// 3. С клавиатуры вводя два числа a и b. Найти максимальное из них

System.Console.Write("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());
 if (a>b)
 {
    System.Console.WriteLine($"{a} - максимальное число");
 }
 else
 {
    System.Console.WriteLine($"{b} - максимальное число");
 }