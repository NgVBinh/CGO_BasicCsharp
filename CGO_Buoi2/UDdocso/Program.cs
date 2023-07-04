using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDdocso
{
    internal class Program
    {
        public static string docso1chuso(int n)
        {
            string chu = "";
            switch (n)
            {
                case 0:
                    {
                        chu = "zero";
                        break;
                    }
                case 1:
                    {
                        chu = "one";
                        break;
                    }
                case 2:
                    {
                        chu = "two";
                        break;
                    }
                case 3:
                    {
                        chu = "three";
                        break;
                    }
                case 4:
                    {
                        chu = "four";
                        break;
                    }
                case 5:
                    {
                        chu = "five";
                        break;
                    }
                case 6:
                    {
                        chu = "six";
                        break;
                    }
                case 7:
                    {
                        chu = "seven";
                        break;
                    }
                case 8:
                    {
                        chu = "eight";
                        break;
                    }
                case 9:
                    {
                        chu = "nine";
                        break;
                    }
            }
            return chu;
        }

        public static string soduoi20(int n)
        {
            string chu = "";
            switch (n%10)
            {
                case 0:
                    {
                        chu = "ten";
                        break;
                    }
                case 1:
                    {
                        chu = "eleven";
                        break;
                    }
                case 2:
                    {
                        chu = "twele";
                        break;
                    }
                case 3:
                    {
                        chu = "thirteen";
                        break;
                    }
                case 4:
                    {
                        chu = "fourteen";
                        break;
                    }
                case 5:
                    {
                        chu = "fifteen";
                        break;
                    }
                case 6:
                    {
                        chu = "sixteen";
                        break;
                    }
                case 7:
                    {
                        chu = "seventeen";
                        break;
                    }
                case 8:
                    {
                        chu = "eighteen";
                        break;
                    }
                case 9:
                    {
                        chu = "nineteen";
                        break;
                    }
            }
            return chu;

        }

        public static string soduoi100(int n)
        {
            int ones = n % 10;
            int tens = n / 10;
            string docones="";
            if (ones > 0)
            {
                 docones = docso1chuso(ones);
            }
            
            string doctens="";
            switch (tens)
            {
                case 2:
                    {
                        doctens = "twenty";
                        break;
                    }
                case 3:
                    {
                        doctens = "thirty";
                        break;
                    }
                case 4:
                    {
                        doctens = "fourty";
                        break;
                    }
                case 5:
                    {
                        doctens = "fifty";
                        break;
                    }
                case 6:
                    {
                        doctens = "sixty";
                        break;
                    }
                case 7:
                    {
                        doctens = "seventy";
                        break;
                    }
                case 8:
                    {
                        doctens = "eighty";
                        break;
                    }
                case 9:
                    {
                        doctens = "ninety";
                        break;
                    }
            }
            string chu = doctens +" "+docones;
            return chu;
        }

        public static string sotren100(int n)
        {
            int hundreds = n / 100;
            int haisosau=n% 100;

            string read_hundreds = "";
            string read_haisosau = "";
            if(hundreds > 0)
            read_hundreds = docso1chuso(hundreds);
            if (haisosau < 10)
                read_haisosau = docso1chuso(haisosau);
            else if (haisosau < 20)
                read_haisosau = soduoi20(haisosau);
            else
                read_haisosau = soduoi100(haisosau);

            string chu = "";
            if (haisosau == 0)
            {
                chu = read_hundreds + " hundred";
            }
            else
                chu= read_hundreds+" hundred and "+ read_haisosau;

            return chu;
        }
        static void Main(string[] args)
        {
            int n;
            
            do
            {
                Console.Write("Nhap so can doc: ");
                n = Convert.ToInt32(Console.ReadLine());
                
            } while (n < 0 || n >= 1000);

            if (n > 0 && n < 10)
                Console.WriteLine( docso1chuso(n));
            else if (n < 20)
                Console.WriteLine( soduoi20(n));
            else if(n<100)
                Console.WriteLine(soduoi100(n));
            else
                Console.WriteLine(sotren100(n));        
            Console.ReadKey();

        }
    }
}
