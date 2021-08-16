using System;

/*** 一阶动态规划问题 ***/
namespace DynamicProgramming
{
    /*** 爬楼梯问题 ***/
    public class ClimbingStairs
    {
        public static int GoUpstairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            
            // 保存历史记录
            int[] dp = new int[n + 1];
            
            // 赋初值
            dp[1] = 1;
            dp[2] = 2;
            
            // 通过关系式来计算出 dp[n]
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            
            return dp[n];
        }
    }
}