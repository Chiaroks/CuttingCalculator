using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inst
{
    class Mark
    {
        public string Name { get; set; }
        public double B { get; set; }
        public double T { get; set; }
        public double Sz { get; set; }
        public double Cv { get; set; }
        public double Q { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double U { get; set; }
        public double P { get; set; }
        public double M { get; set; }
        public Mark(string Name, double B, double T, double Sz, double Cv, double Q, double X, double Y, double U, double P, double M)
        {
            this.Name = Name;
            this.B = B;
            this.T = T;
            this.Sz = Sz;
            this.Cv = Cv;
            this.Q = Q;
            this.X = X;
            this.Y = Y;
            this.U = U;
            this.P = P;
            this.M = M;
        }
    }
}
