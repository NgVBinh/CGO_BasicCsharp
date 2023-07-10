using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi4_TongMangMotChieu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[5];

            num[0] = 2;
            num[1] = 5;
            num[2] = 9;
            num[3] = 6;
            num[4] = 7;

            int total = 0;

            for(int i=0;i<num.Length; i++)
            {
                total += num[i];
            }
            Console.WriteLine("Tong phan tu trong mang: {0}",total);
            Console.ReadKey();
        }
    }
}
