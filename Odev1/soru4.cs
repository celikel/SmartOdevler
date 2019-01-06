using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Sayı gir: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 2) {
                Console.WriteLine("Bu sayı asal bir sayı değildir.");
                Console.ReadLine();
            }
            else {
                for (int i = 2; i <= sayi / 2; i++) {
                    if (sayi % i == 0) {
                        Console.WriteLine("Bu sayı asal bir sayı değildir.");
                        Console.ReadLine();
                        return;
                    }
            }
                Console.WriteLine("Bu sayı asal bir sayıdır.");
                Console.ReadLine();
            }
        }
    }
}