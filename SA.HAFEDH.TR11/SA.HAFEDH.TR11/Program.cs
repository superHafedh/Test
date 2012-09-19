using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.HAFEDH.TR11
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog("Rex"); // Because the Dog type is derrived from the Animal type
            // et non pas l'inverse

            animal.Walk(); // it will call the Dog 's Walk method

            // there's a warning telling that the Dog's Walk method is hiding the Animal one. It's no big deal if we're ovverding it

            // i didn't creat the Puppy class since the Dog class is seaeled and cannot be inherited

            Console.Read();
        }
    }
}
