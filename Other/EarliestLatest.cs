using System;

class Program {
    static void Main() {
        int n = 11;
        int first_player = 2;
        int second_player = 4;
        int[] result = {0,0};

        result = getEarliestLatest(n, first_player, second_player, result);

        Console.WriteLine($"{result[0]} {result[1]}");
    }

    static int[] getEarliestLatest(int n, int first_player, int second_player, int[] result) {

        if(first_player > second_player) {
            int temp = first_player;
            first_player = second_player;
            second_player = temp;
        }

        int diff = n-second_player - (first_player - 1);
        int max_change = (n-1)/2;
        int effective_change = 0;
        if (max_change % 2 == 0)
            effective_change = max_change/2;
        else
            effective_change = (max_change+1)/2;

        Console.WriteLine($"n: {n} first_player: {second_player} second_player: {first_player} Diff: {diff} Max Change: {max_change} Effective Change: {effective_change}");

        

        if(diff == 0)
            return result;

        // if(n%2 == 0)
        //     n /= 2;
        // else
        //     n = (n+1)/2;

        return result;
        // return getEarliestLatest(n, first_player-1, second_player+1, result);
    }

}