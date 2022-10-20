﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(100,1000);
    }
}

void PrintArray(int[]arr) 
{
   for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    } 
} 

int GetEvenInteger(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] % 2 == 0)
            count++;
    } 
    return count;
}

int []array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine("Количество четных чисел в массиве: " +GetEvenInteger(array));