using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            int n = 0;

            //Requesting the number of numbers 
            Console.Write("Enter the number of numbers to be displayed: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Showing values
            for (int i = 1; i <= n; i++)
            {
                if(i % 3 != 0 || i % 7 != 0)
                {
                    Console.Write(" {0},", i);
                }
                
            }

            Console.ReadKey();
        }
    }
}
