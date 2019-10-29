using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle
    {
        private double radius;
        private String color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double r, string c1)
        {
            radius = r;
            color = "red";
        }
        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return radius * radius * 3.14;
        }

        public string GetColor()
        {
            return color;
        }
    }
}
