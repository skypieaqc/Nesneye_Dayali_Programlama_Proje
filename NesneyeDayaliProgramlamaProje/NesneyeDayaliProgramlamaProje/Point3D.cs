using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class Point3D :Point
    {
        private int z;

        public Point3D():base()
        {
            z = 0;
        }

        public Point3D(int X,int Y,int Z)
        {
            z = Z;
        }


        public int Z { get => z; set => z = value; }



    }
}
