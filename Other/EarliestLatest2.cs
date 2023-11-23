using System;

class Program {
    static void Main() {
        int n = 5;
        int first_player = 1;
        int second_player = 5;

        // int n = 11;
        // int first_player = 2;
        // int second_player = 4;

        int[] result = getEarliestLatest(n, first_player, second_player);

        Console.WriteLine($"{result[0]} {result[1]}");
    }

    static int[] getEarliestLatest(int n, int first_player, int second_player) {
        int[] result = {n,1};

        int round_req = 0;
        if(n % 2 == 0)
            round_req = n/2;
        else
            round_req = (n-1)/2;

        int[] left = getEarliestLatest(n, first_player, second_player, result, 1, true, 0, round_req);
        int[] right = getEarliestLatest(n, first_player, second_player, result, 1, false, 0, round_req);

        return getBestResult(result, left, right);
    }

    static int[] getEarliestLatest(int n, int first_player, int second_player, int[] result, int round, bool left_wins, int count, int round_req) {
        
        if(count == round_req) {
            round++;
            if(n % 2 == 0)
                round_req = n/2;
            else
                round_req = (n-1)/2;
            count = 0;
        }

        if((first_player == n+1-second_player || n<=2) && count == 0) {
            int[] new_result = {round, round};
            return new_result;
        }


        if(left_wins) {
            first_player--;
            second_player--;
        }
        n--;
        count++;

        int[] left = getEarliestLatest(n, first_player, second_player, result, round, true, count, round_req);
        int[] right = getEarliestLatest(n, first_player, second_player, result, round, false, count, round_req);

        //for debug only
        Console.WriteLine($"{count} {round} LEFT: {result[0]} {result[1]}");
        Console.WriteLine($"{count} {round} RIGHT: {result[0]} {result[1]}");


        return getBestResult(result, left, right);
    }

    static int[] getBestResult(int[] result, int[] left, int[] right) {
        result[0] = Math.Min(result[0], Math.Min(left[0], right[0]));
        result[1] = Math.Max(result[1], Math.Max(left[1], right[1]));
        return result;
    }



}