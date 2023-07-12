using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_DemKiTuTrongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            
            Console.Write("Nhap ki tu can dem: ");
            string t= Console.ReadLine();

            kiemtra(s, t);

            Console.ReadKey();

        }
        static void kiemtra(string s,string t)
        {
            int count = 0;
            for(int i=0;i<s.Length;i++)
                if (s[i].Equals(t))
                    count++;

            Console.WriteLine("Ki tu {0} xuat hien {1} lan.",t,count);
        }
    }
}
