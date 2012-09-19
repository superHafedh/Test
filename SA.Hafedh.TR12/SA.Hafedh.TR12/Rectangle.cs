using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.Hafedh.TR12
{
    class Rectangle: Shape
    {
        private float _x, _y;

        public Rectangle(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public override float GetArea()
        {
            return _x*_y;
        }
    }
}
