using System;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = new Solution().solution(new int[] { 4, 1, 3, 2 });
            var result = new Solution().solution(new int[] { 4, 1, 3 });
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            bool[] memo = new bool[A.Length + 1];


            foreach (var i in A)
            {
                if (i > A.Length) return 0;

                if (memo[i]) return 0;

                memo[i] = true;
            }

            return 1;
        }
    }
}
