using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_3D
{
    public class Point2D
    {
        private float x=0.0f;
        private float y=0.0f;

        public Point2D(){}

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float getX()
        {
            return x;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public float getY()
        {
            return y;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public float[] getXY()
        {
           return new float[] {x,y};
        }
        public void setXY(float x,float y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "Point2D: x= "+getX()+" y= "+getY();
        }
    }

    public class Point3D:Point2D {
        private float z=0.0f;

        public Point3D():base() { }
        public Point3D(float x,float y,float z):base(x,y) {
            this.z = z;
        }
        public float getZ()
        {
            return z;
        }
        public void setZ(float z)
        {
            this.z = z;
        }

        public void setXYZ(float x,float y,float z)
        {
            setX(x);
            setY(y);
            this.z=z;
        }
        public float[] getXYZ()
        {
            return new float[] { getX(), getY(), z };
        }
        public override string ToString()
        {
            return "Point3D x= "+getX()+" y= "+getY()+" z= "+getZ();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //thử class Point2D
            Point2D P1 = new Point2D();
            P1.setX(1.0f);
            P1.setY(2.0f);
            Console.WriteLine(P1);

            Point2D P2 = new Point2D();
            P2.setXY(1.0f,3.0f);
            Console.WriteLine(P2);

            //thử class Point3D
            Point3D point3D = new Point3D();
            point3D.setX(1.0f);
            point3D.setY(-5.0f);
            point3D.setZ(1.0f);
            Console.WriteLine(point3D);

            Point3D point3D2=new Point3D(2.5f,10f,7f);
            Console.WriteLine(point3D2 );

            Console.ReadKey();
        }
    }
}

