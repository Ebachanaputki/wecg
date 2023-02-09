using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dnmes = double.Parse(Console.ReadLine());
            double prden = double.Parse(Console.ReadLine());
            double dolar = double.Parse(Console.ReadLine());
            double msz = dnmes * prden;
            double gdo = (msz * 12) + (msz * 2.5);
            double dn = gdo / 4;
            double cdn = gdo - dolar;
            double dnsr  = cdn / 365 ;
            Console.WriteLine(dnsr);
        }
    }
}
