using System;

namespace FrogJump
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().solution(10, 85, 30);
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            double distance = Math.Abs((X * 1.0) - Y);
            
            return (int)Math.Ceiling(distance / D);
        }
    }

}
