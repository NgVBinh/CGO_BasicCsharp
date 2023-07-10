using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi4_TimTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            string name_search;
            Console.Write("Nhap ten can tim: ");
            name_search=Console.ReadLine();
            
            bool flag_search=false;

            for(int i=0;i<students.Length;i++)
            {
                if (name_search.Equals(students[i]))
                {
                    flag_search=true;
                    Console.WriteLine("{0} tim thay tai vi tri so {1}",name_search,i+1);
                    break;
                }
            }

            if(flag_search==false) {
                Console.WriteLine("Khong tim thay ten {0}", name_search);
            }
            Console.ReadKey();
        }
    }
}
