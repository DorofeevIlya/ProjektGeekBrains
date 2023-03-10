string [] a= {"Cat","Dog","Bird","Snake"};
void VivodArray (string[]a)
{
for (int i=0;i<a.Length;i++)
    {
        if (a[i].Length<=3)
        {
            System.Console.Write($" {a[i]} ");
        }
    }
}
VivodArray(a);