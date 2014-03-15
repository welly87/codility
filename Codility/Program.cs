using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Solution
    {
        class Item
        {
            public int obj;
            public int pos;
        }

        public int solution(int[] A)
        {
            var list = new List<int>(A);

            list.Sort();

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            return -99;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.solution(new[] { 1, 4, 3, 3, 1, 2 }));

        }
    }
}
