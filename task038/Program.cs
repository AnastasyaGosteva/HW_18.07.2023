// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double SearchDiff(double [] array)
{
    double maxArray = array[0];
    double minArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxArray < array[i]) maxArray = array[i];
        if (minArray > array[i]) minArray = array[i];
    }
    return Math.Round((maxArray - minArray),2);
}

double [] GetArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(1, 100) + new Random().NextDouble()), 2);
    }
    return array;
}

Console.Write("Введите длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];

Console.Clear();
Console.WriteLine($"[{String.Join(", ", GetArray(array))}]");

Console.WriteLine($"Разница равна {SearchDiff(array)}.");

