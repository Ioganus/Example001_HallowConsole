int [] array = {12,24,32,45,18,51,26,73,18};
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
        
    index++; // то же самое что и index+1
}