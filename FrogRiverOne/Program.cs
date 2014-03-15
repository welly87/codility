using System;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = new Solution().solution(new int[] { 4, 1, 3, 2 });
            var result = new Solution().solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            var memo = new bool[X + 1];
            
            for (int i = 0; i < A.Length; i++)
            {
                if (memo[A[i]]) continue;

                memo[A[i]] = true;

                X--;

                if (X == 0) return i;
            }

            return -1;
        }
    }
}
