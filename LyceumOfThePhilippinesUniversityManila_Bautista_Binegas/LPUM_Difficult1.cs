//You are to print numbers from 01 to NN, but instead of numbers which are multiples of 3 the word Fizz should be printed - and instead of multiples of 5 - the word Buzz. If the value is the multiple of both 

using System;

class Difficult1 {
    public static void Main() {
	Console.WriteLine("Input number: ");
        int input = int.Parse(Console.ReadLine());
	
	if (input <= 0)
		Console.WriteLine("Invalid input. Positive integers only");


	for(int i = 1; i <= input; i++) {
		string output = "";
		
		if(i % 3 == 0)
			output += "Fizz";
		if(i % 5 == 0)
			output += "Buzz";
		
		if(output != "")
			Console.Write($"{output} ");
		else
			Console.Write($"{i} ");	
	}
    }
}