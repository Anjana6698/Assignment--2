using System;

namespace negative_element
{
    class negative
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[100];
            int[] array = new int[100];
            Console.WriteLine("Enter the elements to be stored in an array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Negative numbers in an array:");
            for(int i=0;i<n;i++)
            {
                if(arr[i]<0)
                {
                    array[i]= arr[i];
                    Console.WriteLine(array[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
