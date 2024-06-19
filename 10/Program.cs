using System;

public class Program
{
    public static void Main()
    {
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int sum = CalculateSum(array);
        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }

    public static int CalculateSum(int[,] array)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        }
        return sum;
    }
}