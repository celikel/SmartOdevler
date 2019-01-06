using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, toplam = 0;

            do {
                Console.Write("Sayı girin: ");
                s = Convert.ToInt32(Console.ReadLine());
                toplam += s;
            } while (s != -1);

            Console.Write("Toplam: {0}", toplam);
            Console.ReadKey();
        }
    }
}