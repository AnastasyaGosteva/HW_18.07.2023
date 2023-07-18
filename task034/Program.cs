int SearchNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


int [] GetArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

Console.Write("Введите длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

Console.Clear();
Console.WriteLine($"[{String.Join(", ", GetArray(array))}]");
Console.WriteLine($"Количество четных чисел {SearchNumber(array)}.");

