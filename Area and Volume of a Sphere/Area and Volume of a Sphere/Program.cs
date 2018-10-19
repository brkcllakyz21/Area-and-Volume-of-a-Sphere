using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Volume_of_a_Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double küre_yarıçapı = 0, alan = 0, hacim = 0;
            Console.WriteLine("Kürenin Yarıçapını Giriniz = ");
            küre_yarıçapı = Convert.ToDouble(Console.ReadLine());

            alan = 4 * Math.PI * (Math.Pow(küre_yarıçapı, 2));
            hacim = (4 / 3) * Math.PI * (Math.Pow(küre_yarıçapı, 3));

            Console.WriteLine("Kürenin Alanı = " + alan);
            Console.WriteLine("Kürenin Hacmi = " + hacim);


        }
    }
}
