using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi1_DoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            float usd;
            double vnd;
            const float tigia = 23000; 
            Console.Write("Nhập số USD cần đổi");
            usd=Convert.ToSingle(Console.ReadLine());
            vnd = (double)usd * tigia;
            Console.WriteLine("Gía trị sau khi chuyển đổi:"+vnd);
            Console.ReadKey();
        }
    }
}
