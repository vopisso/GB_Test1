string[] ShowLessThenThree(string[] array)
{
    int counter = 0;
    int size = array.Length;
    
    for (int i = 0; i < size; i++)
    {
        if(array[i].Length <= 3)
        {
            counter++;
        }
    }

    string[] result = new string[counter];

    for (int i = 0, j = 0; i < size; i++)
    {
       if(array[i].Length <= 3)
       {
           result[j] = array[i];
           j++;
       }
    }
    return result;
}

string PrintArrayString(string[] array)
{
    string result = string.Empty;
    int size = array.Length;
    
    result = "[";
    for (int i = 0; i < size; i++)
    {
        result += $"{'"' + array[i] + '"'}";
        if(i + 1 < size)
        {
            result += ", ";
        }
    }    
    result += "]";
    return result;
}

string[] array = {"hello", "2", "world", ":-)"};

Console.Clear();
Console.Write(PrintArrayString(array));
Console.Write(" -> ");

string[] newArray = ShowLessThenThree(array);

Console.WriteLine(PrintArrayString(newArray));
Console.WriteLine();

string[] array1 = {"1234", "1567", "-2", "computer science"};

Console.Write(PrintArrayString(array1));
Console.Write(" -> ");

string[] newArray1 = ShowLessThenThree(array1);

Console.WriteLine(PrintArrayString(newArray1));
Console.WriteLine();

string[] array2 = {"Russia", "Denmark", "Kazan"};

Console.Write(PrintArrayString(array2));
Console.Write(" -> ");

string[] newArray2 = ShowLessThenThree(array2);

Console.WriteLine(PrintArrayString(newArray2));
Console.WriteLine();