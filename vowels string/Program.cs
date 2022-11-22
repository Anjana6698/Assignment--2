using System;

namespace vowels_string
{
    class Vowels
    {
        static void Main(string[] args)
        {
            int i = 0, vowels = 0;
            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            for(i=0;i<str.Length;i++)
            {
                if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
                {
                    vowels++;
                }
            }
            Console.WriteLine("Total number of vowels in a string is:{0}",vowels);
            Console.ReadLine();
        }
    }
}
