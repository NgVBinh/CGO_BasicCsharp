using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhChiSoCoThe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double height;
            double width;

            Console.Write("Nhap can nang: ");
            width=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            height=Convert.ToDouble(Console.ReadLine());

            double bmi = width /Math.Pow(height,2);
            
            bmi=Math.Round(bmi,1);

            Console.WriteLine("Chi so bmi: "+bmi);

            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal");
            else if (bmi < 30)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");

            Console.ReadKey();
        }
    }
}
