using System;

class BinarySearchExample
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the target is present at the middle
            if (array[mid] == target)
            {
                return mid;
            }

            // If the target is greater, ignore the left half
            if (array[mid] < target)
            {
                left = mid + 1;
            }
            // If the target is smaller, ignore the right half
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Target not found in the array
    }

    static void Main()
    {
        int[] sortedArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int target = 50;

        int result = BinarySearch(sortedArray, target);

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
