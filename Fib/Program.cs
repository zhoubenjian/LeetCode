using System;
using System.Diagnostics;

namespace Fib
{
    class Program
    {
        /// <summary>
        /// 暴力递归
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Calculate1(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }

            return Calculate1(num - 1) + Calculate1(num - 2);
        }


        /// <summary>
        /// 去重递归
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Calculate2(int num)
        {
            int[] arr = new int[num + 1];
            return Recursion(arr, num);
        }

        public static int Recursion(int[] arr, int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }

            if (arr[num] != 0)
            {
                return arr[num];
            }

            arr[num] = Recursion(arr, num - 1) + Recursion(arr, num - 2);
            return arr[num];
        }


        /// <summary>
        /// 双指针算法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int TwoPointMethod(int num)
        {
            int low = 0, high = 1;
            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                sum = low + high;
                low = high;
                high = sum;
            }
            
            return sum;
        }
        
        
        static void Main(string[] args)
        {
            try
            {
                // 暴力递归
                Console.WriteLine($"{Calculate1(10)}");
                
                // 去重递归
                Console.WriteLine("{0}", Calculate2(10));
                
                // 双指针算法
                Console.WriteLine($"{TwoPointMethod(10)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}