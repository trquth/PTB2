using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB2
{
    public class PhuongTrinh2
    {
        public float a;
        public float b;
        public float c;
        public float delta;

        public void Nhap()
        {
            Console.WriteLine("Nhap vao bien thu nhat");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao bien thu hai ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao bien thu ba");
            c = float.Parse(Console.ReadLine());
        }
        public bool PTVoNghiem(float b, float c)
        {
            if (b == 0 && c != 0)
            {
                return false;
            }
            return true;
        }
        public void Hien()
        {
            float x;
            float x2;
            float x1;
            x1 = x2 = x = 0;
            delta = (b * b) - (4 * a * c);
            if (a == 0)
            {
                if (PTVoNghiem(b,c))
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                {
                    x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem " + x.ToString());
                }
            }
            else
            {
                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("Phuong trinh co nghiem" + x.ToString());
                }
                else
                {
                    x1 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("PHuong trinh co nhiem thu nhat" + x1.ToString());
                    Console.WriteLine("Phuong trinh co nghiem thu hai" + x2.ToString());
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhuongTrinh2 n = new PhuongTrinh2();

            n.Nhap();
            n.Hien();

            Console.Read();
        }
    }
}
