//Программа, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых <= 3 символа.

Console.Clear();
string[] array1 = new string[4] {"1234","1567","-2","computer science"};
Console.Write("Начальный массив: ");
PrintArray(array1);
string[] array2 = new string[array1.Length];
NewArray(array1, array2);
Console.Write("Новый массив: ");
PrintArray(array2);

// Метод формирующий новый массив
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
//Метод выводящий массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

