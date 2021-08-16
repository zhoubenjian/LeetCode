using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"一共有：{ClimbingStairs.GoUpstairs(10)}种方式");
                Console.WriteLine($"一共有：{RobotMove.UniquePath(7, 3)}种走法");
                
                string str1 = "Boss";
                string str2 = "Boat";
                Console.WriteLine($"{str1}与{str2}的最短编辑距离：{StringDiff.MinEditDistance(str1, str2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}