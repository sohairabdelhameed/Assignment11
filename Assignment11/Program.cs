using System;
using System.Text;

namespace Assignment11
{
    internal class Program
    {
        #region BubbleSortMethod
        static void OptimizedBubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                    break;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Question01
            //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst
            //and average cases, which makes it inefficient for large datasets.
            //How we can optimize the Bubble Sort algorithm?
            //Answer: 
            //To optimize the Bubble Sort algorithm, one common improvement is to introduce a flag that detects
            //whether any elements were swapped during the iteration.
            //If no elements were swapped, the list is already sorted, and the algorithm can terminate early.
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //And implement the code of this optimized bubble sort algorithm

            //int[] array = { 94, 33, 25, 17, 29, 16, 90 };
            //Console.WriteLine("Unsorted array:");
            //Console.WriteLine(string.Join(", ", array));

            //OptimizedBubbleSort(array);

            //Console.WriteLine("Sorted array:");
            //Console.WriteLine(string.Join(", ", array));



            #endregion

            #region Question02
            //create a generic Range<T> class that represents a range of values from a
            //minimum value to a maximum value.The range should support basic
            //operations such as checking if a value is within the range and
            //determining the length of the range.

            var intRange = new Range<int>(5, 10);
            Console.WriteLine($"Is 7 in range (5 to 10)? {intRange.IsInRange(7)}");
            Console.WriteLine($"Length of range (5 to 10): {intRange.Length()}");

            var doubleRange = new Range<double>(1.5, 5.5);
            Console.WriteLine($"Is 3.5 in range (1.5 to 5.5)? {doubleRange.IsInRange(3.5)}");
            Console.WriteLine($"Length of range (1.5 to 5.5): {doubleRange.Length()}");
            #endregion
        }
    }
}
