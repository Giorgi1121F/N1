using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sheiyvanet sasurveli tanxa");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(minSplit(a));
            Console.ReadLine();
        }
        public static int minSplit(int amount)
        {
            int x = 0;
            

            while (amount >= 50)
            {
                amount = amount - 50;
                x++;
            }
            while (amount >= 20)
            {
                amount = amount - 20;
                x++;
            }
            while (amount >= 10)
            {
                amount = amount - 10;
                x++;
            }
            while (amount >= 5)
            {
                amount = amount - 5;
                x++;
            }
            x = x + amount;
            return x;
        }


    }
}
