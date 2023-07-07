using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi3_VeHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luachon;
            int d, r;
            Console.Write("Nhap dai: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap rong: ");
            r = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Print the rectangle");
                Console.WriteLine("2.Print the square triangle");
                Console.WriteLine("3.Print isosceles triangle");
                Console.WriteLine("4.Exit");
                Console.Write("Nhap lua chon: ");
                luachon=Convert.ToInt32(Console.ReadLine());

                switch (luachon) {
                    case 1:
                        {
                            for (int i = 0; i < d; i++)
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            // tam giác vuông góc dưới bên trái
                            for (int i = 0; i < d; i++)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                            //tam giác vuông góc trên bên trái
                            for (int i = 0; i < d; i++)
                            {
                                for (int j = r; j > i; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                            //tam giác vuông góc dưới bên phải
                            for (int i = 1; i <= d; i++)
                            {
                                // In ra các khoảng trắng 
                                for (int j = 1; j <= r - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                // In ra các dấu '*' 
                                for (int k = 1; k <= i; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            //hình tam giác góc vuông phía trên bên phải
                            for (int i = 1; i <= d; i++)
                            {
                                // In ra các khoảng trắng
                                for (int j = 1; j < i; j++)
                                {
                                    Console.Write(" ");
                                }

                                // In ra các dấu '*'
                                for (int k = i; k <= r; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        
                }
            } while (luachon != 4);
            Console.ReadKey();
        }
    }
}
