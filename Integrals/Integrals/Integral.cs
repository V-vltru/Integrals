using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public abstract class Integral
    {
        public double StartValue { get; set; }

        public double EndValue { get; set; }

        public int Steps { get; set; }

        public Func<double, double> Integrand { get; set; }

        public abstract double Calculate();

        public abstract double CalculateAsync();
    }
}
