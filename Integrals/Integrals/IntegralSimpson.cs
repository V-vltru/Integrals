using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    class IntegralSimpson : Integral
    {
        public IntegralSimpson(double startValue, double endValue, int steps, Func<double,double> integrand)
        {
            this.StartValue = startValue;
            this.EndValue = endValue;
            this.Steps = steps;
            this.Integrand = integrand;
        }

        public IntegralSimpson() { }

        public override double Calculate()
        {
            if (this.EndValue < this.StartValue)
            {
                throw new ArgumentException("Введены неправильные пределы! ");
            }

            if (this.Steps < 0)
            {
                throw new ArgumentException("N не может быть отрицательным! ");
            }

            double h = (this.EndValue - this.StartValue) / this.Steps;
            double newa = this.StartValue + 0.5 * h;
            double s = 0;
            double d = 0;
            for (int i = 0; i < this.Steps; i++)
            {
                d += 4 * this.Integrand(newa + h * i) + 2 * this.Integrand(this.StartValue + h * (i + 1));
            }

            s = (h / 6) * (d + this.Integrand(this.StartValue) - this.Integrand(this.EndValue));
            return s;
        }
    }
}
