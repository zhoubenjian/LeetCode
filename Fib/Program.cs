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
        
        
        static void Main(string[] args)
        {
            try
            {
                // Console.WriteLine($"{Calculate1(10)}");
                Console.WriteLine("{0}", Calculate2(10));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}