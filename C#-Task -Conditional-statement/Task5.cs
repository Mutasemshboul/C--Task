using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task5
    {
        public static void KiloToMile()
        {
            Console.WriteLine("Input kilometers per hour: ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            double mile  = kilo * 0.621371;

            Console.WriteLine("Mile : "+mile);
        }
    }
}
