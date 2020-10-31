using System;

namespace BTH5B1
{
    class TienDien
    {
        public string TCH;
        public string DC;
        public int SDTT;
        public int SDTN;
        public TienDien()
        {
            DC = TCH = "";
            SDTT = SDTN = 0;
        }
        public TienDien(string DC, string TCH,int SDTT, int SDTN)
        {
            this.TCH = TCH;
            this.DC = DC;
            this.SDTT = SDTT;
            this.SDTN = SDTN;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten chu ho:");
            TCH = Console.ReadLine();
            Console.Write("Nhap dia chi chu ho:");
            DC = Console.ReadLine();
            Console.Write("Nhap so dien thang truoc:");
            SDTT = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dien thang nay:");
            SDTN = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("ten chu ho:{0},dia chi chu ho:{1},so sien thang truoc:{2},Sodien thang nay:{3}", TCH, DC, SDTT, SDTN);
        }
        public int SDSD
        {
            get
            {
                return  SDSD = SDTN - SDTT;
            }
            set
            {
                SDSD = value;
            }
        }
        public int TTD
        {
            get
            {
                return TTD = SDSD * 500;
            }
            set
            {
                TTD = value;
            }
        }    
    }
    class TienDienMoi : TienDien
    {
        public int hanmuc;
        public TienDienMoi(string TCH, string DC,int SDTT,int SDTN,int hanmuc) : base(TCN, DC, SDTT, SDTN)
        {
            this.hanmuc = hanmuc;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap han muc:");
            hanmuc = int.Parse(Console.ReadLine());
        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("hanmuc{0}", hanmuc);
        }
        public  void TTDM()
        {
            if (hanmuc <= 500)
            {
                return TTD() * 500;
            }
            else
                return TTD() * 600;
        }
    }
}
