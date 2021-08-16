using System;

/*** 最短编辑距离 ***/
namespace DynamicProgramming
{
    public class StringDiff
    {
        public static int MinEditDistance(string str1, string str2)
        {
            // 保存历史数据
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];
            
            // 初始化
            for (int i = 0; i <= str1.Length; i++)
            {
                dp[i, 0] = i;
            }
            for (int j = 0; j <= str2.Length; j++)
            {
                dp[0, j] = j;
            }
            
            // 通过关系式来计算出 dp[m, n]
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    int flag = (str1[i - 1] == str2[j - 1] ? 0 : 1);
                    dp[i, j] = MinDistance(
                        dp[i - 1, j] + 1,             // 删除
                        dp[i, j - 1] + 1,             // 添加
                        dp[i - 1, j - 1] + flag       // 替换
                        );
                }
            }
            
            return dp[str1.Length, str2.Length];
        }

        public static int MinDistance(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}