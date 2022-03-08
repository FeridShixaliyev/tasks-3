using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Word("azerbaycan", 'a'));


        }

        static int Word(string str, char sr)
        {
            int count = 0;
            int i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == sr)
                {
                    count++;
                }

            }
            return count;




        }
    }
}
