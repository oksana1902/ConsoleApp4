using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Drob
    {
        double ch;
        double zn;
        public int indexator;

        public delegate void Sobitie(Drob Dr1, int num);
        public event Sobitie Sob1;
        public event Sobitie Sob2;
        public Drob(double x, double y)
        {
            ch = x; zn = y;
        }

        public double ToDouble(Drob a)
        {
            return (a.ch / a.zn);
        }

        public static Drob operator +(Drob Dr1, Drob Dr2)
        {
            return new Drob(Dr1.ch * Dr2.zn + Dr2.ch * Dr1.zn, Dr1.zn * Dr2.zn);
        }

        public static Drob operator -(Drob Dr1, Drob Dr2)
        {
            return new Drob(Dr1.ch * Dr2.zn - Dr2.ch * Dr1.zn, Dr1.zn * Dr2.zn);
        }

        public static Drob operator /(Drob Dr1, Drob Dr2)
        {
            return new Drob(Dr1.ch * Dr2.zn, Dr1.zn * Dr2.ch);
        }

        public static Drob operator *(Drob Dr1, Drob Dr2)
        {
            return new Drob(Dr1.ch * Dr2.ch, Dr1.zn * Dr2.zn);
        }

        public string Conversion(Drob a)
        {
            return (a.ch + "/" + a.zn);
        }

        public string Znak(Drob a)
        {
            if ((a.ch * a.zn) >= 0)
            {
                return "+";
            }
            else
            {
                return "-";
            }
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    indexator = (int)ch;
                }
                if (index == 1)
                {
                    indexator = (int)zn;
                }

                return indexator;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Drob Dr1 = new Drob(3, 8);
            Drob Dr2 = new Drob(2, 7);

            Drob Dr3 = Dr1 + Dr2;

            Console.WriteLine(Drob.Conversion(Dr3));

            Console.ReadKey();
        }
    }
}
