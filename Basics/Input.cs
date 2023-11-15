using System;

class Program {
    public static void Main() {
        //Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
        int num1, num2, num3;

        Console.Write("Enter num1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter num3: ");
        num3 = int.Parse(Console.ReadLine());

        int result = num1 * num2 * num3;
        Console.WriteLine($"Result: {num1} * {num2} * {num3} = {result}");
        
    }
}