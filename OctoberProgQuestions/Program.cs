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
            //Checks to see if two strings are anagrams
            //string strA;
            //string strB;
            //bool isAnagram = true;

            //Console.WriteLine("Please enter a word: ");
            //strA = Console.ReadLine();
            //Console.WriteLine("Please enter another word: ");
            //strB = Console.ReadLine();
            //foreach (char item in strA)
            //{
            //    if (strB.Contains(item) == false)
            //    {
            //        isAnagram = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isAnagram);


            //Remove duplicate characters from a string
            //Console.WriteLine("Please enter a word");
            //string userInputB = Console.ReadLine();
            //string userInputMinusDups = "";
            //foreach (char item in userInputB)
            //{
            //    for (int i = 0; i < userInputB.Length; i++)
            //    {
            //        if(!userInputMinusDups.Contains(item))
            //        {
            //            userInputMinusDups += item;

            //        }

            //    }
            //}
            //Console.WriteLine(userInputMinusDups);

            //Check to see if a number is an Armstrong number
            //Console.WriteLine("Please enter a number");
            //string userInputC = Console.ReadLine();
            //int userInputCInt = int.Parse(userInputC);
            //int num1 = int.Parse(userInputC[0].ToString());
            //int num2 = int.Parse(userInputC[1].ToString());
            //int num3 = int.Parse(userInputC[2].ToString());
            //if (num1 * num1 * num1 + num2 * num2 * num2 + num3 * num3 * num3 == userInputCInt)
            //{
            //    Console.WriteLine("Your number is an Armstrong number.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is NOT an Armstrong number.");
            //}

            //Determine if a number is prime or not
            //Console.WriteLine("Please enter a number: ");
            //int userNum = int.Parse(Console.ReadLine());
            //for (int i = 2; i < userNum; i++)   
            //{
            //    if (userNum % i == 0)
            //    {
            //        Console.WriteLine("Your number is not a prime number");
            //        break;
            //    }
            //    if (i == userNum - 1)
            //    {
            //        Console.WriteLine("Your number is a prime number");
            //    }

            //}



            //Find the highest int in an array
            int[] myArray = { 10, 20, 30, 40, 50, 60 };
            int myInt = 0;
            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                if (myArray[i] > myInt)
                {
                    myInt = myArray[i];
                }
            }
            Console.WriteLine("The greatest value is: " + myInt);

            Console.ReadKey();

        }
    }
}
