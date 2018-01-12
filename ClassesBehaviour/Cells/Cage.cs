using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.Cells
{
    public abstract class Cage
    {
        private Animal animal = null;
        public bool IsAnimal { get { return animal != null; } }

        public void PutAnimal(Animal animal)
        {
            if (this.animal == null)
            {
                this.animal = animal;
                this.animal.PutAnimalToCell();
            }
            else
            {
                throw new ArgumentException("Cannot put animal while another is inside!");
            }
        }

        public void OpenDoor()
        {
            if (IsAnimal)
            {
                animal = null;                
                Debug.WriteLine("Animal broke away!");
            }
            else
            {
                Debug.WriteLine("Nothing happened, no animal inside.");
            }
        }

        public string ShowAnimal()
        {
            string result = string.Empty;
            if (IsAnimal)
            {
                if (animal is Mammal)
                {
                    result = string.Format("Animal's name is: {0}, age is: {1}, coat type is: {2} and type is: {3}",
                        animal.Name, animal.Age.ToString(), (animal as Mammal).Coat.ToString(), animal.GetType().ToString());
                }
                else
                {
                    result = string.Format("Animal's name is: {0}, age is: {1}, skin color is: {2} and type is: {3}",
                        animal.Name, animal.Age.ToString(), (animal as Reptile).SkinColor.ToString(), animal.GetType().ToString());
                }
            }
            else
            {
                result = "Cage is empty";
            }

            Debug.WriteLine(result);
            return result;
        }
    }
}
