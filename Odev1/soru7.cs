using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakter;
            byte[] numara;
            string k = "abcdefgh";
            int toplam = 0;

            karakter = k.ToCharArray();
            numara = System.Text.Encoding.UTF8.GetBytes(karakter);

            for (int i = 0; i < karakter.Length; i++) {
                Console.WriteLine(numara[i]);
                toplam += numara[i];
            }
            
            Console.WriteLine("Toplam = {0}", toplam);
            Console.ReadKey();
        }
    }
}