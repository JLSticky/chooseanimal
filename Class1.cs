using System;
using System.Collections.Generic;
using System.Text;


namespace petdoge
{
    public class dog:IAnimal

    {
        public string name { get; set; }
        public int age { get; set; }
        public string species => "Dog";

        public void feedthepet()
        {
            Console.WriteLine("Doge: MunchMunchMunch SlurpSlurpSlurp");
        }

        public void petthepet()
        {
            Console.WriteLine("Doge: WoofWoof");
        }

        public void walkthepet()
        {
            Console.WriteLine("Doge: WalkWalkWalk PissPissPiss PoopPoopPoop");
        }
    }
}
