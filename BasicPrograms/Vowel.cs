using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Vowel
    {
        public void VowelOrConsonant()
        {
            char ch;
            Console.Write("\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("\n");

            Console.Write("Enter The Alphabet Between (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
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

