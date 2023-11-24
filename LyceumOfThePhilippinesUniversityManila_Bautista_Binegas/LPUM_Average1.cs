using System;

class Average1 {
    	static void Main() {
        	int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        	Console.Write("Unsorted: ");
        	PrintArray(arr);

        	int[] sorted_arr = MergeSort(arr);
        	Console.Write("\nSorted: ");
        	PrintArray(sorted_arr);
    	}

    	static void PrintArray(int[] arr) {
        	for (int i = 0; i < arr.Length; i++) {
            		Console.Write($"{arr[i]} ");
        	}
    	}

    	static int[] MergeSort(int[] arr) {
        	if (arr.Length <= 1)
            		return arr;

        	int[] left = new int[arr.Length / 2];
        	int[] right = new int[arr.Length - left.Length];
	
        	Array.Copy(arr, 0, left, 0, left.Length);
        	Array.Copy(arr, left.Length, right, 0, right.Length);

        	left = MergeSort(left);
        	right = MergeSort(right);
	
       	 	return Merge(left, right);
    }

    	static int[] Merge(int[] left, int[] right) {
        	int[] result = new int[left.Length + right.Length];
        	int i = 0, j = 0, k = 0;

        	while (i < left.Length && j < right.Length) {
            		if (left[i] < right[j])
                		result[k++] = left[i++];
            		else
                		result[k++] = right[j++];
       		}

        	while (i < left.Length)
            		result[k++] = left[i++];

        	while (j < right.Length)
            		result[k++] = right[j++];

        	return result;
    	}
}