using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        static void Main(string[] args)
        {
        }
        public static bool ArrayCmp(int []arr1,int []arr2)
        {
            if (arr1.Length != arr2.Length) return false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] minusNums = nums;
            int[] answer = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < minusNums.Length; j++)
                {
                    if (j >= i) break;
                    if (minusNums[j] == nums[i])
                    {
                        answer[0] = j;
                        answer[1] = i;
                        return answer;
                    }
                }
                minusNums[i] = target - nums[i];
            }
            return nums;
        }
    }
}
