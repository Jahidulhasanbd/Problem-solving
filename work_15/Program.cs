using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "My Name is jahidul hasan hridoy";

            //Console.WriteLine("Original string: " + input);

            //int vowelCount = 0;
            //int consonantCount = 0;

            //// Iterate through each character in the string
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char currentChar = input[i];

            //    // Check if the character is a letter
            //    if ((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z'))
            //    {
            //        // Check if the letter is a vowel
            //        if ("AEIOUaeiou".IndexOf(currentChar) != -1)
            //        {
            //            vowelCount++;
            //        }
            //        else
            //        {
            //            consonantCount++;
            //        }
            //    }
            //}

            //Console.WriteLine("Vowel count: " + vowelCount);
            //Console.WriteLine("Consonant count: " + consonantCount);

            string input = "jahidul hasan hridoy";

            int vowelCount = 0;
            int consonantCount = 0;

            for(int i=0; i<input.Length; i++)
            {
                char alphabet = input[i];
                if((alphabet>='a' && alphabet<='z')||(alphabet >='A' && alphabet <= 'Z'))
                {
                    if(("AEIOUaeiou").IndexOf(alphabet) != -1)
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    } 

                }
               
            }
            Console.WriteLine("vowel Count is "+vowelCount);
            Console.WriteLine("Consonant Count is "+consonantCount);

            Console.ReadKey();
        }
    }
}