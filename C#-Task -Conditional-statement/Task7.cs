using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task7
    {
        public static void CalculateTimeInHours()
        {

            Console.WriteLine("Enter a minuts: ");
            int minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( minuts/60+ " Hours "+minuts%60+" Minuts");
        }
    }
}
