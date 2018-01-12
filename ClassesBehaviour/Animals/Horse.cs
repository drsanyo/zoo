using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Horse : Mammal
    {
        public Horse(int age) : base(age)
        {
        }
     
        public override string SpreadTheSound()
        {
            var sound = "I ma horse IHAHA!";
            Debug.WriteLine(sound);
            return sound;
        }
    }
}
