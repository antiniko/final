string[] array1 = new string[7] { "Russia", "050", "2022", "hello", ":-)", "world", "-2" };
string[] array2 = new string[array1.Length];
Console.Write($"Новый сформированный массив: [");
void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
       
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}
FillArray(array1, array2);
PrintArray(array2);