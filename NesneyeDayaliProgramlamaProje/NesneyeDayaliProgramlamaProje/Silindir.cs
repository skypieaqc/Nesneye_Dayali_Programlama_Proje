using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class Silindir
    {
        int r;

        Point3D p;

        int h;

        public Silindir()
        {
            this.r = 0;
            this.p = new Point3D();
            this.h = 0;
        }

        public Silindir(int R, int H,Point3D P)
        {
            this.r = R;
            this.p = P;
            this.h = H;

        }

        public int R {  get  => r; set => r = value; }
        public Point3D P { get => p; set => p = value; }
        public int H { get => h; set => h = value;}


    }
}
