string[] array1 = new string[5] {"Kazan", "DF", "Moscow", "98941969489", "WOW"};
string[] array2 = new string[array1.Length];
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length) System.Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
void CheckArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
CheckArray(array1, array2);
PrintArray(array2);