// Given a non-empty string, write a method that returns it in compressed format.
// Expected input and output
// CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"
// CompressString("p555ppp7www") → "p153p371w3"

using System;

class Program {
    static void Main() {
        Console.WriteLine(Compress("aaabbbccca"));

    }

    static string Compress(string input) {
        string output = "";
        output = output + input[0].ToString() + Count(input, input[0], 0);
        for(int i = 0; i < input.Length-1; i++) {
            char tracking_char = input[i+1];
            if (input[i] != tracking_char || i == input.Length - 1) {
                output = output + tracking_char.ToString() + Count(input, tracking_char, i);
            }
        }
        return output;
    }

    // static string Compress(string input)
    // {
    //     string output = "";
    //     int count = 1;
        
    //     for (int i = 0; i < input.Length; i++)
    //     {
    //         if (i + 1 < input.Length && input[i] == input[i + 1])
    //         {
    //             count++;
    //         }
    //         else
    //         {
    //             output += input[i] + count.ToString();
    //             count = 1;
    //         }
    //     }
        
    //     return output;
    // }

    static int Count(string input, char target, int starting_index)
    {
        int count = 0;
        bool found = false;
        // Iterate through each character in the string
        for (int i = starting_index; i < input.Length; i++)
        {
            // Check if the character is equal to the target character
            if (input[i] == target)
            {
                // Increment the count if a match is found
                found = true;
                count++;
            }
            else if (found) {
                break;
            }
        }
        // Return the final count
        return count;
    }

}