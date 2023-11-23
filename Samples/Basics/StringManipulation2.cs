using System;

class Program {
    public static void Main() {
        //Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
        string input;

        Console.Write("Enter string: ");
        input = Console.ReadLine();

        string result = input.Substring(0, 1) + input + input.Substring(0, 1);
        Console.WriteLine(result);
    }
}