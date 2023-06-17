using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class cember
    {
        private int r;

        Point p;

        public cember()
        {
            r= 0;
            p = new Point();
        }
        public cember(int R, Point P)
        {
            this.r = R;
            this.p = P;
        }

        public int R { get=>r ; set=>r= value; }

        public Point P { get=>p; set=>p= value; }



    }
}
