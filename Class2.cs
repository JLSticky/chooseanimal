using System;
using System.Collections.Generic;
using System.Text;

namespace petdoge
{
    public class Petowner:IPetowner
    {
        public string name { get; set; }
        public int age { get; set; }

        public void talktopet()
        {
            Console.WriteLine();

        }
    }
}
