using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace inst
{
    class Model
    {
        public double CuttingDepth { get; set; }

        public double Feed { get; set; }
        public double Tenacity { get; set; }
        public double CoefK { get; set; }
        public double CoefC { get; set; }
        public double X { get; set; }
        public double M { get; set; }
        public double Y { get; set; }
        public double Result { get; set; }
        public double Calculate()
        {
            return CoefC/(Math.Pow(Tenacity,M)*Math.Pow(CuttingDepth,X)*Math.Pow(Feed,Y))*CoefK;
            
        }
    }
}
