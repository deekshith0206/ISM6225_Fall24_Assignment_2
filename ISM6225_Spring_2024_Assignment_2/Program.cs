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

                // Create two lists to separate even and odd numbers
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        evens.Add(num);  // Add even numbers to the evens list
                    }
                    else
                    {
                        odds.Add(num);   // Add odd numbers to the odds list
                    }
                }

                // Combine the two lists, with evens first and then odds
                evens.AddRange(odds);

                return evens.ToArray();


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
                // using the built-in method
                return Convert.ToString(decimalNumber, 2);

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
                int left = 0, right = nums.Length - 1;

                while (left < right)
                {
                    // Find the middle index
                    int mid = left + (right - left) / 2;

                    // If the middle element is greater than the rightmost element, the minimum is in the right half
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    // Otherwise, it's in the left half (including mid)
                    else
                    {
                        right = mid;
                    }
                }

                return nums[left];
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
                // Negative numbers are not palindromes
                if (x < 0) return false;

                int original = x;
                int reversed = 0;

                // Reverse the number by repeatedly extracting the last digit
                while (x != 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;
                }

                return original == reversed;

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
                // Base cases: F(0) = 0 and F(1) = 1
                if (n <= 1) return n;

                // Variables to store the two previous Fibonacci numbers
                int a = 0, b = 1;

                // Loop to calculate Fibonacci number iteratively
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                return b;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
