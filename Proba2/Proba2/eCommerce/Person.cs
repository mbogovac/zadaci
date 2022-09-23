using System;

namespace Proba2.eCommerce
{
    public class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;

            public void Introduce()
            {
                Console.WriteLine("My first name is " + firstName);
                Console.WriteLine("My last name is " + lastName);
            }
        }
    }
}
