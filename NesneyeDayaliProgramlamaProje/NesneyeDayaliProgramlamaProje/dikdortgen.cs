using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class dikdortgen
    {
        Point p;

        private int en, boy;

        public dikdortgen()
        {
            p= new Point();
            en=0;
            boy=0;
        }

        public dikdortgen(Point P,int EN,int BOY)
        {
            this.p= P;
            this.en= EN;
            this.boy= BOY;
        }

        public int EN { get=> en; set=> en= value; }
        public int BOY { get=> boy; set=> boy= value; }
        public Point P { get=> p; set => p = value;}


    }
}
