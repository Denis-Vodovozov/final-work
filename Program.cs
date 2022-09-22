
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element of array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] MinThreeCharactersLength(string[] array, int n)
{
    string[] newArray = new string[n];
    for (int i = 0, j = 0; i < array.Length && j < newArray.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);
Console.WriteLine();
ShowArray(MinThreeCharactersLength(myArray, a));