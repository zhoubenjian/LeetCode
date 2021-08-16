using System;

/*** 二维动态规划问题 ***/
namespace DynamicProgramming
{
    /*** 机器人运动问题 ***/
    public class RobotMove
    {
        public static int UniquePath(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return 0;
            }
            
            // 保存历史数据
            int[,] dp = new int[m + 1, n + 1];

            // 初始化
            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 1;
            }
            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = 1;
            }
            
            // 通过关系式来计算出 dp[m, n]
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            
            return dp[m, n];
        }
    }
}