using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Hinhtru : HinhTron
    {
        private double Chieucao;

        public Hinhtru()
        {
            Chieucao = 6;
        }
        public Hinhtru(double bankinh, double Chieucao) : base(bankinh)
        {
            
            this.Chieucao = Chieucao;
        }
        public void setchieucao(double Chieucao)
        {
            this.Chieucao = Chieucao;
        }
        public double getchieucao()
        {
            return Chieucao;
        }
        public double Tinhdientich()
            {
            return 2 * base.Tinhdientich() +
                Tinhchuvi() * Chieucao;
        }
        public double Tinhthetich()
        {
            return base.Tinhdientich() * Chieucao;
        }
    }
    

}
