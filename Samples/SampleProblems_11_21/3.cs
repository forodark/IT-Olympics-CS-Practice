// 3. Given a string, write a method that checks if it is a palindrome. String length may be >= 0.
// Expected input and output
// IsPalindromeRecursion("xx") → true
// IsPalindromeRecursion("pendrive") → false

using System;

class Program {
    static void Main() {
        Console.WriteLine(IsPalindromeRecursion("racecar"));
        Console.WriteLine(IsPalindromeRecursion("aibohphobia"));
    }

    static bool IsPalindromeRecursion(string input) {
        if(input.Length == 0)
            return true;
        if(input[0] != input[input.Length-1])
            return false;
        if(input.Length > 3)
            return IsPalindromeRecursion(input.Substring(1, input.Length-2));
        return true;
    }

}