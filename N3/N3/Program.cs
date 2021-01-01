using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 5,4, 0, 7, 9, 21, -24,2,3, -11 };
            Console.WriteLine(notContains(array1));
            Console.ReadLine();
        }

       public static int notContains(int[] array)
        {
            int k = 0;
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    try
                    {                        
                        if (array[i + 1] - array[i] == 1)
                            continue;
                        else
                        {
                            k = array[i] + 1;                            
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("TestSms");
                    }                    
                }
                
            }
            return k;

        }


    }
}
