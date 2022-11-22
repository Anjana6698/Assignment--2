using System;

namespace diagonal
{
    class diagonal
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[,] array = new int[3, 3]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9},
            };
            Console.WriteLine("Diagonals are:");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i==j)
                    {
                        Console.WriteLine(array[i, j] + " ");
                        total = total + array[i, j];
                    }
                }
            }
            Console.WriteLine("\nSum of diagonal elements are:"+total);
            Console.ReadLine();
        }
    }
}
