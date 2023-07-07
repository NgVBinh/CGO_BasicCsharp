using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi3_SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Nhap so can kiem tra: ");
            number=Convert.ToInt32(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine("{0} khong phai la so nguyen to",number);
            }else if(number <= 3) {
                Console.WriteLine("{0} la so nguyen to", number);
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} khong phai la so nguyen to", number);
                }
                else
                {
                    bool flag = true;
                    for(int i=3;i<Math.Sqrt(number);i+=2) {
                        if (number % i == 0)
                        {
                            flag = false; break;
                        }
                    }
                    if(flag) {
                        Console.WriteLine("{0} la so nguyen to", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} khong phai la so nguyen to", number);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
