// Given a non-empty string, write a method that returns it in compressed format.
// Expected input and output
// CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"
// CompressString("p555ppp7www") → "p153p371w3"

using System;

class Program {
    static void Main() {
        Console.WriteLine(Compress("kkkktttrrrrrrrrrra"));
    }

    static string Compress(string input) {
        string output = "";
        char tracking_char = input[0];
        int count = 0;
        Console.WriteLine(input);
        Console.WriteLine(input.Length);

        for(int i = 1; i < input.Length; i++) {
            if (input[i] != tracking_char || i == input.Length - 1) {
                count++;
                output = output + tracking_char.ToString() + count.ToString();
                tracking_char = input[i];
                // Console.WriteLine(count + " test " + i);
                count = 0;
                continue;
            }
            if (tracking_char == input[input.Length - 1] && i == input.Length - 1) {
                output = output + tracking_char.ToString() + (++count).ToString();
                break;
            }
            count++;
        }

        return output;
    }

}