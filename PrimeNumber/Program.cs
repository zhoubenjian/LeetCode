using System;

/*** 素数个数 ***/
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Bs(100));
                Console.WriteLine(Eratosthenes(10));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// 暴力搜索
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Bs(int num)
        {
            int count = 0;
            for (int i = 2; i <= num; i++)
            {
                count += Prime(i) ? 1 : 0;
            }
            return count;
        }
        
        /// <summary>
        /// 质数判断
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool Prime(int n)
        {
            for (int i = 2; i * i <= n; i++)        // i^2 <= n 
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 埃筛法（埃拉托色尼质数筛选法）
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Eratosthenes(int num)
        {
            bool[] flag = new bool[num];        // 默认：合数——false
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (!flag[i])
                {
                    count++;
                    for (int j = 2 * i; j < num; j+=i)
                    {
                        flag[j] = true;
                    }
                }
            }
            return count;
        }
    }
}