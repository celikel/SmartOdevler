using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt, üst, sayaç = 0;

            Console.Write("Alt aralığı gir: ");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üst aralığı gir: ");
            üst = Convert.ToInt32(Console.ReadLine());
            
            for (int i = alt; i <= üst; i++) {
                if (i%10 == 0) {
                    Console.WriteLine(i);
                    sayaç++;
                }
            }
            if (sayaç == 0) {
                Console.Write("Girdiğiniz aralıkta 5 tam bölünen çift sayı yoktur.");
            }
            Console.ReadKey();
        }
    }
}