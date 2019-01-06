using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, R;

            Console.Write("Akım değerini gir: ");
            I = Convert.ToInt32(Console.ReadLine());
            Console.Write("Direnç değerini gir: ");
            R = Convert.ToInt32(Console.ReadLine());

            Console.Write("V = {0} volt", I * R);
            Console.ReadKey(); 
        }
    }
}