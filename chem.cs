using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chemie
{
    internal class chem
    {
        // -- L'énergie Total --
        // Et = En = -13.6 * z² / n² (ev)
        public static double ET(double n, double z)
        {
            double Et = (-13.06 * (Math.Pow(z, 2)) / (Math.Pow(n, 2)));
            return Et;
        }

        // -- L'energie absorbé  -- 
        // ΔE =  Etf - Eti ==> (final total energy) - (initial total energy) (ev)
        public static double ΔE1(double n1, double z, double n2)
        {
            double Etf = ((-13.6) * Math.Pow(z, 2)) / (Math.Pow(n1, 2));
            double Eti = ((-13.6) * Math.Pow(z, 2)) / (Math.Pow(n2, 2));
            double ΔE = Etf - Eti;

            return ΔE;
        }
        // --  deux éme loi  -- 
        // ΔE = h*c / λ
        // h = 6.62 * 10^-43 (j.s) j ==> joule
        // c = 3 * 10^8 (m/s)
        // λ = m
        public static double ΔE2(double λ)
        {
            double h = 6.62 * Math.Pow(10, -34);
            double c = 3 * Math.Pow(10, 8);
            double ΔE = (h * c) / λ;

            return ΔE;
        }
        // -- le rayon atomique  --  
        // rn = a0 * n² / z 
        // a0 = 0.529 / 0.53 (Å) ==> (angstrom) 
        public static double rn(double n, double z)
        {
            const double a0 = 0.53;
            double rn = (a0) * Math.Pow(n, 2) / (z);
            return rn;
        }
        // -- la vitesse de l'électron  --
        // Vn = 2.18 * 10^6 / n (m/s)

        public static double Vn(double n)
        {
            double Vn = (2.18 * Math.Pow(10, 6)) / n;
            return Vn;
        }
        // -- vitesse de l'électron deux éme loi 
        // v = n * h / 2 * π * m * r
        public static double Vn2(double n , double r) {
            const double pi = 3.14;
            const double h = 6620000;
            double v;
            v = (n * h) / (2 * pi * 9.1 * Math.Pow(10, -31) * r);
            return v;             
            
        }

        // -- la formule de ritz  -- 
        // 1/λ = RH * Z² ( (1/n²1) - (1-n²2) ) ==> (m)
        // RH  = 1.09 *10^7 (m^-1)

        public static double λ(double z, double n1, double n2)
        {
            double RH = 1.09 * Math.Pow(10, 7);
            double λ = (Math.Pow(n1, 2) * Math.Pow(n2, 2)) / ((RH * z) * (Math.Pow(n1, 2) * 1 - Math.Pow(n2, 2) * 1));
            return λ;
        }

        // -- La Fréquence -- 
        // Nu = c/λ

        public static double nu(double landa) {
            double nu; // m
            double c = (3 * Math.Pow(10, 8)); // m/s
            nu = c / landa;
            return nu;      
        }


    }
}
