using System;
using System.Collections.Generic;
using System.Text;

namespace petdoge
{
    class Cat : IAnimal



    {
        public string name { get; set; }
        public int age { get; set; }


        public string species => "Cat";

        public void feedthepet()
        {
            Console.WriteLine("MunchMunchMunch");
        }

        public void petthepet()
        {
            Console.WriteLine("PurrPurrPurr");
        }

        public void walkthepet()
        {
            Console.WriteLine("No");
        }
    }
}
