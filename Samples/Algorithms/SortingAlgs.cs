using System;

class SortingAlgorithms
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Perform sorting using different algorithms
        int[] insertionSortedArray = InsertionSort(array.Clone() as int[]);
        int[] selectionSortedArray = SelectionSort(array.Clone() as int[]);
        int[] bubbleSortedArray = BubbleSort(array.Clone() as int[]);

        // Print sorted arrays
        Console.WriteLine("\nInsertion Sort:");
        PrintArray(insertionSortedArray);

        Console.WriteLine("\nSelection Sort:");
        PrintArray(selectionSortedArray);

        Console.WriteLine("\nBubble Sort:");
        PrintArray(bubbleSortedArray);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Generate random integers between 1 and 100
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }

        return array;
    }

    static int[] SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }

        return array;
    }

    static int[] BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }
}
