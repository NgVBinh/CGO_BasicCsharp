using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongSoTrongFile
{
    internal class Program
    {
        public class ReadTextFile
        {
            private string path;
            public ReadTextFile() { }

            public ReadTextFile(string path)
            {
                this.path = path;
            }

            public string getPath() { 
                return path;
            }
            public void setPath(string path) {
                this.path = path;
            }

            public void Sum_File()
            {
                try
                {
                    if (File.Exists(path))
                    {
                        double tong = 0;
                        StreamReader sr = new StreamReader(path);
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            tong += Convert.ToInt32(line);
                        }
                        Console.WriteLine("Tong = {0}", tong);
                    }
                    else
                    {
                        Console.WriteLine("File khong ton tai");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        static void Main(string[] args)
        {

            string path;
            Console.Write("Nhap path: ");
            path = Console.ReadLine();
            
            ReadTextFile examp= new ReadTextFile();
            examp.setPath(path);

            examp.Sum_File();
            Console.ReadKey();

        }
    }
}
