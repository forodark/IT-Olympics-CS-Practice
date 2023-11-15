using System;

class Program {
static void Main()
    {
        int[] array = { 12, 4, 5, 6, 7, 3, 1, 15 };

        Console.WriteLine("Original array:");
        PrintArray(array);

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partitioning index, arr[pi] is now at the right place
            int pi = Partition(arr, low, high);

            // Recursively sort the elements before and after partition
            QuickSortAlgorithm(arr, low, pi - 1);
            QuickSortAlgorithm(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1; // Index of smaller element

        for (int j = low; j < high; j++)
        {
            // If the current element is smaller than or equal to the pivot
            if (arr[j] <= pivot)
            {
                i++;

                // Swap arr[i] and arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Swap arr[i+1] and arr[high] (pivot)
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}