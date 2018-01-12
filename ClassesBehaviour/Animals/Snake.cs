using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Snake : Reptile
    {
        public Snake(int age) : base(age)
        {
        }

        public override string SpreadTheSound()
        {
            var sound = "I am ssssssnakee... sssss...";
            Debug.WriteLine(sound);
            return sound;
        }
    }
}
