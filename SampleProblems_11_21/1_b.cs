// 1. Write a method that checks if given number (positive integer) contains digit 3.
// Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

using System;

class Program {
    static void Main() {
        int num = 1234;
        bool result = Contains3(num);
        Console.WriteLine(result);
    }

    static bool Contains3(int num) {
        while(num > 0) {
            num /= 10;
            if(num%10 == 3) {
                return true;
            }
        }
        return false;
    }
    
}
