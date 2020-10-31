using System;

namespace bth5b4
{
    class PTB2
    {
        protected double a, b, c;
        public PTB2()
        {
            a = b = c = 0;
        }
        public PTB2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap a=");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nhap b=");
                b = double.Parse(Console.ReadLine());
                Console.Write("Nhap c=");
                c = double.Parse(Console.ReadLine());
            } while (a == 0 || b == 0 || c == 0);
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public void Giai()
        {
            double d = Delta();
            if (d < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (d == 0)
                Console.WriteLine("Phuong trinh co nghiem kep x1=x2=" + (-b / (2 * a)));
            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet \nx1={0}\nx2={2}", x1, x2);
            }
        }
    }
    class PTTP : PTB2
    {
        public new void Giai()
        {
            double d = Delta();
            if (d < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (d == 0)
            {
                double y = -b / (2 * a);
                if (y < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet\nx1={0}\nx2={1}", -Math.Sqrt(y), Math.Sqrt(y));
            }
            else
            {
                double y1 = (-b - Math.Sqrt(d)) / (2 * a);
                double y2 = (-b + Math.Sqrt(d)) / (2 * a);
                if (y1 > 0 && y2 > 0)
                {
                    double x1 = -Math.Sqrt(y1);
                    double x2 = Math.Sqrt(y1);
                    double x3 = -Math.Sqrt(y2);
                    double x4 = Math.Sqrt(y2);
                    Console.WriteLine("Phuong trinh co bon nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}\nx3={2}\nx4={3}", x1, x2, x3, x4);
                }
                else if (y1 > 0 && y2 < 0)
                {
                    double x1 = -Math.Sqrt(y1);
                    double x2 = Math.Sqrt(y1);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}", x1, x2);
                }
                else if (y1 < 0 && y2 > 0)
                {
                    double x1 = -Math.Sqrt(y2);
                    double x2 = Math.Sqrt(y2);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}", x1, x2);
                }
                else 
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
    class App
    {
        static void Main()
        {
            PTTP t = new PTTP();
            t.Nhap();
            t.Giai();
            Console.ReadKey();
        }
    }

}
