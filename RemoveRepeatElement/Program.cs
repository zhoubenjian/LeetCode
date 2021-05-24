using System;
using System.Linq;

/*** 数组元素去重 ***/
namespace RemoveRepeatArayElements
{
    class Program
    {
        /// <summary>
        /// 移除数组中的相同元素（双指针算法）（仅限于有序排列数组）
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int RemoveRepeat(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            // i:慢指针
            int i = 0;    
            // j:快指针
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            
            return i + 1;
        }
        
        
        static void Main(string[] args)
        {
            try
            {
                int[] nums = new[] {-1, 0, 0, 1, -3, 1, -1};
                // 排序
                nums = nums.OrderBy(t => t).ToArray();
                int count = RemoveRepeat(nums);
                Console.WriteLine($"{count}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}