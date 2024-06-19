using System;
using System.Collections;



namespace ConsoleApp
{
    public static class Harray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool LinearSearch(int[] input, int item)
        {
            foreach (int i in input)
            {
                if (i == item)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool LinearSearch2(int[] input, int item)
        {
            //int[] myarray = Array.FindAll(input, element => element == item);
            //Array.ForEach(myarray, Console.WriteLine);

            return item == Array.Find(input, element => element == item);

        }

        /// <summary>
        /// Divide and Conquer Method. Split the Array into half and search from first or second half.
        /// Assumption -> given array is sorted.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool BinarySearch(int[] input, int item)
        {
            int min = 0;
            int max = input.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item == input[mid])
                {
                    return true;
                }
                else if (item < input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return false;
        }

        /// <summary>
        /// Finding Even numbers in the array and returning new array with only Even numbers.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            //TODO:
            ArrayList result = [];

            foreach (int i in arr1)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);
                }
            }
            foreach (int i in arr2)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);
                }
            }

            return (int[])result.ToArray(typeof(int));

            //Approach 2
            //arr1.Concat(arr2).ToArray();
            //Array.Sort(arr1);


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        /// <summary>
        /// Shift the array to left such that 0 goes to -1 and n goes to n-1 indices.
        /// Since -1 is out of index exception. Shift the 0th index to nth index.
        /// </summary>
        /// <param name="input"></param>
        public static int[] ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            return input;
        }
    }
}
