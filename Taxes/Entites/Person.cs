using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes.Entites
{   
    internal class Person : Gen
    {
        double Health { get; set; }

        public Person(string name, double income, double health) : base (name, income)
        {
            
            Health = health;
        }


        public override double Taxe()
        {
            double TaxeFinal;

            if (Income < 20000)
            {
                TaxeFinal = Income * 0.15;
            }
            else
            {
                TaxeFinal = Income * 0.25;
            }

            if (Health > 0)
            {
                TaxeFinal -= Health / 2;

            }

            return TaxeFinal;
        }
    }
}
