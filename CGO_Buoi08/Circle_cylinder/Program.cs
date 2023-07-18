using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_cylinder
{

    public class Circle
    {
        private double radius=1;
        private string color="red";


        public Circle()
        {

        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return radius*radius*Math.PI;
        }

        public override string ToString()
        {
            return "This is a Circel, with radius = "+getRadius()+" color " + getColor() + " Area= " +getArea();
        }
     }
    // class Cylinder keese thừa từ Circle
    public class Cylinder : Circle
    {
        private double height = 1;

        public Cylinder() : base() { }

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }
        public void setHeight(float height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return height * getArea();
        }

        public override string ToString()
        {
            return "This is a Cylinder, with radius = " + getRadius() +" color "+getColor()+ " Volume= " + getVolume();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2,"blue");
            Console.WriteLine(circle);

            Cylinder cylinder = new Cylinder(3,"yellow",2);
            Console.WriteLine(cylinder);

            Console.ReadKey();
        }
    }
}
