using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_of_a_certain_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter an Integer : ");
            n = int.Parse(Console.ReadLine());

            string x = Convert.ToString(n, 2);
            int B_D_L;
            Console.WriteLine("Enter The Bit Location : ");
            B_D_L = int.Parse(Console.ReadLine());
            if (B_D_L<=x.Length)
            {
                Console.WriteLine(x[B_D_L-1]);
            }
            else
            {
                Console.WriteLine("0 ," + "This number was stored in {0}  Bits Only :) ", x.Length); 

            }

            Console.ReadKey();

        }
    }
}
