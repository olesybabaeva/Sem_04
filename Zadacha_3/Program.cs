﻿// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] result = GetNumberArray(8);

Console.Write($"[{string.Join(", ", result)}]");

int[] GetNumberArray (int size)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array; 
}