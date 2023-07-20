using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    internal class Program
    {
        public class Circle
        {
            private double radius = 1;
            private string color = "red";


            public Circle()
            {

            }
            public Circle(double radius)
            {
                this.radius = radius;
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
                return radius * radius * Math.PI;
            }

            public override string ToString()
            {
                return "This is a Circel, with radius = " + getRadius() + " color " + getColor() + " Area= " + getArea();
            }
        }

        public class ComperableCircle : Circle, IComparable<ComperableCircle>
        {

            public ComperableCircle() { }
            public ComperableCircle(double radius) : base(radius) { }
            public ComperableCircle(double radius, string color) : base(radius, color) { }

            public int CompareTo(ComperableCircle o)
            {
                if (getRadius() > o.getRadius()) return 1;
                else if (getRadius() < o.getRadius()) return -1;
                else return 1;
            }
        }
        static void Main(string[] args)
        {
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo");

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadKey();
        }
    }
}
