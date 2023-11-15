using System;

class Program {
    public static void Main() {
        //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
        int num1, num2;

        Console.Write("Enter num1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Results:");
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        Console.WriteLidfne($"{num1} - {num2} = {num1-num2}");
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        Console.WriteLine($"{num1} % {num2} = {num1%num2}");
        
    }
}