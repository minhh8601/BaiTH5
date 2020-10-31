using System;
using System.Threading;

namespace bth5b5
{
    class Person
    {
        private string name, naturality;
        private int age;
        public Person()
        {
            name = naturality = "";
            age = 0;
        }
        public Person(string name, string naturality, int age)
        {
            this.name = name;
            this.naturality = naturality;
            this.age = age;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten:");
            name = Console.ReadLine();
            Console.Write("Nhap quoc tich:");
            naturality = Console.ReadLine();
            Console.Write(".Nhap tuoi:");
            age = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Ten:{0}, Tuoi:{1}, Quoc tich:{2}", name, age, naturality);
        }
    }
    class Player : Person
    {
        public int number;
        public string position;
        //team??
        public Player(string name, string naturality, int age, int number, string vttd):base(name, naturality, age)
        {
            this.number = number;
            this.position = position;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ao:");
            number = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri thi dau:");
            position = Console.ReadLine();
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Vi tri thi dau:{0}, so sao:{1}", position, number);
        }
    }
    class Coach : Person
    {
        public int year;
        public Coach(string name, string naturality, int age, int year):base(name, naturality, age)
        {
            this.year = year;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so nam huyen luyen:");
            year = int.Parse(Console.ReadLine());
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("So nam lam huyen luyen vien:{0}", year);
        }
    }
}
