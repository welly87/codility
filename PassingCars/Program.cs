using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingCars
{
    using System;
    // you can also use other imports, for example:
    // using System.Collections.Generic;
    class Solution
    {
        public int solution(int[] A)
        {
            int eastCar = 0;
            int passingCar = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    eastCar++;
                }
                else
                {
                    passingCar += eastCar;
                }
            }

            if (passingCar < 0 || passingCar > 1e9)
                return -1;
            else return passingCar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new []{0, 1, 0, 1, 1}));

        }
    }
}
