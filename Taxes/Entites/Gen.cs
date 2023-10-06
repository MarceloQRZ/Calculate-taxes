using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes.Entites
{
    internal abstract class Gen
    {
        public  string Name { get; set; }
        public double Income { get; set; }

        public Gen(string name, double income)
        {
            this.Name = name;
            this.Income = income;
        }

        public abstract double Taxe();

    }
}
