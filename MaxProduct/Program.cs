using System;
using System.Linq;

/*** 获取数组中最大的三个元素乘积 ***/
namespace MaxProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] nums = {2, 3, 1, 5, 4};
                Console.WriteLine(Sort(nums));
                Console.WriteLine(Iterator(nums));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        /// <summary>
        /// 数组中三个最大数的乘积
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Sort(int[] nums)
        {
            // 排序（必须）
            nums.OrderBy(t => t);

            int length = nums.Length;
            return Math.Max(nums[0] * nums[1] * nums[length - 1], nums[length - 3] * nums[length - 2] * nums[length - 1]);
        }


        /// <summary>
        /// 迭代查找
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Iterator(int[] nums)
        {
            // 排序（必须）
            nums.OrderBy(t => t);
            int max1 = Int32.MinValue, max2 = Int32.MinValue, max3 = Int32.MinValue;
            int min1 = Int32.MaxValue, min2 = Int32.MaxValue;

            foreach (var num in nums)
            {
                if (num > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (num > max3)
                {
                    max3 = num;
                }

                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                } 
                else if (num < min2)
                {
                    min2 = num;
                }
                
            }
            return Math.Max(min1 * min2 * max1, max3 * max2 * max1);
        }
    }
}