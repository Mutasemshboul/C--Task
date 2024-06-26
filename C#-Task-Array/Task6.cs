using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task_Array
{
    public class Task6
    {
        public static void summation()
        {
            int[] nums = new int[3];
            int summ =0 ;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter The Number "+i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
                summ += nums[i];
            }
            Console.Write("The Summation: " + summ + " ");

        }
    }
}
