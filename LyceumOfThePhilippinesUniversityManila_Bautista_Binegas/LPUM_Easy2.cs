//Write a C# program that copies the contents of one text file to another. Prompt the user to enter the paths for the source
//and destination files.
using System;
using System.IO;

class Easy2 {
    public static void Main() {
	Console.Write("Enter the source file path: ");
        string source = Console.ReadLine();

	Console.Write("Enter the destination file path: ");
        string destination = Console.ReadLine();
	
	try {
		string content = File.ReadAllText(source);
		File.WriteAllText(destination, content);

		Console.WriteLine("File copied successfully");
	} catch {
		Console.WriteLine("Error: File cannot be copied");		
	}
    }
}