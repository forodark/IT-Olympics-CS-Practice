//Given an unsorted integer array, find a triplet with a given sum in it. For example,
//nums = [ 2, 7, 4, 0, 9, 5, 1, 3 ] target = 6 Output: Triplet exists.

using System;

class Program {
    static void Main() {
        int[] nums = { 2, 7, 4, 0, 9, 5, 1, 3 };
        int target = 22;

        Console.WriteLine(isTripletExist(nums, target));
        Console.WriteLine(isTripletExist2(nums, nums.Length, target, 0));
    }

    static bool isTripletExist(int[] nums, int target) {
        for(int i = 0; i<nums.Length; i++) {
            for(int j = 0; j<nums.Length; j++) {
                for(int k = 0; k<nums.Length; k++) {
                    bool is_unique = (i != j && i != k && j != k);
                    int total = nums[i] + nums[j] + nums[k];
                    if(is_unique && total == target)
                        return true;
                }
            }
        }
        return false;
    }

    static bool isTripletExist2(int[] nums, int n, int target, int count) {
        
        if(count == 3 && target == 0) 
            return true;

        if(count == 3 || n == 0 || target < 0)
            return false;

        return isTripletExist2(nums, n-1, target - nums[n-1], count+1) || isTripletExist2(nums, n-1, target, count);


    }
}