using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proba2.eCommerce.Program;

namespace Proba2
{
     class Program
    {

        static void Main(string[] args)
        {
            //1. zadatak
            Console.WriteLine("Enter number between 1-10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 0 && number <= 10)
            {
                Console.WriteLine("Valid number!");
            } 
            else 
            {
                Console.WriteLine("Invalid number!");
            }
            

            //2.zadatak
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1)
            {
                Console.WriteLine(number2); 
            }
            else
            {
                Console.WriteLine("numbers are equal");
            }
            

            //zadatak3
            Console.WriteLine("Enter image width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter image height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("it's a landscape");
            }
            else if(height > width)
            {
                Console.WriteLine("it's a portrait");
            }
            else
            {
                Console.WriteLine("it's a square");
            }
            
            //zadatak 4
            Console.WriteLine("Enter speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int demeritPoints = 0;

            if(carSpeed > speedLimit)
            {
                int speedDifference = carSpeed - speedLimit;

                for(int counter = 5; counter <= speedDifference; counter++ )
                {
                    if(counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
            }
            else
            {
                Console.WriteLine("your speed is ok");
            }

            if(demeritPoints > 12)
            {
                Console.WriteLine("License suspended");
            }
        }
    }
}
