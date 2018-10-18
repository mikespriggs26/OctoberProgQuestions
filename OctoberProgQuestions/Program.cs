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
            //*************************************************
            //Mini-Max Sum
            //Find the minimum and maximum values by summing four of five integers

            //int[] arr = new int[] { 1, 2, 3, 4, 5, };
            //int arrSum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
            //int minSum = arrSum;
            //int maxSum = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int counter = 0;
            //    int testSum = arrSum - arr[counter];
            //    counter++;
            //    if (testSum > maxSum)
            //    {
            //        maxSum = testSum;
            //    }
            //    if(testSum < minSum)
            //    {
            //        minSum = testSum;
            //    }
            //    Console.WriteLine(testSum);

            //}
            //Console.WriteLine(minSum + " = minSum");
            //Console.WriteLine(maxSum + " = maxSum");
            //Console.ReadKey();

            //***********************************
            //Time Conversion - convert string to military time
            //string time = "11:05:45AM";
            //char a = time[0];
            //char b = time[1];
            //char c = time[8];   
            //char d = time[9];
            //string segment = time.Substring(2, 6);
            //string str = a.ToString() + b.ToString();
            //string ampm = c.ToString() + d.ToString();
            //int hours = int.Parse(str);

            //if (ampm == "PM")
            //{
            //    hours += 12;
            //}
            //if(ampm == "AM" && hours == 12)
            //{
            //    hours = 0;
            //}
            //string hour = hours.ToString();
            //string result = hour + segment;

            //Console.WriteLine(result);

            //Climbing the Leaderboard
            //int[] scores = new int[] { 100, 100, 50, 40, 40, 20, 10 };
            //int[] alice = new int[] { 5, 25, 50, 120 };

            //var uniqueScores = new List<int>();

            //var hashset = new HashSet<int>();
            //int counter = 1;
            //foreach (var item in scores)
            //{
            //    if (hashset.Add(item))
            //    {
            //        uniqueScores.Add(item);

            //    }
            //}

            //foreach (var item in alice)
            //{
            //    foreach (var score in uniqueScores)
            //    {
            //        if (score > item)
            //        {
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine(counter);
            //    counter = 1;
            //}

            // Check to see if a number is an Armstrong number
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



            //Produces all Armstrong numbers between 1 and 1000
            //int numa = 0;
            //int numab = 0;
            //int numb = 0;
            //int numc = 0;

            //for (int i = 100; i < 1000; i++)
            //{
            //    numc = i % 10;//last digit 1
            //    numab = i / 10;//first two digits  37
            //    numb = numab % 10; //middle digit 7
            //    numa = numab / 10;//first digit

            //    if(numa * numa * numa + numb * numb * numb + numc * numc * numc == i)
            //    {
            //        Console.WriteLine(i + " is an Armstrong number");
            //    }

            //*****************************************
            //Plus-minus
            //For a array, it will produce the percentage of +#s, -#s and zeros contained within

            //int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            //float posCounter = 0;
            //float negCounter = 0;
            //float zeroCounter = 0;
            //foreach (var item in arr)
            //{
            //    if (item == 0)
            //    {
            //        zeroCounter += 1;
            //    }
            //    else if(item > 0)
            //    {
            //        posCounter += 1;
            //    }
            //    else if(item < 0)
            //    {
            //        negCounter += 1;
            //    }

            //}
            //Console.WriteLine(posCounter/arr.Length);
            //Console.WriteLine(zeroCounter/arr.Length);
            //Console.WriteLine(negCounter/arr.Length);

            //*************************************
            //Staircase
            //int n = 4;
            //for (int row = 0; row < n; row++)
            //{
            //    for (int i = 1; i < n - row; i++)
            //    {
            //        Console.Write(" ");

            //        //Console.WriteLine();
            //    }
            //    for (int column = n - row; column <= n; column++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


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
