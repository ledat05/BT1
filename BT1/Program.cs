using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class HinhTron
    {
        private double bankinh;
    
    public HinhTron()
        {
            bankinh = 5;
        }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public void setbankinh(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double getbankinh()
        {
            return bankinh;
        }
        public double Tinhdientich()
        {
            return Math.PI * bankinh * bankinh;
        }
        public double Tinhchuvi()
        {
            return Math.PI + 2 * bankinh;
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron ht = new HinhTron();
            Hinhtru htr = new Hinhtru();
            Console.WriteLine("Xuất hình tròn:bankinh:{0}--dientich:{1}--chuvi:{2}",ht.getbankinh(),ht.Tinhdientich(),ht.Tinhchuvi());
            Console.WriteLine("Xuất hình trụ:bankinh:{0}--Chieucao:{1}--dientich:{2}--thetich:{3}", htr.getbankinh(), htr.getchieucao(), htr.Tinhdientich(), htr.Tinhthetich());
            Console.ReadLine();
        }
    }
}
