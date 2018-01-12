using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public abstract class Reptile : Animal
    {
        public Color SkinColor { get; set; }

        public Reptile(int age) : base(age)
        {
        }
    }
}
