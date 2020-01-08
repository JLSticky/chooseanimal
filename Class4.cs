using
    System;
using System.Collections.Generic;
using System.Text;

namespace petdoge
{
    class Walrus : IAnimal

    {
        public string name { get; set; }
        public int age { get; set; }


        public string species => "Walrus";

        public void feedthepet()
        {
            Console.WriteLine("MunchMunchMunch");
        }

        public void petthepet()
        {
            Console.WriteLine("ArrArrArr");
        }

        public void walkthepet()
        {
            Console.WriteLine("FlopFlopFlop");
        }
    }
}
