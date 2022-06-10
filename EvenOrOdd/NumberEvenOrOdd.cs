using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class NumberEvenOrOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter the Number :");
            int Num=Convert.ToInt32(Console.ReadLine());
            while (Num < 0)
            {
                Console.WriteLine("please enter vaild input above 0 ");
                Num=Convert.ToInt32(Console.ReadLine());
            }
            if(Num % 2 == 0)
            {
                Console.WriteLine("Number is Even");

            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
