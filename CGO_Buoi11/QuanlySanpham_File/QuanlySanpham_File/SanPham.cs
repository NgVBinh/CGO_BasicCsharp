using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySanpham_File
{
    public class SanPham
    {
        private string masp;
        private string tensp;
        private string hangsp;
        private double gia;
        private string mota;
        public SanPham() { }
        public SanPham(string masp, string tensp, string hangsp, double gia, string mota)
        {
            this.Masp = masp;
            this.Tensp = tensp;
            this.Hangsp = hangsp;
            this.Gia = gia;
            this.Mota = mota;
        }

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Hangsp { get => hangsp; set => hangsp = value; }
        public double Gia { get => gia; set => gia = value; }
        public string Mota { get => mota; set => mota = value; }

        public override bool Equals(object obj)
        {
            return obj is SanPham pham &&
                   tensp == pham.tensp;
        }

        public override string ToString()
        {
            return "Ma sp: "+Masp+" Ten sp: "+Tensp+" Hang: "+Hangsp+" Gia: "+Gia+" Mo ta: "+Mota;
        }
    }
}
