using System;
using System.IO;
using System.Net;

namespace TH5B2
{
    class HTG
    {
        private int a, b, c;
        public HTG()
        {
            a = b = c = 0;
        }
        public HTG(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap a:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap b:");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap c:");
                c = int.Parse(Console.ReadLine());
            } while (!(a + b > c && a + c > b && a < b + c));
        }
        public double TinhDT()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void HienThi()
        {
            Console.WriteLine("Thong tin hinh tam giac:canh a:{0},canh b:{1},canh c:{2},Dientich:{3}", a, b, c,TinhDT());
        }
    }
    class HTD : HTG
    {
        public int h;
        public HTD(int a, int b,int c,int h) : base(a, b, c)
        {
            this.h = h;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chieu cao:");
            h = int.Parse(Console.ReadLine());
        }
        public double TinhTheTich()
        {
            return TinhDT() * h;
        }
        public new void HienThi()
        {
            base.HienThi();
            Console.WriteLine("chieu cao:{0},The tich:{1}", h, TinhTheTich());
        }
    }
    class APP
    {
        static void Main()
        {
            HTG t = new HTG();
            t.Nhap();
            t.HienThi();
            Console.ReadKey();
        }
    }
}
