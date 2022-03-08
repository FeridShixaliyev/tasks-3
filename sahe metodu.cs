using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesablamaq istediyiniz fiquru secin:");            
            Console.WriteLine("1 - Cevrenin sahesi:");
            Console.WriteLine("2 - Duzbucaqlinin sahesi:");
           
            
            Console.Write("Fiqur: ");

            string sahe;
            sahe = Console.ReadLine();
            switch (sahe)
            {
                case "1":
                    Console.WriteLine("Cevrenin sahesi : " + CevreSahesi());
                    break;
                case "2":
                    Console.WriteLine("Duzbucaqlinin sahesi: " + DuzbucaqliSahesi());
                    break;              
                   
                default:
                    Console.WriteLine("Fiqur duzgun daxil edilmeyib:");
                    break;
            }

           


            static int CevreSahesi()
            {
                int sahe;
                Console.Write("Cevrenin radiusu daxil edin: ");
                int r;
                r = Convert.ToInt32(Console.ReadLine());
                int p = 3;
                sahe = p * r * r;
                return (sahe);
            }


            static int DuzbucaqliSahesi()
            {
                Console.Write("Duzbucaqlinin enini daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Duzbucaqlinin uzunluqunu daxil edin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int Sahe;
                Sahe = a * b;
                return (Sahe);
            }

        }  
    }
}