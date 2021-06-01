using System;

/*** 硬币排列（每行硬币数等于当前行数） ***/
namespace ArrangeCoins
{
    class Program
    {
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ArrangeCoins1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                n = n - i;
                if (n < i + 1)
                {
                    return i;
                }
            }
            
            return 0;
        }


        /// <summary>
        /// 双指针算法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ArrangeCoins2(int n)
        {
            int low = 0, high = n;
            int mid = 0;
            int cost = 0;
            while (low < high)
            {
                mid = (high - low) / 2 + low;
                cost = (1 + mid) * mid / 2;    // 求和公式
                if (cost > n)
                {
                    high = mid - 1;
                }
                else if (cost < n)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            
            return low < high ? low : high;
        } 
        
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{ArrangeCoins1(10)}");
                Console.WriteLine($"**********************");
                Console.WriteLine($"{ArrangeCoins2(10)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}