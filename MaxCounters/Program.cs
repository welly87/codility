namespace MaxCounters
{
    using System;
    // you can also use other imports, for example:
    // using System.Collections.Generic;
    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            var counters = new int[N];
            int max = 0;
            int resetLimit = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    //counters[A[i] - 1]++;

                    if (counters[A[i] - 1] < resetLimit)
                    {
                        counters[A[i] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        counters[A[i] - 1]++;
                    }

                    max = Math.Max(max, counters[A[i] - 1]);
                }
                else
                {
                    resetLimit = max;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(resetLimit, counters[i]);
            }

            return counters;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var result = new Solution().solution(5, new[] { 3, 4, 4, 6, 1, 4, 4 });
            var result = new Solution().solution(1, new[] { 1, 1, 1 });
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
