using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadatak faktorijel
            Console.WriteLine("Unesite neki broj: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int faktorijel = 1;

            for (int i = 1; i <= input; i++)
            {
                faktorijel = faktorijel * i;
            }

            Console.WriteLine("faktorijel je: " + faktorijel);
            

            //zadatak random broj
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("pick number between 1-10: ");
                int number = Convert.ToInt32(Console.ReadLine());

                var random = new Random().Next(10);
                Console.WriteLine("random broj je: " + random);

                if (number == random)
                {
                    Console.WriteLine("you won");
                    break;
                }
                else
                {
                    Console.WriteLine("you lost");
                }
            }
            

            //liste
            var numbers = new List<int>() { 1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {7,8,9});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("index of number 1: " + numbers.IndexOf(1));
            Console.WriteLine(" last index of number 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("number of items " + numbers.Count);

            
            Console.WriteLine("unesite neko ime: ");
            var ime = Console.ReadLine();
            Console.WriteLine(ime);

            char[] nameCharArray = ime.ToCharArray();

            Array.Reverse(nameCharArray);
            string reversedName = new string(nameCharArray);
            Console.WriteLine(reversedName);
            
        }
    }
}
