using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double magassag, double sugar, double fajsuly) :base(magassag, sugar)
        {
            this.fajsuly = fajsuly;
        }
        public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
        {
            this.fajsuly = 7.87;
        }

        public double GetFajsuly
        {
            get => this.GetSuly / this.Terfogat();
        }

        public double GetSuly
        {
            get => this.fajsuly * this.Terfogat();

        }

        public override string ToString()
        {
            return $"{base.ToString()} fajsuly {this.GetFajsuly}";
        }
    }
}