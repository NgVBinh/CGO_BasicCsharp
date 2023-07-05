using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_BacNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a, b;
            Console.WriteLine("Nhap pt bac nhat ax+b=0 ");
            Console.Write("a= ");
            a=Convert.ToSingle(Console.ReadLine());
            Console.Write("b= ");
            b=Convert.ToSingle(Console.ReadLine());

            if (a == 0) {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                float x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem: {0}", x);
            }

            Console.ReadKey();
        }
    }
}
