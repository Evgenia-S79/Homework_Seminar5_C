// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(0,100);
    }
}

void PrintArray(int[]arr) 
{
   for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    } 
} 

int GetSumNumNegativIndex(int[]arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum += arr [i];
    }
    return sum;
}

int []array = new int[4];

FillArray(array);
PrintArray(array);

Console.WriteLine("Сумма элементов, на нечетных позициях:  " +GetSumNumNegativIndex(array));