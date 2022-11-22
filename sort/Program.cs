using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp;
            int[] arr = new int[50];
            Console.WriteLine("Enter the number of elements to be stored in an array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in an array");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sorted array is:");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-1;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
