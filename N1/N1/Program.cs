using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(isPalindrome(text));
            Console.ReadLine();


        }
        public static bool isPalindrome(string text)
        {
            bool k;
            char[] temp1 = text.ToCharArray();
            Array.Reverse(temp1);
            string reversetext = new string(temp1);
            if (text.Equals(reversetext))
                k = true;

            else
                k = false;

            return k;
        }

    }
}
