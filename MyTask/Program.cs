int[] oldArray = new int[10];
int[] newArray = new int[oldArray.Length];
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 20);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != 0) Console.Write($"{numbers[i]} ");

    }
}
void Demo(int[] array)
{
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i] > 8) newArray[i] = oldArray[i];

    }
}
FillArray(oldArray);
PrintArray(oldArray);
Console.WriteLine();
Demo(newArray);
PrintArray(newArray);