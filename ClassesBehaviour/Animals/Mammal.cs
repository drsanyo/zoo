using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public abstract class Mammal : Animal
    {
        public CoatType Coat { get; set; }

        public Mammal(int age) : base(age)
        {
        }
    }
}
