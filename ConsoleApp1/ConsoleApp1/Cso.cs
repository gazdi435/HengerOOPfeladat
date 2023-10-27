using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double falVastagsag, double magassag, double sugar) : base(magassag, sugar)
        {
            this.falVastagsag = falVastagsag;
        }
        public Cso(double magassag, double sugar) : base(magassag, sugar)
        {
            this.falVastagsag = 2;
        }

        public double FalVastagsag
        {
            get => this.falVastagsag;
        }

        public override double Terfogat()
        {
            return Math.Round(Math.Pow(this.GetSugar, 2) * Math.PI * this.GetMagassag - Math.Pow(this.GetSugar- this.falVastagsag, 2) * Math.PI * this.GetMagassag, 2);
        }

        public override string ToString()
        {
            return $"{base.ToString()} falvastagsága:{this.falVastagsag}";
        }
    }
}