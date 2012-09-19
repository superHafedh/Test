using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.HAFEDH.TR11
{
    sealed class Dog : Animal // cannont be inherited => there is no way to creat the Puppy class
    {
        public Dog(string name)
            : base(name, "Dog")
        {
            // intialise Dog's parameters if any
        }

        public void Walk()
        {
            base.Walk(); // if not overrinding
        }

        public override void Speak()
        {
            Console.WriteLine("Hab Hab ! ^^");
        }


    }
}
