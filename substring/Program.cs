using System;

namespace substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            bool m;
            string str1, str2;
            Console.WriteLine("Enter the string");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            str2 = Console.ReadLine();
            m = str1.Contains(str2);
            if(m)
            {
                Console.WriteLine("Substring is present in the string");
            }
            else
            {
                Console.WriteLine("Substring is not present in the string");
            }
            Console.ReadLine();
        }
    }
}
