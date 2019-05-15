using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class IntegralRectangle : Integral
    {
        public IntegralRectangle(double startValue, double endValue, int steps, Func<double, double> integrand)
        {
            this.StartValue = startValue;
            this.EndValue = endValue;
            this.Steps = steps;
            this.Integrand = integrand;
        }

        public IntegralRectangle() { }

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
            double Newa = this.StartValue + 0.5 * h;
            double s = 0;
            double d = 0;
            for (int i = 0; i < this.Steps; i++)
            {
                d += this.Integrand(Newa + h * i);
            }

            s = h * d;
            return s;
        }

        public override double CalculateAsync()
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
            double Newa = this.StartValue + 0.5 * h;
            object obj = new object();
            double result = 0;

            Parallel.For(0, this.Steps, () => 0.0, (i, state, local) => 
            {
                local += this.Integrand(Newa + h * i);
                return local;
            }, local => 
            {
                lock (obj)
                {
                    result += local;
                }
            });

            result *= h;
            return h;
        }
    }
}
