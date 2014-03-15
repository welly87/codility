using System;
using System.Collections.Generic;
using System.Text;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().solution(new int[] { 2, 3, 1, 5 });
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            long sum = 0;
            
            for (long i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            long length = A.Length;

            long total = (length + 2) * (length + 1) / 2;
            
            //Console.WriteLine(total);

            return (int)(total - sum);
        }
    }

}
