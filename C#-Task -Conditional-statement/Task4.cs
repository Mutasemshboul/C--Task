using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task4
    {
        public static void MaxNum()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxNum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                }
            }
            Console.WriteLine("The Max number is: "+maxNum);
        }
    }
}
