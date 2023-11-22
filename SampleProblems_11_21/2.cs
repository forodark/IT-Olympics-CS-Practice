// Given a non-empty string, write a method that returns it in compressed format.
// Expected input and output
// CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"
// CompressString("p555ppp7www") → "p153p371w3"

using System;

static class String {
    public static string Compress(string newString) {
        char currentCharacter = newString[0];
        string output = "";
        

        int i = 0, count = 0;
        while (true) {
            if (i >= newString.Length)
                break;
            if (newString[i] != currentCharacter) {
                output += currentCharacter.ToString();
                output += count.ToString();
                currentCharacter = newString[i];
                count = 0;
            }
            count++;
            i++;
        }
        
        return output;
    }
}
class Program {
    static void Main() {
        Console.WriteLine(String.Compress("kkkktttrrrrrrrrrr"));
    }

}