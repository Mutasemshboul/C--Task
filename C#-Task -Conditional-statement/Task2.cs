using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task2
    {
        public static void  FindSign()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            char result = (num < 0) ? '-' : '+';
            Console.WriteLine(result);

        }
    }
}
