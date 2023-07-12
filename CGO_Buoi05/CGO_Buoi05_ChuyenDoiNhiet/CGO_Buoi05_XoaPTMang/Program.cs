using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_XoaPTMang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("Nhap so phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            nhap(arr,n);

            xuat(arr,n);

            int k;
            Console.Write("Nhap vi tri can xoa: ");
            k= Convert.ToInt32(Console.ReadLine());

            xoapt(arr, k,ref n);
            xuat(arr, n);
            Console.ReadKey();
        }

        static void nhap(int[] arr,int  n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void xuat(int[] arr,int n)
        {
            for(int i =0;i<n;i++)
                Console.Write(arr[i] + "\t");
            Console.WriteLine();
        }

        public static void xoapt(int[] arr,int k,ref int n)
        {
            for (int i = k-1; i <n-1; i++)
                arr[i] = arr[i + 1];
            n--;
            
        }
    }
}
