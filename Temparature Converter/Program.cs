using System;

namespace Temparature_Converter
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temparature converter ");
            Console.WriteLine("Please enter what do you want to convert");
            Console.WriteLine("C/F or F/C");


            string C = "C/F";
            string F = "F/C";


            int cel, far;

            var input3 = Console.ReadLine();

            if (input3== C)
            {
                Console.WriteLine("Please enter the number to convert into fahrenheit");
                Console.WriteLine("");

                cel = int.Parse(Console.ReadLine());

                far = (cel * 9 )/ 5 + 32;

                Console.WriteLine("Your result is:" + far +"F*");
                

                Console.ReadLine();

            }

            else if (input3 == F)
            {
                Console.WriteLine("Please enter the number to convert into Celcius");
                Console.WriteLine("");

                far = int.Parse(Console.ReadLine());

                cel = (far - 32) * 5 / 9; 

                Console.WriteLine("Your result is:" + cel + "C*");

                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
