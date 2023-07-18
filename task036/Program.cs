double SearchNumber(int [] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = (double) (sum + array[i]);
        }
    }
    return sum;
}

int [] GetArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(int.MinValue, int.MaxValue);
    }
    return array;
}

Console.Write("Введите длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

Console.Clear();
Console.WriteLine($"[{String.Join(", ", GetArray(array))}]");

Console.WriteLine($"Сумма равна {SearchNumber(array)}.");