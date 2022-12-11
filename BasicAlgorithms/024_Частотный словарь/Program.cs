//Частотный словарь
//Составить частотный словарь элементов одномерного массива состоящих из чисел от 0 до 99.

int[] data = { 1, 3, 4, 8, 3, 5, 8 };
int[] freqArray = new int[100];
foreach (int element in data)
    freqArray[element]++;
for (int i = 0; i < freqArray.Length; i++)
    if (freqArray[i] != 0)
        System.Console.WriteLine($"{i} {freqArray[i]}");


Dictionary<int, int> freqDic = new Dictionary<int, int>();
foreach (int element in data)
    if (freqDic.ContainsKey(element)) freqDic[element]++;
    else freqDic.Add(element, 1);
foreach (var el in freqDic)
    System.Console.WriteLine($"{el.Key} {el.Value}");