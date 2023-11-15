using System;

class Program {
    public static void Main() {
        //Write a C# program to create a new string from a given string where the first and last characters change their positions.
        string input;

        Console.Write("Enter string: ");
        input = Console.ReadLine();

        string result = input.Substring(input.Length - 1) + input.Substring(1, input.Length - 2) + input.Substring(0, 1);
        Console.WriteLine(result);
    }
}