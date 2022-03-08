using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(SumArreyelements(1, 2, 3, 4, 5, 7, 8, 9));
        }

        static int SumArreyelements(params int [] arr)
        {
            int total = 0;
            
            foreach(var item in arr)
            {
                total += item;
            }
            return total;
               
        }
    }
}
