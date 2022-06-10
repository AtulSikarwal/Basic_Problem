using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class Alp_Vowel_Consonant
    {
        public void Vowel_Consonant()
        {
            Console.WriteLine("check whether the input alphabet is a vowel or not ");
            Console.WriteLine("input an Alphbet (A-Z and a-z)");
            char Str = Convert.ToChar(Console.ReadLine().ToLower());

            switch(Str)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is Consonant");
                    break;
            }

        }
    }
}

