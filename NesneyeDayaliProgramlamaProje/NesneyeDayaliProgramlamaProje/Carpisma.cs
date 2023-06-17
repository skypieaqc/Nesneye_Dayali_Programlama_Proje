using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayaliProgramlamaProje
{
    public static class Carpisma
    {

        public static bool CemberCemberCarpisma(cember c1, cember c2)
        {
            float mesafe = (float)Math.Sqrt(Math.Pow((c1.P.X - c2.P.X), 2) + Math.Pow((c1.P.Y - c2.P.Y), 2));

            if (mesafe < c1.R + c2.R)
                return true;
            else
                return false;
        }

        public static bool KureKureCarpisma(Kure k1, Kure k2)
        {
            float mesafe = (float)Math.Sqrt(Math.Pow((k1.P.X - k2.P.X), 2) + Math.Pow((k1.P.Y - k2.P.Y), 2) + Math.Pow((k1.P.Z - k2.P.Z),2));

            if (mesafe < k1.R + k2.R)
                return true;
            else
                return false;

        }

        public static bool DikdortgenDikdortgenCarpisma(dikdortgen d1, dikdortgen d2)
        {
            float Xmesafe = (float) Math.Abs(d1.P.X - d2.P.X);
            float Ymesafe = (float) Math.Abs(d1.P.Y - d2.P.Y); 

            if(Xmesafe < (d1.EN/2 + d2.EN/2) && Ymesafe < (d1.BOY/2 + d2.BOY / 2))
                return true;
            else 
                return false;
        }

        public static bool SilindirSilindirCarpisma(Silindir s1, Silindir s2)
        {
            Point3D pa = new Point3D(s1.P.X , s1.P.Y+ s1.H/2,s1.P.Z );
            Point3D pb = new Point3D(s2.P.X, s2.P.Y + s2.H / 2, s2.P.Z);

            float mesafe = (float) Math.Sqrt(Math.Pow((pa.X - pb.X), 2) + Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));

            if((s1.R + s2.R) > mesafe && Math.Abs(pa.Y - pb.Y) < ((s1.H + s2.H) / 2))
                return true;
            else 
                return false;
        }

        public static bool NoktaDikdortgenCarpisma(Point p1,dikdortgen d1)
        {
            float Xmesafe = (float)Math.Abs(d1.P.X - p1.X);
            float Ymesafe = (float)Math.Abs(d1.P.Y - p1.Y);
            
            if((Xmesafe < d1.EN/2) && (Ymesafe < d1.BOY/2))
                return true;
            else 
                return false;
        }

        public static bool NoktaCemberCarpisma(Point p1, cember c1)
        {
            float mesafe=(float )Math.Sqrt(Math.Pow((c1.P.X - p1.X),2)+Math.Pow((c1.P.Y- p1.Y),2));

            if(mesafe < c1.R)
                return true;
            else 
                return false;
        }

        public static bool NoktaKureCarpisma(Point3D p1, Kure k1)
        {
            float mesafe = (float)Math.Sqrt(Math.Pow((k1.P.X - p1.X), 2) + Math.Pow((k1.P.Y - p1.Y), 2) + Math.Pow((k1.P.Z- p1.Z),2));

            if (mesafe < k1.R)
                return true;
            else
                return false;
        }

        public static bool NoktaDikdortgenPrizmaCarpisma(Point3D p1, DikdortgenlerPrizma dp1)
        {
            if (((dp1.P.X - dp1.EN / 2) < p1.X && p1.X < (dp1.P.X + dp1.EN / 2)) && ((dp1.P.Y - dp1.BOY / 2) < p1.Y && p1.Y < (dp1.P.Y + dp1.BOY / 2)) && ((dp1.P.Z - dp1.DERINLIK / 2) < p1.Z && p1.Z < (dp1.P.Z + dp1.DERINLIK / 2)))
                return true;
            else
                return false;
        }

        public static bool DikdortgenPDikdortgenPCarpisma(DikdortgenlerPrizma dp1, DikdortgenlerPrizma dp2)
        {
            float Xmesafe = (float)Math.Abs(dp1.P.X - dp2.P.X);
            float Ymesafe = (float)Math.Abs(dp1.P.Y - dp2.P.Y);

            if (Xmesafe < (dp1.EN / 2 + dp2.EN / 2) && Ymesafe < (dp1.BOY / 2 + dp2.BOY / 2))
                return true;
            else
                return false;
        }

        public static bool CemberDikdortgenCarpisma(cember c1, dikdortgen d1)
        {
            float mesafe;

            //Sag ust
            if ((d1.P.X > c1.P.X) && (d1.P.Y > c1.P.Y) && ((d1.P.Y - d1.BOY / 2) > c1.P.Y) && ((d1.P.X - d1.EN / 2) > c1.P.X))
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((d1.P.X - d1.EN / 2) - c1.P.X), 2) + (Math.Pow(((d1.P.Y - d1.BOY / 2) - c1.P.Y), 2)));

                if (mesafe < c1.R)
                    return true;
                else
                    return false;
            }

            //Sag alt
            else if ((d1.P.X > c1.P.X) && (d1.P.Y < c1.P.Y) && ((d1.P.Y + d1.BOY / 2) < c1.P.Y) && ((d1.P.X - d1.EN / 2) > c1.P.X))
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((d1.P.X - d1.EN / 2) - c1.P.X), 2) + (Math.Pow(((d1.P.Y + d1.BOY / 2) - c1.P.Y), 2)));

                if (mesafe < c1.R)
                    return true;
                else
                    return false;
            }

            //sol ust
            else if ((d1.P.X < c1.P.X) && (d1.P.Y > c1.P.Y) && ((d1.P.Y - d1.BOY / 2) > c1.P.Y) && ((d1.P.X + d1.EN / 2) < c1.P.X))
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((d1.P.X + d1.EN / 2) - c1.P.X), 2) + (Math.Pow(((d1.P.Y - d1.BOY / 2) - c1.P.Y), 2)));

                if (mesafe < c1.R)
                    return true;
                else
                    return false;
            }

            //sol alt
            else if ((d1.P.X < c1.P.X) && (d1.P.Y < c1.P.Y) && ((d1.P.Y + d1.BOY / 2) < c1.P.Y) && ((d1.P.X + d1.EN / 2) < c1.P.X))
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((d1.P.X + d1.EN / 2) - c1.P.X), 2) + (Math.Pow(((d1.P.Y + d1.BOY / 2) - c1.P.Y), 2)));

                if (mesafe < c1.R)
                    return true;
                else
                    return false;
            }

            else if ((d1.P.X > c1.P.X) && (d1.P.X - d1.EN / 2) > c1.P.X)
            {

                if(c1.R > (d1.P.X-d1.EN/2-c1.P.X))
                    return true;
                else 
                    return false;

            }

            else if( (d1.P.X < c1.P.X) && (d1.P.X + d1.EN / 2) < c1.P.X)
            {
                if (c1.R > ( c1.P.X - (d1.P.X + d1.EN / 2)))
                    return true;
                else
                    return false;
            }

            else if((d1.P.Y > c1.P.Y ) &&  ( d1.P.Y - d1.BOY/2) > c1.P.Y)       
            {
                if(c1.R > ((d1.P.Y - d1.BOY / 2)-c1.P.Y))
                    return true;
                else
                    return false;
            }

            else if((d1.P.Y < c1.P.Y) && (d1.P.Y + d1.BOY/2) < c1.P.Y)
            {
                if(c1.R   > (c1.P.Y- (d1.P.Y + d1.BOY / 2)))
                    return true;
                else
                    return false;
            }

            else
                return false;
        }

        public static bool KureDikdortgenPCarpisma(Kure k1, DikdortgenlerPrizma dp1)
        {
            float mesafe;

            //sag ust arka
            if ((dp1.P.X - dp1.EN / 2) > k1.P.X && (dp1.P.Y - dp1.BOY / 2) > k1.P.Y && (dp1.P.Z - dp1.DERINLIK / 2) > k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X - dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y - dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z - dp1.DERINLIK / 2) - k1.P.Z), 2));

                if(mesafe < k1.R)
                    return true;
                else 
                    return false;
            }
             
            //sag ust onde
            else if ((dp1.P.X - dp1.EN / 2) > k1.P.X && (dp1.P.Y - dp1.BOY / 2) > k1.P.Y && (dp1.P.Z + dp1.DERINLIK / 2) < k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X - dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y - dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z + dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sag alt arka
            else if ((dp1.P.X - dp1.EN / 2) > k1.P.X && (dp1.P.Y + dp1.BOY / 2) < k1.P.Y && (dp1.P.Z - dp1.DERINLIK / 2) > k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X - dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y + dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z - dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sag alt onde
            else if ((dp1.P.X - dp1.EN / 2) > k1.P.X && (dp1.P.Y + dp1.BOY / 2) < k1.P.Y && (dp1.P.Z + dp1.DERINLIK / 2) < k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X - dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y + dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z + dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sol ust arka
            else if ((dp1.P.X + dp1.EN / 2) < k1.P.X && (dp1.P.Y - dp1.BOY / 2) > k1.P.Y && (dp1.P.Z - dp1.DERINLIK / 2) > k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X + dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y - dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z - dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sol ust onde
            else if ((dp1.P.X + dp1.EN / 2) < k1.P.X && (dp1.P.Y - dp1.BOY / 2) > k1.P.Y && (dp1.P.Z + dp1.DERINLIK / 2) < k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X + dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y - dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z + dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sol alt arka
            else if ((dp1.P.X + dp1.EN / 2) < k1.P.X && (dp1.P.Y + dp1.BOY / 2) < k1.P.Y && (dp1.P.Z - dp1.DERINLIK / 2) > k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X + dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y + dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z - dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sol alt onde 
            else if ((dp1.P.X + dp1.EN / 2) < k1.P.X && (dp1.P.Y + dp1.BOY / 2) < k1.P.Y && (dp1.P.Z + dp1.DERINLIK / 2) < k1.P.Z)
            {
                mesafe = (float)Math.Sqrt(Math.Pow(((dp1.P.X + dp1.EN / 2) - k1.P.X), 2) + Math.Pow(((dp1.P.Y + dp1.BOY / 2) - k1.P.Y), 2) + Math.Pow(((dp1.P.Z + dp1.DERINLIK / 2) - k1.P.Z), 2));

                if (mesafe < k1.R)
                    return true;
                else
                    return false;
            }

            //sag taraf
            else if (dp1.P.X - dp1.EN / 2 > k1.P.X)
            {
                if (dp1.P.X - dp1.EN / 2 - k1.P.X < k1.R)
                    return true;
                else 
                    return false;
            }

            //sol taraf
            else if (dp1.P.X + dp1.EN / 2 < k1.P.X)
            {
                if (k1.P.X - (dp1.P.X + dp1.EN / 2) < k1.R)
                    return true;
                else
                    return false;
            }

            //alt taraf
            else if (dp1.P.Y + dp1.BOY / 2 < k1.P.Y)
            {
                if ((k1.P.Y - (dp1.P.Y + dp1.BOY / 2)) < k1.R)
                    return true;
                else
                    return false;
            }

            //ust taraf
            else if (dp1.P.Y - dp1.BOY / 2 > k1.P.Y)
            {
                if ((dp1.P.Y - dp1.BOY / 2 - k1.P.Y) < k1.R)
                    return true;
                else
                    return false;
            }

            //arka taraf
            else if(dp1.P.Z-dp1.DERINLIK/2 > k1.P.Z)
            {
                if(dp1.P.Z - dp1.DERINLIK / 2- k1.P.Z < k1.R)
                    return true;
                else
                    return false;
            }

            //on taraf
            else
            {
                if (k1.P.Z - (dp1.P.Z + dp1.DERINLIK / 2) < k1.R)
                    return true;
                else
                    return false;
            }            

        }

    }
}
