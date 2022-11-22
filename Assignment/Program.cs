using System;

namespace count_of_even_and_odd
{
    class C_odd_even
    {
        static void Main(string[] args)
        {
            int cnteven = 0;
            int cntodd = 0;
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    cnteven = cnteven + 1;
                }
                else
                {
                    cntodd = cntodd + 1;
                }
            }
            Console.WriteLine("Count of Even numbers in an array is:"+cnteven);
            Console.WriteLine("Count of Odd numbers in an array is:" + cntodd);
            Console.ReadLine();
        }
    }
}
