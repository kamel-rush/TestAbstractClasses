using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> ShapeList = new List<Shape>();
            ShapeList.Add(new Rectangle(2, 2));
            ShapeList.Add(new Rectangle(5,5));
            ShapeList.Add(new Rectangle(5,8));
           

            ShapeList.Sort();

            foreach (Shape item in ShapeList)
            {
                Console.WriteLine(item.GetArea());
            }
            
        }
    }
}
