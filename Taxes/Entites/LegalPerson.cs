using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes.Entites
{
    internal class LegalPerson: Gen
    {
        public int NumberEmployeers { get; set; }

        public LegalPerson(string name, double income, int numberEmployeers): base(name, income)
        {

            NumberEmployeers = numberEmployeers;
        }

        public override double Taxe()
        {
            double TaxeFinal;

            if (NumberEmployeers <= 10)
            {
                TaxeFinal = Income * 0.16 ;
            }
            else
            {
                TaxeFinal = Income * 0.14;
            }

            return TaxeFinal;
        }
    }
}
