using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task_Array
{
    public class Task4
    {
        public static void DisplayUserInfo()
        {
            Console.WriteLine("Enter Your First Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Enter Your Birth Date: ");
            string birthDate = Console.ReadLine();

            Console.WriteLine($"{fName} {lName} {birthDate}");

        }
    }
}
