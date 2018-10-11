using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoberProgQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA;
            string strB;
            bool isAnagram = true;

            Console.WriteLine("Please enter a word: ");
            strA = Console.ReadLine();
            Console.WriteLine("Please enter another word: ");
            strB = Console.ReadLine();
            foreach (char item in strA)
            {
                if (strB.Contains(item) == false)
                {
                    isAnagram = false;
                    break;
                }
            }
            Console.WriteLine(isAnagram);


            Console.ReadKey();

        }
    }
}
