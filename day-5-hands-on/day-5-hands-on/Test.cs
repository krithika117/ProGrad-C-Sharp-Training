using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_hands_on
{
    public class Test
    {
        public class Animal {
            public void Category() {
                Console.WriteLine("This is an animal not a bird.");
            }
            
        }

        public class AnimalType : Animal {
            public void Mammal() {
                Console.WriteLine("Inherited Mammal");
            }
            public void Reptile()
            {
                Console.WriteLine("Reptile");
            }
        }
        public class Dogs : AnimalType {
            public void Dog() {
                Mammal();
                Console.WriteLine("Internal bow!");

            }
            public void Mammal()
            {
                Console.WriteLine("External Mammal");
            }

        }



    }
}
