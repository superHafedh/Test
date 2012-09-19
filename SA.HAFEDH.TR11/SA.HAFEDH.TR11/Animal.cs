using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.HAFEDH.TR11
{
    class Animal
    {
        string _name;
        string _type;


        public Animal(string name, string type  )
        {
            _name = name;
            _type = type;
        }

        public void Walk()
        {
            // some code
        }

         public virtual void Speak()
         {
             // some code which can be overrided 
         }

    }
}
