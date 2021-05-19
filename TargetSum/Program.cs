using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetSum
{
    class Program
    {
        /// <summary>
        /// 两数之和 -> 暴力算法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }
            return new int[] {0};
        }

        
        /// <summary>
        /// 字典求解
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();        // [值：索引]
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new[] {dic[target - nums[i]], i};
                }
                dic.Add(nums[i], i);
            }
            return new[] {0};
        }

        
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution3(int[] nums, int target)
        {
            int low, high;
            int mid = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                low = i;
                high = nums.Length - 1;
                while (low <= high)
                {
                    mid = (high - low) / 2 + low;
                    if (nums[i] == target - nums[mid])
                    {
                        return new[] {i, mid};
                    } 
                    else if (nums[i] < target - nums[mid])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return new[] {0};
        }


        /// <summary>
        /// 双指针算法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution4(int[] nums, int target)
        {
            int l = 0, h = nums.Length - 1;
            while (l <= h)
            {
                if (nums[l] + nums[h] == target)
                {
                    return new[] {l, h};
                }
                else if (nums[l] + nums[h] > target)
                {
                    h--;
                }
                else if (nums[1] + nums[h] < target)
                {
                    l++;
                }
            }
            return new[] {0};
        }
        
        
        static void Main(string[] args)
        {
            try
            {
                int[] nums = new[] {1, 2, 3, 4, 5, 6};
                int[] res = Solution4(nums, 10);
                    // Solution3(nums, 10);
                    // Solution2(nums, 10);
                    // Solution1(nums, 10);
                    
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}