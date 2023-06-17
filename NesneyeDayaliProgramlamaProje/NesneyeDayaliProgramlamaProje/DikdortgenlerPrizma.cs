using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class DikdortgenlerPrizma
    {

        Point3D p;
        private int en, boy, derinlik;

        public DikdortgenlerPrizma()
        {
            this.p = new Point3D();
            this.en = 0;
            this.boy = 0;
            this.derinlik = 0;
        }

        public DikdortgenlerPrizma(Point3D P,int EN, int BOY , int DERINLIK)
        {
            this.p = P;
            this.en = EN;
            this.boy = BOY;
            this.derinlik= DERINLIK;
        }

        public int EN { get=> en; set=> en = value; }
        public int BOY { get=> boy; set=> boy = value; }
        public int DERINLIK { get=> derinlik; set => derinlik = value;}

        public Point3D P { get=> p; set => p = value;}






    }
}
