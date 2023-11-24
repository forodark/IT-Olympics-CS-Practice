using System;

class LinearSearchExample
{
    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Target found, return the index
            }
        }

        return -1; // Target not found in the array
    }

    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int target = 50;

        int result = LinearSearch(array, target);

        if (result != -1)
        {
            Console.WriteLine($"Target {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Target {target} not found in the array");
        }
    }
}
