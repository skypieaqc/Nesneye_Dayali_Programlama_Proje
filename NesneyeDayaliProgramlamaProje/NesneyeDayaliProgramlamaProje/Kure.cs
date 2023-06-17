using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class Kure
    {
        int r;

        Point3D p;

        public Kure()
        {
            this.r = 0;
            this.p = new Point3D();
        }

        public Kure(int R, Point3D P)
        {
            this.r = R;
            this.p = P;
        }

        public int R { get => r; set => r = value; }

        public Point3D P { get => p; set => p = value; }



    }
}
