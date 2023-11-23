using System;

class WaterJugs {
    static void Main() {
        int[] red = {5,2,3,1,4};
        int[] blue = {1,3,5,2,4};

        sort(ref red, ref blue, 0, red.Length-1);

        printArray(red);
        printArray(blue);
    }

    static void printArray(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static int partition(ref int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j <= high - 1; j++) {
            if (arr[j] <= pivot) {
                i++;
                swap(ref arr, i, j);
            }
        }
        swap(ref arr, i + 1, high);
        
        return i + 1;
    }

    static void sort(ref int[] red, ref int[] blue, int low, int high) {

        if (low < high) {
            int red_pivot = partition(ref red, low, high);
            int blue_pivot = partition(ref blue, low, high);

            sort(ref red, ref blue, low, red_pivot - 1);
            sort(ref red, ref blue, red_pivot + 1, high);

            sort(ref red, ref blue, low, blue_pivot - 1);
            sort(ref red, ref blue, blue_pivot + 1, high);
        }
    }



    static void swap(ref int[] arr, int a, int b) {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}