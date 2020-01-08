using System;
using System.Collections.Generic;
using System.Text;

namespace petdoge
{
    class bush : IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }

        public string species => "Bush";

        public void feedthepet()
        {
            Console.WriteLine("No");
        }

        public void petthepet()
        {
            Console.WriteLine("Poke");
        }

        public void walkthepet()
        {
            Console.WriteLine("No");
        }
    }
}
