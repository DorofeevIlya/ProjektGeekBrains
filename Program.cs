string[] a = { "Cat", "Dog", "Bird", "Snake", "Pig" };
string[] b = new string[a.Length];
void Zamena(string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            b[count] = a[i];
            count++;
        }
    }
}
void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}
Zamena(a, b);
PrintArray(b);

