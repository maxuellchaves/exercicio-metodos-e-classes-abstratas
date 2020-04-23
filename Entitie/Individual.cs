using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Métodos_abstratos.Entitie
{
    class Individual : Contributors
    {
        public double Health { get; set; }

        public Individual(string name, double annualIncome, double health) : base(name, annualIncome)
        {
            Health = health;
        }

        public override double Tax()
        {

            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (Health * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (Health * 0.5);
            }

        }
    }
}
