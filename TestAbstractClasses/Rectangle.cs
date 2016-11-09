using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Rectangle: Shape
    {   // if you use an abstract class, then use the override
        //public override  float GetArea() 
        //{
        //    return Width * Height;
        //}

        public float GetArea()
        {
            return Width * Height;
        }

        public int CompareTo(object obj)
        {
            Rectangle rect2 = (Rectangle)obj;

            float Area1 = this.GetArea();
            float Area2 = rect2.GetArea();

            if (Math.Abs(Area1 - Area2) < .00000000000000001)
            {
                return 0;
            }
            else
            {
                if (Area1 < Area2) return -1;
                else
                    return 1; 

            }
            
            
             
        }

        private float width, height;

        public Rectangle(float width, float height)
        {
            this.Width = width;
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

        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }
    }
}
