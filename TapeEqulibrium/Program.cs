using System;
using System.Runtime.Remoting.Messaging;


namespace TapeEqulibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var sols = new int[] {3, 1, 2, 4, 3};
            var result = new Solution().solution(sols);
            Console.WriteLine(result);
        }
    }

    // you can also use other imports, for example:
    // using System.Collections.Generic;
    class Solution
    {
        public int solution(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            int left = 0;
            //int right = sum;
            int min = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                left += A[i];
                //right -= A[i];

                var diff = 2 * left - sum;

                var absDiff = diff < 0 ? -diff : diff;

                if (min > absDiff)
                {
                    min = absDiff;
                }
            }

            return min;
        }
    }

}
