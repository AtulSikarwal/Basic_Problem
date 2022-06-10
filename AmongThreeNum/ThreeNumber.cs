using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class LargestThreeNumber
    {
        public void ThreeNumber()
        {

            Console.Write("Find the largest of three numbers:\n");
            Console.Write("Input the 1st number :");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (Num2 > Num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");

        }
    }
}
    