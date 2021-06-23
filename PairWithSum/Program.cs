using System;
using System.Collections.Generic;

namespace PairWithSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = PairWithSum(5, new List<int>() { 4, 6, 1, 9, -4 });

            // Need to show the result better.
            Console.WriteLine(result);
        }

        // Assuming no duplicates in integers.
        public static List<Tuple<int, int>> PairWithSum(int sum, List<int> nums)
        {
            if (nums.Count < 2) return new List<Tuple<int, int>>();

            nums.Sort();

            var result = new List<Tuple<int, int>>();
            int left = 0;
            int right = nums.Count - 1;

            while (true)
            {
                if (left == right) break;
                if (left >= nums.Count ||  right < 0) break;

                int candidate = nums[left] + nums[right];

                if (candidate == sum)
                {
                    result.Add(new Tuple<int, int>(nums[left], nums[right]));
                    left++;
                    right++;
                }

                if (candidate < sum)
                {
                    left++;
                }
                else
                {
                    right--;
                }                
            }

            return result;
        }
    }
}
