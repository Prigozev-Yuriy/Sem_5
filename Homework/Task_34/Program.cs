﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
int[] array = GetArray(10, 100, 999);
for (int i = 0, count = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
    if (i + 1 == array.Length)
    {
        Console.WriteLine($"Массив: [ {string.Join("; ", (array))} ] имеет [{count}] четных чисел");
    }
}
