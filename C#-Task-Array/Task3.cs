using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task_Array
{
    public class Task3
    {
        public static void DisplayCars()
        {
            string[] cars = new string[] { "Nissan", "Supra", "Lexus" ,"Toyota"};
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("The array length is: "+cars.Length);
        }
    }
}
