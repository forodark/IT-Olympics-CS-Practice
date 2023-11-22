// 1. Write a method that checks if given number (positive integer) contains digit 3.
// Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

using System;

static class Digit3 {
    public static bool ContainsThree(int number) {
        // Handle negative numbers by taking their absolute value
        int num = Math.Abs(number);

        // Check each digit by successively dividing by 10 and checking remainders
        while (num > 0)
        {
            int currentDigit = num % 10; // Get the rightmost digit 123 % 10 = 3
            if (currentDigit == 3)
            {
                return true; // Digit found
            }

            // Remove the rightmost digit from the number
            num /= 10;
        }

        return false; // Digit not found in the number
    }
};

class Program {
    static void Main() {
        // bool result = Contains3(1234);
        // Console.WriteLine(result);

        Console.WriteLine(Digit3.ContainsThree(1224));
    }

    // static bool Contains3(int num) {
    //     for(int i = 0; i < 4; i++) {
    //         int test = ((num/Math.Pow(10,i))-3);
    //         Console.WriteLine(test);
    //         if(((num/Math.Pow(10,i))-3)%10 == 0) {
    //             return true;
    //         }
    //     }
    //     return false;
    // }
    
}