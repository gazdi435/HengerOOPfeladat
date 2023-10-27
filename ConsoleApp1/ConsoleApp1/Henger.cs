using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private static int  szuletesSzamlalo;

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar;  }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }
       



        public virtual double Terfogat()
        {
            return Math.Round(Math.Pow(this.sugar, 2) * Math.PI * this.magassag,2);
        }

        public override string ToString()
        {
            return $"térfogat:{this.Terfogat()}; sugár:{this.GetSugar}; magasság:{this.GetMagassag};";
        }
    }
}