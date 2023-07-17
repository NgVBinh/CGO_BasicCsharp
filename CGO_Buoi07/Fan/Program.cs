using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Program
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;
        public class Fan
        {
           

            private int speed = SLOW;
            private bool on = false;
            private double radius = 5;
            private string color = "blue";

            public Fan() { }
            public Fan(int speed, bool on, double radius, string color)
            {
                this.speed = speed;
                this.on = on;
                this.radius = radius;
                this.color = color;
            }

            public int getSpeed()
            {
                return this.speed;
            }
            public void setSpeed(int speed)
            {
                this.speed = speed;
            }
            public double getRadius() {
                return this.radius;
            }
            public void setRadius(int radius)
            {
                this.radius = radius;
            }
            public string getColor()
            {
                return this.color;
            }
            
            public void setColor(string color)
            {
                this.color = color;
            }
            public bool getOn()
            {
                return this.on;
            }
            public void setOn(bool on)
            {
                this.on=on;
            }

            public override string ToString()
            {
                if(on)
                return "Fan is on speed "+speed+" color "+ color+" radius "+radius;
                else return "Fan is off color " + color + " radius " + radius;
            }
        }
        static void Main(string[] args)
        {

            Fan fan1 = new Fan(FAST, true, 10, "yellow");
            Fan fan2 = new Fan(MEDIUM, false, 5, "blue");

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
            Console.ReadKey();
        }
    }
}
