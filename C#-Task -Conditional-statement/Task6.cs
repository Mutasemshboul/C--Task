using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task6
    {
        public static void CalculateTime()
        {
            Console.WriteLine("Enter Hours: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a minuts: ");
            int minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total: "+((hour*60)+minuts));
        }
    }
}
