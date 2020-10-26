using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inst
{
    class MillingModel 
    {
        
        public double CuttingDepth { get; set; }

        public double Feed { get; set; }
        public double Tenacity { get; set; }
        public double CoefKiv { get; set; }
        public double CoefKmv { get; set; }
        public double CoefKnv { get; set; }
        public double CoefC { get; set; }
        public double X { get; set; }
        public double M { get; set; }
        public double Y { get; set; }
        public double Result { get; set; }
        public double Knife { get; set; }
        public double Layer { get; set; }
        public double Q { get; set; }
        public double U { get; set; }
        public double P { get; set; }
        public double Diameter { get; set; }

        public double Calculate()
        {
            double CoefKu = CoefKiv * CoefKmv * CoefKnv;
            double Sz = Feed / Knife;
            double Denominator = Math.Pow(Tenacity, M) * Math.Pow(CuttingDepth, X) * Math.Pow(Sz, Y) * Math.Pow(Knife, P);
            return CoefC * Math.Pow(Diameter, Q) * CoefKu / (Denominator);
        
        }
    }
}
