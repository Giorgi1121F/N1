using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    class Program
    {


        static public void Main()
        {
            int s = 7;
            Console.WriteLine("cdebis raodenoba = " + countWays(s));
            Console.ReadLine();
        }
        public static int k(int n)
        {
            if (n <= 1)
                return n;
            return k(n - 1) + k(n - 2);
        }
        public static int countWays(int s)
        {
            return k(s + 1);
        }
    }
}

// c k(n-K) m-n_

