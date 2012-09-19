using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.Hafedh.TR12
{
    class Square : Shape
    {
        private float _x;

        public Square(float x)
        {
            _x = x;
        }

        public override float GetArea()
        {
            return (float) Math.Pow(_x, 2);
        }
    }
}
