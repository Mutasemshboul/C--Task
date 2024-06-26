using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task1
    {
        public static void SmallerInt()
        {
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("The Smallest is: " + num1);
            }
            else
            {
                Console.WriteLine("The Smallest is: " + num2);
            }


        }
    }
}
