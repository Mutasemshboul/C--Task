using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task__Conditional_statement
{
    public class Task9
    {
        public static void reverseOdd()
        {
            string s = Console.ReadLine();

            string[] ssize = s.Split(null);

            foreach (string s2 in ssize)
            {
                if (s2.Length % 2 != 0)
                {
                    for (int i = s2.Length - 1; i >= 0; i--)
                    {
                        Console.Write(s2[i]);
                    }
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(s2+" ");
                }
            }

        }
    }
}
