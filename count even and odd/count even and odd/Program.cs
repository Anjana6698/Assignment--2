using System;

namespace count_even_and_odd
{
    class Evenodd
    {
        static void Main(string[] args)
        {
            int odd, even, i;
            odd = 0;
            even = 0;
            int[] array = new int[25]; ;
            Console.WriteLine("Enter the Elements of array");
            int num = Convert.ToInt32(Console.ReadLine()); 
            for (i=0;i<num;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if(array[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even Numbers are", even);
            Console.WriteLine("Odd Numbers are", odd);
            Console.ReadLine();
        }
    }
}
