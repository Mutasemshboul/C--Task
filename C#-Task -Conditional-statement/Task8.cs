using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task8
    {
        
        public static void CalculateLength()
        {
            string[] strings =
            {
                "Mutasem ALi Shboul",
                "Jonathan Edward Smith",
                "Isabella Grace Martinez",
                "Michael Thomas Brown",
                "Charlotte Emily Wilson"
            };

            foreach (string s in strings)
            {
                Console.WriteLine(s + " The Length: " + s.Length);
            }
        }
   
    }
}
