using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Triangle : Shape
    {
        private float TBase, height;

        public Triangle(float b, float height)
        {
            TBase1 = b;
            this.Height = height;
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public float TBase1
        {
            get
            {
                return TBase;
            }

            set
            {
                TBase = value;
            }
        }

        public  float GetArea()
        {
            return 0.5f * TBase1 * Height; 
        }
    }
}
