using System;

namespace sum_of_array
{
    class sum
    {
        static void Main(string[] args)
        {
            int n, s = 0;
            int[] arr = new int[50];
            Console.WriteLine("Enter the elements to be stored in an array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of an array");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                s = s + arr[i];
            }
            Console.WriteLine("Sum of the array elements is:"+s);
            Console.ReadLine();
        }
    }
}
