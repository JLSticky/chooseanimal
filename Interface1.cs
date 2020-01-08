using System;
using System.Collections.Generic;
using System.Text;

namespace petdoge
{
    public interface IAnimal
    { 

        string name { get; set; }

        int age { get; set; }
        void petthepet();

        void feedthepet();

        void walkthepet();
    }
}
