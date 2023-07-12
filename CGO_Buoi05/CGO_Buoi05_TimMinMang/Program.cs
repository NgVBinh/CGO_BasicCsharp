using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_TimMinMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu mang: ");
            n=Convert.ToInt32(Console.ReadLine());

            int[] arr= new int[n];

            nhap(arr);

            xuat(arr);

            sapXepGiam(arr);

            Console.ReadKey();
        }
        static void nhap(int[] arr)
        {
            for(int i=0;i<arr.Length; i++)
            {
                Console.Write("Nhap a[{0}]: ",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void xuat(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i+"\t");
            Console.WriteLine();
        }
        public static void sapXepGiam(int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++)
                for(int j=i+1;j<arr.Length;j++)
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
            xuat(arr) ;
        }
    }
}
