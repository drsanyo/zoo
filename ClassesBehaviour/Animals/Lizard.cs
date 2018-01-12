using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Lizard : Reptile
    {
        public Lizard(int age) : base(age)
        {
        }

        public override string SpreadTheSound()
        {
            var sound = "I am Lizzzard... ";
            Debug.WriteLine(sound);
            return sound;
        }
    }
}
