using System;

class WaterJugs {
    static void Main() {
        int[] red = {1,3,5,2,4};
        int[] blue = {5,2,3,1,4};

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

        int random = new Random().Next(low, high+1);

        int pivot = arr[random];

        int i = low-1;

        for(int j = low;j <= high; j++) {
            if(arr[j] <= pivot) {
                i++;

                swap(ref arr[i], ref arr[j]);
            }
        }
        swap(ref arr[i+1], ref arr[random]);
        
        return i+1;
    }

    static void sort(ref int[] red, ref int[] blue, int low, int high) {

        if (low < high) {
            int pivot = partition(ref red, low, high);
            partition(ref blue, low, high);

            sort(ref red, ref blue, low, pivot-1);
            sort(ref red, ref blue, pivot+1, high);
        }
    }

    static void swap(ref int x, ref int y) {
        int temp = x;
        x = y;
        y = temp;
    }
}