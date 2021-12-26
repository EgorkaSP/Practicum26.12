void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-50,50);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
       Console.Write($"{numbers[i]} ");
    }
}

int[] array = new int[20];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] > 8) Console.Write($"{array[i]} ");
    
}
Console.WriteLine();