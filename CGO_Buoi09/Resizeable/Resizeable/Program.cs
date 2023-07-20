using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizeable
{
    interface ReSizeable
    {
        void Resize(float percent) ;
    }
    public class Shape
    {
        private string color = "green";
        private bool filled = true;

        public Shape() { }

        public Shape(string color, bool filled)
        {
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
        public bool getFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + color + " and " + (getFilled() ? "filled" : "not filled");
        }
    }
    // lớp circle kế thừa shape
    public class Circle : Shape,ReSizeable
    {
        private float radius = 1;

        public Circle() { }

        public Circle(string color, bool filled, float radius) : base(color, filled)
        {
            this.radius = radius;
        }
        public float getRadius()
        {
            return radius;
        }
        public void setRadius(float radius)
        {
            this.radius = radius;
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
            return "A Circle with radius =" + getRadius() + ", which is a subclass of " + base.ToString();

        }

        public void Resize(float percent)
        {
            this.setRadius(radius*percent/100);
        }
    }
    // lớp rectangle kế thừa shape
    public class Rectangle : Shape,ReSizeable
    {
        private float width = 1;
        private float height = 1;

        public Rectangle() { }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(string color, bool filled, float width, float height) : base(color, filled)
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
            this.height = height;
        }

        public float getArea()
        {
            return width * height;
        }
        public float getPerimeter()
        {
            return (width + height) * 2;
        }
        public override string ToString()
        {
            return "A Rectangle with width= " + getWidth() + " and length= " + getHeight() + ", which is a subclass of " + base.ToString();
        }

        public virtual void Resize(float percent)
        {
            setWidth(getWidth()*percent/100);
            setHeight(getHeight()*percent/100);
        }
    }

    //lớp square kế thừa rectangle
    public class Square : Rectangle,ReSizeable

    {

        public Square()

        {

        }

        public Square(float side) : base(side, side)

        {

        }

        public Square(string color, bool filled, float side) : base(color, filled, side, side)

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
        public override string ToString()
        {
            return "A Square with Side= "+ getSide() + ", which is a subclass of " + base.ToString();
        }
        public override void Resize(float percent)
        {
            SetSide((float)getSide()*percent/100);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            //kiểm thử hình tròn
                Circle circle = new Circle("blue",true,2.0f);
                Console.WriteLine(circle);
                circle.Resize(20);// resize còn 20% kích thước ban đầu
                Console.WriteLine("Sau khi resize Circle");
                Console.WriteLine(circle);

            //kiểm tra hình chữ nhật
                Rectangle rectangle=new Rectangle("yellow",false,5f,6f);
                Console.WriteLine(rectangle);
                rectangle.Resize(50);// ressize còn 50%
                Console.WriteLine("Sau khi resize Rectangle");
                Console.WriteLine(rectangle);
                
            //kiểm tra hình vuông
                Square square = new Square("red",true,7f);
                square.Resize(25);// resize còn 25%
                Console.WriteLine(square);

            Console.ReadKey();
        }
        }
}
