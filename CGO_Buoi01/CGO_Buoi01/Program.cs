﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 namespace : dự án lớn liên kết qua namespace
references : chỗ gọi lệnh này
 */

namespace CGO_Buoi01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding= Encoding.UTF8;// nhập có dấu
            Console.OutputEncoding= Encoding.UTF8;// xuất có dấu
            string sHoTen;
            Console.Write("Nhập tên của bạn: ");
            sHoTen = Console.ReadLine();
            Console.WriteLine("Tên của bạn là: " + sHoTen);

            Console.ReadKey();
        }
    }
}
