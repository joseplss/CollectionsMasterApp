using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var intArray50 = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(intArray50);
            //Print the first number of the array
            Console.WriteLine($"First number of the array is {intArray50[0]}");

            //Print the last number of the array
            Console.WriteLine($"Last number of the array is {intArray50[intArray50.Length -1]}");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter();
            NumberPrinter(intArray50);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            var reversedArray = intArray50;
            ReverseArray(reversedArray);
            NumberPrinter(reversedArray);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(intArray50);
            NumberPrinter(intArray50);
            

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort (intArray50);
            NumberPrinter(intArray50);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var newIntList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(newIntList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(newIntList);

            //Print the new capacity
            Console.WriteLine(newIntList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            //tryParse method
            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    break;
                }
                Console.WriteLine("Invalid entry, try again.");
            }
            NumberChecker(newIntList, userInput);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(newIntList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(newIntList);
            NumberPrinter(newIntList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            newIntList.Sort();
            NumberPrinter(newIntList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] newArray = newIntList.ToArray();

            //Clear the list
            newIntList.Clear();
            Console.WriteLine("List has been cleared. New array was created to store into instead.");
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] %3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }//3rd method

        private static void OddKiller(List<int> numberList)
        {
            for(var i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

        }//6th method

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            var answer = numberList.Contains(searchNumber) ? "Your number was found!" : "Your number was not found";
           Console.WriteLine(answer);
        }//5th method

        private static void Populater(List<int> numberList)//4th method using foreadch
        {
            Random rng = new Random();
            while (numberList.Count <= 50)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            int contNum = 0;
            foreach (int eachInNumbers in numbers)
            {
                numbers[contNum] = rng.Next(0, 50);
                contNum++;
            }

        }//1st method using foreach. CAN ALSO USE FOR

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }//2nd method

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
