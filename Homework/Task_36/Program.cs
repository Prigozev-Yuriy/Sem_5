// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
int[] array = GetArray(10, -99, 99);
for (int i = 0, count = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        count = count + array[i];
    }
    if (i + 1 == array.Length)
    {
        Console.WriteLine($"Сумма элементов массива: [ {string.Join("; ", (array))} ] стоящих на нечетных позициях равна [{count}]");
    }
}