using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çarpma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc = 0;

            Console.Write("1. sayıyı gir: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gir: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi2; i++) {
                sonuc += sayi1;
            }

            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sonuc);
            Console.ReadLine();
        }
    }
}