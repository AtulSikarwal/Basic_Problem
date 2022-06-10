using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class Swap
    {
        public void SwapNumber()
        {
            int Temp = 0;
            Console.Write("\nInput the First Number : ");
           int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
          int  Number2 = Convert.ToInt32(Console.ReadLine());
            Temp = Number1;
            Number1 = Number2;
            Number2 = Temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + Number1);
            Console.Write("\nSecond Number : " + Number2);
            Console.Read();
        }
    }
}

