using System;

namespace words_string
{
    class Words_string
    {
        static void Main(string[] args)
        {
            int i = 0, count = 1;
            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            while(i<=str.Length-1)
            {
                if(str[i]==' ' || str[i]=='\n'|| str[i]=='\t')
                {
                    count = count + 1;
                }
                i++;
            }
            Console.WriteLine("Total number of words in a string is:"+count);
            Console.ReadLine();
        }
    }
}
