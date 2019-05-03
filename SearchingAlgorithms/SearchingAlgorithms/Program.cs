using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Program
    {
        static int[] nums = new int[101];
        static void Main(string[] args)
        {
            ArrayPop();
            Array.Sort(nums);
            //Linear();
            Binary();
        }

        static void ArrayPop()
        {
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100, 999);
                Console.WriteLine(nums[i]);
            }
        }
        static void Linear()
        {            
            Console.Write("I can check if a number is in the array\nPlease enter a number (100 - 999): ");
            if (Searching<int>(nums, int.Parse(Console.ReadLine())))
                Console.WriteLine("\nYour number was found in the collection");
            else
                Console.WriteLine("\nYour number wasn't found in the collection");

            Console.WriteLine("Press Enter To End");
            Console.ReadLine();
        }

        static bool Searching<T>(T[] arr, T val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }

        static void Binary()
        {
            
            Console.Write("\n\nPlease enter a number to search for: ");
            int input = int.Parse(Console.ReadLine());            
            /*Search for the number and give a response*/
            if (Find(nums, input))
                Console.WriteLine("\nWe have found the number " + input + " in the collection...");
            else
                Console.WriteLine("\nWe could not find the number " + input + " in the collection...");

            Console.WriteLine("Press Enter To End");
            Console.ReadLine();
        }

        static bool Find(int[] arr, int val)
        {
            /*Create and set the ncessary variables.*/
            int upper, mid, lower;
            upper = arr.Length;
            lower = 0;
            /*Continue looping until the lower point is moved above the upper point, then break.*/
            while (lower <= upper)
            {
                /*Set the mid point*/
                mid = lower + (upper - lower) / 2;
                /*If the mid point value is the one we are looking for return true*/
                if (arr[mid] == val)
                    return true;
                /*If the value is less than the mid point move the top down so we can seach in the bottom half*/
                else if (val < arr[mid])
                    upper = mid - 1;
                /*If the value is more than the mid point move the bottom up so we can seach in the top half*/
                else
                    lower = mid + 1;
            }
            /*If the value isn't found return false*/
            return false;
        }
    }
}
