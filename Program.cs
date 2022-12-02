using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*10. Найти 100 первых простых чисел */

namespace Lab_3_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {                    
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.Write(i + " ");
                }                    
            }
            Console.ReadKey();
        }
    }
}
