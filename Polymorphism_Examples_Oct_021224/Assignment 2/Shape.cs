using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Examples_Oct_021224.Assignment_2
{
    public class Shape
    {
        virtual public void Draw()
        {
            Console.WriteLine("Draw From Shape Class");
        }
    }
    public class Circle:Shape
    {
      override public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
    public class Rectangle:Shape
    {
      override  public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}
