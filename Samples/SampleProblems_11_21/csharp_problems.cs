using System;

class Program {

    static void Main() {

        Console.WriteLine(isPrime(1232219999));


    }

    // static bool isPrime2(int num) {
    //     if(num == 1 || num == 2 || num == 3)
    //         return true;
    //     if((num-1)%6 == 0 || (num+1)%6 == 0)
    //         return true;
    //     return false;
    // }

    static bool isPrime(int num) {
        while(true) {
            for(int i = 2; i < num/2; i++) {
                if(num%i == 0) {
                    return false;
                }
            }
            return true;
        }
    }

    // static bool isPrime3(int num) {
    //     int new_num = 0;
    //     while(num > 0) {
    //         new_num += num%10;
    //         num /= 10;
    //     }
        
    //     if(new_num % 2 == 0)
    //         return false;
    //     return true;
    // }

}