class Program {
    public static void Main() {
        //Swap two values
        int x = 10;
        int y = 5;

        System.Console.WriteLine("Before:");
        System.Console.WriteLine("x: " + x);
        System.Console.WriteLine("y: " + y);

        swap(ref x, ref y);

        System.Console.WriteLine("After:");
        System.Console.WriteLine("x: " + x);
        System.Console.WriteLine("y: " + y);
        
    }

    static void swap(ref int x, ref int y) {
        int temp = x;
        x = y;
        y = temp;
    }
}