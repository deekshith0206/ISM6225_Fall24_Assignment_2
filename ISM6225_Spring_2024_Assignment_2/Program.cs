using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Create a list to store the missing numbers
                List<int> missingNumbers = new List<int>();

                // Use a hash set to store all unique numbers in the array
                HashSet<int> numSet = new HashSet<int>(nums);

                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!numSet.Contains(i))
                    {
                        missingNumbers.Add(i);  // Add missing numbers to the result list
                    }
                }
                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Initialize a result array with the same length as nums
                int[] result = new int[nums.Length];

                // Two pointers: one for the beginning (for evens), one for the end (for odds)
                int evenIndex = 0, oddIndex = nums.Length - 1;

                // Loop through the input array
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0) // Even numbers
                    {
                        result[evenIndex++] = nums[i];  // Place even numbers at the front
                    }
                    else // Odd numbers
                    {
                        result[oddIndex--] = nums[i];   // Place odd numbers at the back
                    }
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Dictionary to store each number and its index in the array
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];

                    // If the complement is already in the dictionary, return the indices
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }
                    // Otherwise, store the current number and its index in the dictionary
                    map[nums[i]] = i;
                }
                // Return an empty array if no solution is found (this shouldn't happen in valid cases)
                return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // First, sort the array
                Array.Sort(nums);

                // Maximum product can be either:
                // 1. Product of the three largest numbers
                // 2. Product of the two smallest numbers (if negative) and the largest number
                int n = nums.Length;
                int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
                int product2 = nums[0] * nums[1] * nums[n - 1];

                return Math.Max(product1, product2);


            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                return "101010"; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                return false; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
