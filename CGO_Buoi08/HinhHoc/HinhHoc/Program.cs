using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    internal class Program
    {
        public class Shape
        {
            private string color = "green";
            private bool filled = true;

            public Shape() { }

            public Shape(string color,bool filled) {
            this.color = color;
            this.filled = filled;
            }

            public string getColor()
            {
                return color;
            }
            public void setColor(string color)
            {
                this.color = color;
            }
            public bool getFilled() {
                return filled;
            }
            public void setFilled(bool filled) {  
                this.filled = filled;
            }

            public override string ToString()
            {
                return "A Shape with color of "+ color+" and " + (getFilled()?"filled":"not filled");
            }
        }
        // lớp circle kế thừa shape
        public class Circle : Shape
        {
            private float radius = 1;

            public Circle() { }

            public Circle(string color,bool filled,float radius):base(color,filled) {
            this.radius = radius;
            }
            public float getRadius()
            {
                return radius;
            }
            public void setRadius(float radius)
            {
                this.radius=radius;
            }
            public double GetArea()
            {
                return radius * radius * Math.PI;
            }

            public double GetPerimeter()
            {
                return 2 * radius * Math.PI;
            }
            public override String ToString()
            {
                return "A Circle with radius ="+getRadius()+ ", which is a subclass of "+base.ToString();

            }
        }
        // lớp rectangle kế thừa shape
        public class Rectangle : Shape
        {
            private float width = 1;
            private float height = 1;

            public Rectangle() { }

            public Rectangle(float width, float height)
            {
                this.width = width;
                this.height = height;
            }

            public Rectangle(string color,bool filled,float width, float height):base(color,filled) 
            {
                this.width = width;
                this.height = height;
            }

            public float getWidth()
            {
                return width;
            }
            public virtual void setWidth(float width)
            {
                this.width = width;
            }
            public float getHeight()
            {
                return height;
            }
            public virtual void setHeight(float height)
            {
                this.height=height;
            }

            public float getArea()
            {
                return width * height;
            }
            public float getPerimeter()
            {
                return (width+height)*2;
            }
            public override string ToString()
            {
                return "A Rectangle with width= " +getWidth()+ "and length= "+getHeight()+", which is a subclass of "+base.ToString();
            }
        }

        //lớp square kế thừa rectangle
        public class Square : Rectangle

        {

            public Square()

            {

            }

            public Square(float side) : base(side,side)

            {

            }

            public Square(string color, bool filled,float side) : base(color, filled,side,side)

            {

            }

            public double getSide()

            {

                return getWidth();

            }

            public void SetSide(float side)

            {

                setWidth(side);

                setHeight(side);

            }

            public override void setWidth(float width)

            {

                SetSide(width);

            }

            public override void setHeight(float height)

            {

                SetSide(height);

            }

            public override String ToString()
            {
                return "A Square with side ="+getSide()+ ", which is a subclass of "+base.ToString();
            }

        }
        static void Main(string[] args)
        {
            Square square = new Square();

            Console.WriteLine(square);

            square = new Square(2);

            Console.WriteLine(square);

            square = new Square("yellow", true,5);

            Console.WriteLine(square);
            Console.ReadKey();
        }
    }
}
