using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public class Point
    {
        private int x, y;

        public Point() 
        {
            x = 0;
            y = 0;
        }

        public Point(int X, int Y)
        {
            x=X;
            y=Y;
        }

        public int X { get =>  x; set => x = value; }

        public int Y { get => y; set => y = value; }


    }
}
