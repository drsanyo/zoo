using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Dog : Mammal
    {
        public Dog(int age) : base(age)
        {
        }

        public override string SpreadTheSound()
        {
            var sound = "bark bark";
            Debug.WriteLine(sound);
            return sound;
        }
    }
}
