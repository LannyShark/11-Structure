using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Equality equality = new Equality(3,-9);
            equality.Root();
            Console.ReadKey();
        }
    }
    struct Equality
    {
        public double B { get; set; }
        public double K { get; set; }
        public Equality(double k = 1, double b = 0)
        {
            K = k;
            B = b;
        }
        public void Root()
        {
            if (K == 0 && B == 0)
            {
                Console.WriteLine("x - любое число");
                return;
            }
            else if (K == 0)
            {
                Console.WriteLine("Решений нет");
                return;
            }
            else
            {
                double x = (-B / K);
                Console.WriteLine("x = {0:f}",x);
                return;
            }
        }
    }
}
