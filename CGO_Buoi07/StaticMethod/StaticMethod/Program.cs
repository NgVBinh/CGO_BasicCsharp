using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    internal class Program
    {

        public class Student
        {

            private int rollno;
            private string name;
            private static string college = "BBDIT";

            public Student() { }

            public Student(int rollno, string name)
            {
                this.rollno = rollno;
                this.name = name;
            }

            public static void Change()
            {
                college = "CodeGym";
            }

            public void Display()
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        }

        static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
            Console.ReadKey();
        }
    }
}
