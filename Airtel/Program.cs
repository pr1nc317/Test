namespace Airtel
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 100, 3, 2, 5, 9, 8, 0 };
            MergeSort(input);
        }

        static void MergeSort(int[] arr)
        {
            int n = arr.Length;

            // base condition
            if (n == 1) return;

            //creating left and right arrays
            int[] left = new int[n / 2];
            int[] right = new int[n - n / 2];

            for (int i = 0; i < n / 2; i++)
            {
                left[i] = arr[i];
            }
            for (int i = n / 2; i <= n - 1; i++)
            {
                right[i - n / 2] = arr[i];
            }

            // Recursive Calls
            MergeSort(left);
            MergeSort(right);

            // Merge the result
            Merging(left, right, arr);
            //Console.Read();
        }

        public static void Merging(int[] left, int[] right, int[] finalArray)
        {
            int i = 0, j = 0, k = 0;

            while(i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    finalArray[k] = left[i];
                    i++;
                }
                else
                {
                    finalArray[k] = right[j];
                    j++;
                }
                k++;
            }
            while (j < right.Length)
            {
                finalArray[k] = right[j];
                j++;
                k++;
            }
            while (i < left.Length)
            {
                finalArray[k] = left[i];
                i++;
                k++;
            }
        }
    }
}
