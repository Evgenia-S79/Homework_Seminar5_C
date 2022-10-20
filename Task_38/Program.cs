// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().NextDouble() * 100;
    }
}

void PrintArray(double[]arr) 
{
   for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
} 

double GetDifMaxMin(double[]arr)
{
    double max = 0;
    double min = arr [0];
     
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr [i] > max)
            max = arr [i];
       if (arr [i] < min)
            min = arr [i];
    }
    double Difference = max - min;
    return Difference;
}

double []array = new double [4]; 

FillArray(array);
PrintArray(array);

Console.WriteLine("Разница между максимальным и минимальным значением = " + GetDifMaxMin (array));
