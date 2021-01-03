using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            
            string str1= "(abc(aab(k_)))";
            Console.WriteLine(isProperly(str1));
            Console.ReadLine();
        }

        public static Boolean isProperly(string a) {
            bool w = false ;
            int num1 = 0;
            int num2 = 0;
            char m = '(';
            char n = ')';
            char[] b = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            //სიმბოლოების დათვლა განაწილება
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == m) num1++;
                else if (b[i] == n) num2++;
                else continue;

            }
            //შედარება
            if (num2 - num1 == 0)
            {
                Console.WriteLine("gamosaxuleba sworia");
                w = true;
            }
            else if (num2 - num1 > 0)
            {
                Console.WriteLine("zedmeti ) simbolo");
                w = false;
            }
            else
            {
                Console.WriteLine("zedmeti ( simbolo");
                w = false;
            }
            return w;
        }
    }
}
