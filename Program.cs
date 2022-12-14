string[] array = ReadArray();
int resultSize = CountStringsLessThenThree(array);
string[] resultArray = new string[resultSize];
int resultIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[resultIndex] = array[i];
        resultIndex++;
    }
}
PrintArray(resultArray);


string[] ReadArray()
{
    Console.Write("Enter the size of the array: ");
    int size = int.Parse(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


int CountStringsLessThenThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine($"\"{array[array.Length - 1]}\"]");
}