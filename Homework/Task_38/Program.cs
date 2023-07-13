// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        int j = new Random().Next(0, 1000);
        result[i] = new Random().NextDouble() * j;
    }
    return result;
}
double[] array = GetArray(10);
double max = array.Max();
double min = array.Min();
double count = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: [ {string.Join("; ", (array))} ] равна [{count}]");