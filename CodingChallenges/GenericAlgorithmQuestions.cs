using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public static class GenericAlgorithmQuestions
    {
        // Finds the lowest positive number not in the list.
        // Solution is in O(n) time and O(n) space;
        public static int findLowestPositiveNumberNotInList(int[] nums)
        {
            HashSet<int> foundNums = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                foundNums.Add(nums[i]);
            }
            int lowestNum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!foundNums.Contains(lowestNum))
                {
                    return lowestNum;
                }
                lowestNum++;
            }
            return lowestNum;
        }
    }
}
