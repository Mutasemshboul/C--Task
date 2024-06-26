using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task3
    {
        public static void SortArray()
        {
            

            Console.WriteLine("Enter First num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Thaird num");
            int num3 = Convert.ToInt32(Console.ReadLine());


            int maxNum=num1;
            int middleNum= num1;
            int minNum = num1;

            if (maxNum < num2)
            {
                maxNum = num2;
            }
            if(maxNum < num3)
            {
                maxNum = num3;
            }

            if(minNum > num2)
            {
                minNum = num2;
            }
            if (minNum > num3)
            {
                minNum = num3;
            }


            if (num2 > minNum && num2 < maxNum)
            {
                middleNum = num2;
            }

            if (num3 > minNum && num3 < maxNum)
            {
                middleNum = num3;
            }

            int[]arr = {maxNum,middleNum,minNum};
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}
