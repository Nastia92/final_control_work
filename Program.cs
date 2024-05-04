
void Main()
{
    Console.WriteLine("Введите количество строк:");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] strings = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        string? input = Console.ReadLine();
        strings[i] = input!;
    }

    int count = 0;
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int index = 0;
    foreach (string str in strings)
{
  if (str.Length <= 3)
  {
    result[index] = str;
    index++;
  }
}

Console.WriteLine("Длина <= 3 символов:");
foreach (string str in result)
{
    Console.WriteLine(str);
}
}
Main();

