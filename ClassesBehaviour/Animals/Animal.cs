using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; }
        public bool IsFree { get; protected set; }

        public Animal(int age)
        {
            Age = age;
            IsFree = true;
        }

        public virtual void FreeAnimal()
        {
            IsFree = false;
        }

        public virtual void PutAnimalToCell()
        {
            IsFree = false;
        }

        public virtual string SpreadTheSound()
        {
            throw new InvalidOperationException("This method should never be called, this is common method!");
            // this will be overrided in childs
        }
    }
}
