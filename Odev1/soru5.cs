using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;

            Console.Write("1. öğrencinin notunu gir: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. öğrencinin notunu gir: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. öğrencinin notunu gir: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4. öğrencinin notunu gir: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. öğrencinin notunu gir: ");
            n5 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Notların ortalaması : {0}", (n1 + n2 + n3 + n4 + n5) / 5);
            Console.ReadKey();
        }
    }
}