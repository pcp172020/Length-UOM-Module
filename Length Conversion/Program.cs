using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            int calculating = int.Parse(Console.ReadLine());
            inches(calculating);
            Console.ReadKey();
        }

        private static void inches(int calculating)
        {
            Console.WriteLine(calculating + " inches = " + 2.54 * calculating + " cm");
            return;
        }

    }

    class CMtoIN
    {
        static void Main(string[] args)
        {
            Console.Write("Centimeters ");
            int calculating = int.Parse(Console.ReadLine());
            centimeters(calculating);
            Console.ReadKey();
        }

        private static void centimeters(int calculating)
        {
            Console.WriteLine(calculating + "centimeters = " + 0.39370 * calculating + " in");
            return;
        }
    }
}
