using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5, s6;

            Console.Write("1. sayı : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayı : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayı : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4. sayı : ");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. sayı : ");
            s5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("6. sayı : ");
            s6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} + {1} + {2} + {3} + {4} + {5} = {6}", s1, s2, s3, s4, s5, s6, s1+s2+s3+s4+s5+s6);
            Console.ReadKey();  
        }
    }
}