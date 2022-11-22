int[] array = { 1, 18, 4, 47, 18, 6, 7, 8 };

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
    index++;
}
