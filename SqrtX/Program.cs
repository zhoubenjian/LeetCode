using System;

/*** 平方根的近似值 ***/
namespace SqrtX
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(binarybSearch(8));
                Console.WriteLine((int)Newton(99));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        /// <summary>
        /// 两分查找
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int binarybSearch(int x)
        {
            int index = -1, l = 0, r = x;
            while (l <= r)
            {
                int mid = (r - l) / 2 + l;
                if (mid * mid < x)
                {
                    index = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return index;
        }


        /// <summary>
        /// 牛顿迭代法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Newton(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return Sqrt(x, x);
        }

        public static double Sqrt(double i, int x)
        {
            double res = (x / i + i) / 2;
            if (res != i)
            {
                return Sqrt(res, x);
            }
            else
            {
                return res;
            }
        }
    }
}