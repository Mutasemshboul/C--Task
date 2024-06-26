using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task_Array
{
    public class Task5
    {
        public static void DisplayArray()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element-: " + i+" ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
